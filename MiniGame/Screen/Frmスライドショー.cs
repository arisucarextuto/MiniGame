using MiniGame.Screen;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniGame.Cls
{
    public partial class Frmスライドショー : Form
    {
        /// <summary>
        /// プロジェクトファイルパス
        /// </summary>
        public string proFilePath { get; set; }

        private ClsSetting setting;
        private int Index;     //現在表示している画像のNo

        public Frmスライドショー()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == btn開始.Text)
            {
                timer.Start();
            }
            else if (btn.Text == btn停止.Text)
            {
                timer.Stop();
            }
            else if (btn.Text == btn戻る.Text)
            {
                Frmプロジェクト読込み frm = new Frmプロジェクト読込み();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Text == btn終了.Text)
            {
                this.Close();
            }
        }

        private void Frmスライドショー_Load(object sender, EventArgs e)
        {
            Init();
            if (setting != null)
            {
                if (setting.Val画像切替 == ClsSetting.e画像切替.自動)
                {
                    doAuto();
                }
            }
        }

        private void Init()
        {
            ClsSlideshow slide = new ClsSlideshow();
            setting = slide.readXML(this.proFilePath);
            if (setting == null)
            {
                MessageBox.Show("プロジェクトファイルが読み込めませんでした。");
                Frmプロジェクト読込み frm = new Frmプロジェクト読込み();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else
            {
                this.Text = "スライドショー(" + setting.Val画像切替.ToString() + ")";

                btn開始.Enabled = true;
                btn停止.Enabled = true;
                if (setting.Val画像切替 == ClsSetting.e画像切替.手動)
                {
                    btn開始.Enabled = false;
                    btn停止.Enabled = false;
                }
                //1枚目の画像を設定]
                Index = 0;
                SetPictureBox();
            }

        }

        private void doAuto()
        {
            //1秒 = 1000ミリ秒
            timer.Interval = (int)setting.Val画像表示間隔 * 1000;
            timer.Enabled = true;
            timer.Stop();
        }

        private void pb画像_SizeChanged(object sender, EventArgs e)
        {
            SetPictureBox();
        }

        private void Frmスライドショー_KeyDown(object sender, KeyEventArgs e)
        {

            if (setting.Val画像切替 == ClsSetting.e画像切替.自動)
            {
                return;
            }

            switch (e.KeyData)
            {
                case Keys.A:

                    if (Index != 0)
                    {
                        Index--;
                    }

                    break;
                case Keys.D:
                    if (Index != setting.dtImageList.Rows.Count - 1)
                    {
                        Index++;
                    }

                    break;
                default:
                    break;
            }
            SetPictureBox();

        }

        private void SetPictureBox()
        {
            ClsSlideshow slide = new ClsSlideshow();
            //1枚目の画像を設定
            Console.WriteLine(Index);
            string valFilePath = setting.dtImageList.Rows[Index][ClsSetting.DgvImageListCOL.画像ファイルパス.ToString()].ToString();
            Bitmap img = new Bitmap(valFilePath);
            pb画像.Image = slide.ScalingImage(img, pb画像.Width, pb画像.Height);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SetPictureBox();
            if (Index != setting.dtImageList.Rows.Count - 1)
            {
                Index++;
            }
            else
            {
                Index = 0;
                timer.Stop();
            }
        }
    }
}
