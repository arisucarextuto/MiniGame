using MiniGame.Cls;
using System;
using System.Media;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frmタイマー : Form
    {
        private string fileName = "";

        int m;      //分
        int s;      //秒
        int time;   //時間

        public Frmタイマー()
        {
            InitializeComponent();

            btnM.Enabled = true;
            btnS.Enabled = true;
            btnStart.Enabled = true;
            btnreset.Enabled = true;
            btnStop.Enabled = false;
            btn戻る.Enabled = true;

            timer1.Interval = 1000; //時間間隔(1秒)
            Init();
        }

        private void Frmタイマー_Load(object sender, EventArgs e)
        {
            // ドラッグドロップを受け付ける
            lbFilePath.AllowDrop = true;
        }

        private void lbFilePath_DragEnter(object sender, DragEventArgs e)
        {
            // ドラッグドロップ時にカーソルの形状を変更
            e.Effect = DragDropEffects.All;
        }

        private void lbFilePath_DragDrop(object sender, DragEventArgs e)
        {
            // ファイルが渡されていなければ、何もしない
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            // 渡されたファイルに対して処理を行う
            foreach (var filePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                fileName = filePath;
                lbFilePath.Items.Add(filePath);
            }
        }

        private void Init()
        {
            m = 0;
            s = 0;
            time = 0;
            WriteTimeText();
        }

        private void WriteTimeText()
        {
            lblTime.Text = String.Format("{0:00}:{1:00}", m, s);
        }

        private void btnMS_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn == btnM)        //分
            {
                m++;
                if (m == 60)
                {
                    m = 0;
                }
            }
            else if (btn == btnS)   //秒
            {
                s++;
                if (s == 60)
                {
                    s = 0;
                }
            }

            WriteTimeText();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                MessageBox.Show("アラーム音楽が設定されていません。");
            } 
            else
            {
                time = (m * 60 + s) * 1000;  //ミリ秒

                if (time == 0)
                {
                    MessageBox.Show("時間が設定されていません。");
                }
                else
                {
                    btnM.Enabled = false;
                    btnS.Enabled = false;
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    btnreset.Enabled = false;
                    btn戻る.Enabled = false;

                    timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1000;
            m = time / 60000;
            s = (time % 60000) / 1000;
            Console.WriteLine(time);
            Console.WriteLine(m);
            Console.WriteLine(s);

            WriteTimeText();
            if (time == 0)
            {
                btnM.Enabled = true;
                btnS.Enabled = true;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                btnreset.Enabled = true;
                btn戻る.Enabled = true;

                timer1.Stop();
                Sound();    //サウンドを鳴らす
                Init();     //初期化処理(リセット)
                return;
            }
        }

        private void Sound()
        {
            string path = fileName;
            SoundPlayer wavePlayer = new SoundPlayer(path);
            wavePlayer.PlayLooping();   //ループ再生

            if (MessageBox.Show("時間になりました!",this.Text,MessageBoxButtons.OK) == DialogResult.OK)
            {
                wavePlayer.Stop();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Init();
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnM.Enabled = true;
            btnS.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnreset.Enabled = true;
            btn戻る.Enabled = true;

            timer1.Stop();
        }
    }
}
