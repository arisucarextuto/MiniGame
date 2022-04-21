using MiniGame.Cls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frmもぐらたたき : Form
    {
        int cnt;

        enum Mogura
        {
            大,
            中,
            小,
            未設定
        }

        public Frmもぐらたたき()
        {
            InitializeComponent();
            resetMogura();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cnt = 0;
            btnStart.Enabled = false;
            btn戻る.Enabled = false;
            timer1.Interval = 1000; //ミリ秒　1秒 = 1000ミリ秒
            timer1.Start();

            IblScore.Text = "0";    //スコアリセット
            もぐら();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt++;  //1秒に1カウントアップ

            if (cnt == 20)  //20秒でゲーム終了
            {
                timer1.Stop();
                MessageBox.Show("ゲーム終了");
                btnStart.Enabled = true;
                btn戻る.Enabled = true;
                resetMogura();
            }
            else
            {
                もぐら();
            }
        }

        private void もぐら()
        {
            resetMogura();

            int seed;                                   //シード値
            int appearCnt;                              //出現数
            List<int> appears = new List<int>();        //出現場所

            seed = Convert.ToInt32(Guid.NewGuid().ToString("N").Substring(0, 8), 16);   //16進数⇒10進数
            appearCnt = new Random(seed).Next(1, 10);   //1～9の乱数

            //出現場所をリストに格納(1～9)
            for (int i = 1; i < 10; i++)
            {
                appears.Add(i);
            }

            //出現数分の出現場所を決める
            //1～9の数字をシャッフルして、先頭からappearCnt分取得する
            appears = appears.OrderBy(x => Guid.NewGuid()).ToList();

            Control[] c;
            for (int i = 0; i < appearCnt; i++)
            {
                int appear = appears[i];
                int rand;

                //出現させるもぐら
                seed = Convert.ToInt32(Guid.NewGuid().ToString("N").Substring(0, 8), 16);   //16進数⇒10進数
                rand = new Random(seed).Next(1, 10);   //1～9の乱数

                Mogura mog = Mogura.未設定;
                Button btn;
                switch (rand)
                {
                    case 1:

                        mog = Mogura.大;
                        break;

                    case 2:
                    case 3:
                    case 4:

                        mog = Mogura.中;
                        break;

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:

                        mog = Mogura.小;
                        break;
                }

                //ボタン設定
                c = Controls.Find("btn" + appear, true);
                btn = (Button)c[0];

                btn.Tag = mog;
                btn.Text = GetMogura(mog);
                btn.Enabled = true;
                btn.Visible = true;

            }
        }

        private void resetMogura()
        {
            for (int i = 1; i < 10; i++)
            {
                Control[] c = Controls.Find("btn" + i, true);
                Button btn = (Button)c[0];

                btn.Tag = "";
                btn.Text = "";
                btn.Enabled = false;
                btn.Visible = false;
            }
        }

        private String GetMogura(Mogura mog)
        {
            string ret = "";

            switch (mog)
            {
                case Mogura.大:

                    ret = "◎";
                    break;

                case Mogura.中:

                    ret = "〇";
                    break;

                case Mogura.小:

                    ret = "△";
                    break;
            }

            return ret;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int score = int.Parse(IblScore.Text);

            btn.Enabled = false;

            switch (btn.Tag)
            {
                case Mogura.大:

                    score += 50;
                    break;

                case Mogura.中:

                    score += 20;
                    break;

                case Mogura.小:

                    score += 10;
                    break;
            }

            IblScore.Text = score.ToString();
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
