using MiniGame.Cls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static MiniGame.Const;
using static MiniGame.Masu;

namespace MiniGame
{
    public partial class Frmマインスイーパー : Form
    {
        Masu[,] board = null;
        const int WIDTH = 9;        //幅
        const int HEIGHT = 9;       //高さ
        const int MINE_MAX = 10;    //地雷の数

        TimeSpan gTs;

        public Frmマインスイーパー()
        {
            InitializeComponent();
        }

        private void Frmマインスイーパー_Load(object sender, EventArgs e)
        {
            UneableMasu();
            this.ActiveControl = btn開始;
        }

        /// <summary>
        /// 初期化
        /// </summary>
        private void init()
        {
            gTs = new TimeSpan(0, 0, 0);
            //2次元配列
            board = new Masu[HEIGHT, WIDTH];

            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    board[y, x] = new Masu();
                }
            }

            //地雷の設置
            Random r = new Random();
            int rand = 0;

            int wx, wy; //地雷を設置する位置(x, y)
            int cnt = 0;
            while (cnt < MINE_MAX)
            {
                rand = r.Next(81);  //0～80

                wx = rand / WIDTH;
                wy = rand % WIDTH;

                if (board[wy, wx].IsMine()) //地雷かどうか
                {
                    continue;
                }

                board[wy, wx].MType = MasuType.Mine;

                Debug.WriteLine(rand);

                cnt++;

            }

