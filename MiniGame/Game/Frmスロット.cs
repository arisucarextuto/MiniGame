using MiniGame.Cls;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frmスロット : Form
    {
        private String[] img = new String[3];

        public Frmスロット()
        {
            InitializeComponent();

            IblMsg.Visible = false;

            btnStop1.Enabled = false;
            btnStop2.Enabled = false;
            btnStop3.Enabled = false;

            img[0] = @"C:\Users\asuthiru\source\repos\フォームアプリ\MiniGame\MiniGame\Resources\グー.png";
            img[1] = @"C:\Users\asuthiru\source\repos\フォームアプリ\MiniGame\MiniGame\Resources\チョキ.png";
            img[2] = @"C:\Users\asuthiru\source\repos\フォームアプリ\MiniGame\MiniGame\Resources\パー.png";

            pb1.ImageLocation = img[0];
            pb2.ImageLocation = img[0];
            pb3.ImageLocation = img[0];
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            IblMsg.Visible = false;
            btnStart.Enabled = false;
            btn戻る.Enabled = false;

            btnStop1.Enabled = true;
            btnStop2.Enabled = true;
            btnStop3.Enabled = true;

            Random r = new Random();
            int index = 0;

            while (true)
            {
                if (btnStop1.Enabled == false &&
                    btnStop2.Enabled == false &&
                    btnStop3.Enabled == false)
                {
                    if (pb1.ImageLocation == pb2.ImageLocation &&
                        pb2.ImageLocation == pb3.ImageLocation)
                    {
                        IblMsg.Visible = true;
                        IblMsg.Text = "あたり";
                    }
                    else
                    {
                        IblMsg.Visible = true;
                        IblMsg.Text = "はずれ";
                    }

                    btnStart.Enabled = true;
                    btn戻る.Enabled = true;
                    break;
                }

                if (btnStop1.Enabled)
                {
                    index = r.Next(3);  //0 ～ 2
                    pb1.ImageLocation = img[index];
                }

                if (btnStop2.Enabled)
                {
                    index = r.Next(3);  //0 ～ 2
                    pb2.ImageLocation = img[index];
                }

                if (btnStop3.Enabled)
                {
                    index = r.Next(3);  //0 ～ 2
                    pb3.ImageLocation = img[index];
                }

                await Task.Delay(100);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
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