            //ヒント数字の設定
            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    if (board[y, x].IsMine())
                    {
                        SetHint(y, x);  //ヒント数字設定
                    }
                }
            }

            SetMasu();
            Ibl残数.Text = MINE_MAX.ToString();

            //デバッグ表示
            string s = "";
            for (int y = 0; y < HEIGHT; y++)
            {
                s = "";

                for (int x = 0; x < WIDTH; x++)
                {
                    if (x == 0)
                    {
                        s = board[y, x].getText();
                    }
                    else
                    {
                        s = s + "," + board[y, x].getText();
                    }
                }

                Debug.WriteLine(s);
            }

            /*//ボタン表示
            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    Controls["btn" + y.ToString() + x.ToString()].Text = board[y, x].getText();
                }
            }*/

        }

        public void SetHint(int mineY, int mineX)
        {
            int x, y;
            for (int dy = -1; dy <= 1; dy++)
            {
                for (int dx = -1; dx <= 1; dx++)
                {
                    x = mineX + dx;
                    y = mineY + dy;

                    if (x == mineX && y == mineY)
                    {
                        continue;
                    }

                    if ((x >= 0 && x < WIDTH) && (y >= 0 && y < HEIGHT))
                    {
                        if (board[y, x].IsMine())
                        {
                            continue;   //地雷はスキップ
                        }

                        board[y, x].MType = MasuType.Number;
                        board[y, x].Number++;
                    }
                    else
                    {
                        continue;   //盤面の範囲外のため、スキップ
                    }
                }
            }
        }

        private void btn開始_Click(object sender, EventArgs e)
        {
            btn開始.Enabled = false;
            btn戻る.Enabled = false;
            init();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 1);
            gTs += ts;

            Ibl経過時間.Text = gTs.ToString();
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            //ボタン名称から位置(x, y)を取得
            int y = int.Parse(btn.Name.Substring(3, 1));
            int x = int.Parse(btn.Name.Substring(4, 1));

            switch (e.Button)
            {
                case MouseButtons.Right:

                    bool ret = setMemo(x, y);
                    if (ret)
                    {
                        btn.Text = board[y, x].getMemo();
                        btn.ForeColor = Color.Black;
                    }

                    break;
            }
        }

        /// <summary>
        /// メモに表示する開いたを取得
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool setMemo(int x, int y)
        {
            if (board[y, x].IsOpen)
            {
                return false;
            }

            if (board[y, x].Memo == Mark.Empty)
            {
                board[y, x].Memo = Mark.Flag;
                int 残数 = int.Parse(Ibl残数.Text) - 1;
                Ibl残数.Text = 残数.ToString();
            }
            else if (board[y, x].Memo == Mark.Flag)
            {
                board[y, x].Memo = Mark.Hatena;
                int 残数 = int.Parse(Ibl残数.Text) - 1;
                Ibl残数.Text = 残数.ToString();
            }
            else
            {
                board[y, x].Memo = Mark.Empty;
            }

            return true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //ボタン名称から位置(x, y)を取得
            int y = int.Parse(btn.Name.Substring(3, 1));
            int x = int.Parse(btn.Name.Substring(4, 1));

            if (board[y, x].getMemo() != "")
            {
                //マークがついている場合は、何もしない
                return;
            }

            open(x, y);
            SetMasu();
            Ibl残数.Text = countFlag().ToString();

            EndCode ec = judge(x, y);

            if (ec == EndCode.Success)
            {
                timer1.Stop();
                UneableMasu();
                //成功
                MessageBox.Show("おめでとう！");
                btn開始.Enabled = true;
                btn戻る.Enabled = true;
            }
            else if (ec == EndCode.GameOver)
            {
                timer1.Stop();
                //ゲームオーバー
                btn.Text = board[y, x].getText();
                btn.BackColor = Color.Red;

                //地雷を全て開く
                int cnt = 1;
                for (int wy = 0; wy < HEIGHT; wy++)
                {
                    for (int wx = 0; wx < WIDTH; wx++)
                    {

                        if (board[wy, wx].IsMine())
                        {
                            Controls["btn" + wy.ToString() + wx.ToString()].Text = board[wy, wx].getText();
                            cnt++;

                            if (cnt == MINE_MAX)
                            {
                                break;
                            }
                        }
                    }

                    if (cnt == MINE_MAX)
                    {
                        break;
                    }
                }

                UneableMasu();
                MessageBox.Show("失敗");
                btn開始.Enabled = true;
                btn戻る.Enabled = true;
            }
        }

        private void open(int x, int y)
        {

            //盤面外の場合、return
            if (!(x >= 0 && x < WIDTH && y >= 0 && y < HEIGHT))
            {
                return;
            }

            //既に開かれている場合
            if (board[y, x].IsOpen)
            {
                return;
            }

            //地雷の場合、開かない
            if (board[y, x].IsMine())
            {
                return;
            }

            board[y, x].IsOpen = true;      //Open状態にする

            if (board[y, x].Number == 0)    //空マスなら周りのマスを開く
            {
                open(x - 1, y - 1); //左上
                open(x, y - 1);     //上
                open(x + 1, y - 1); //右上

                open(x - 1, y);     //左
                //open(x, y);
                open(x + 1, y);     //右

                open(x - 1, y + 1); //左下
                open(x, y + 1);     //下
                open(x + 1, y + 1); //右下
            }
        }

        private void SetMasu()
        {
            Control[] c;
            Button btn = null;

            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    c = this.Controls.Find("btn" + y.ToString() + x.ToString(), true);
                    if (c.Length > 0)
                    {
                        btn = (Button)c[0];
                    }

                    if (board[y, x].IsOpen)
                    {
                        btn.Text = board[y, x].getText();
                        btn.BackColor = Color.Yellow;
                    }
                    else
                    {
                        btn.Text = board[y, x].getMemo();
                        btn.BackColor = SystemColors.Control;
                    }
                    btn.ForeColor = board[y, x].getColor();
                    btn.Enabled = true;
                }
            }
        }

        private int countFlag()
        {
            int flagCnt = 0;

            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    if (board[y, x].IsOpen)
                    {
                        continue;
                    }

                    if (board[y, x].Memo == Mark.Flag)
                    {
                        flagCnt++;
                    }
                }
            }

            return MINE_MAX - flagCnt;
        }

        /// <summary>
        /// ゲーム判定
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private EndCode judge(int x, int y)
        {
            //地雷の場合、ゲーム終了
            if (board[y, x].IsMine())
            {
                return EndCode.GameOver;
            }

            int CloseCnt = 0;   //開かれているマスの数

            //地雷以外のマスを開いた場合、成功
            for (int wy = 0; wy < HEIGHT; wy++)
            {
                for (int wx = 0; wx < WIDTH; wx++)
                {
                    if (!(board[wy, wx].IsOpen))
                    {
                        CloseCnt++;
                    }
                }
            }

            if (CloseCnt == MINE_MAX)
            {
                return EndCode.Success;
            }

            return EndCode.Continue;
        }

        private void UneableMasu()
        {
            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    Controls["btn" + y.ToString() + x.ToString()].Enabled = false;
                }
            }
        }

        private void btn戻る_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == btn戻る.Text)
            {
                Frmメニュー frm = new Frmメニュー();
                ClsForm.Instance.formShow(frm);
            }
            this.Close();
        }
    }
}
