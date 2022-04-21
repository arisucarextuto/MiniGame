using MiniGame.Cls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frmじゃんけん : Form
    {

        private enum eJanken
        {
            グー,
            チョキ,
            パー,
            None
        }

        private eJanken com;

        public Frmじゃんけん()
        {
            InitializeComponent();
        }

        private void btnスタート_Click(object sender, EventArgs e)
        {
            btnスタート.Enabled = false;
            btn戻る.Enabled = false;

            Ibl勝敗.Visible = false;
            IblReady.Visible = true;
            pbCPU.Visible = false;

            btnグー.Enabled = true;
            btnチョキ.Enabled = true;
            btnパー.Enabled = true;

            btnグー.BackColor = Color.White;
            btnチョキ.BackColor = Color.White;
            btnパー.BackColor = Color.White;

            Random r = new Random();
            int comJanken;
            comJanken = r.Next(3);   //0以上、3未満

            if (comJanken == (int)eJanken.グー)
            {
                pbCPU.Image = Properties.Resources.グー;
            }
            else if (comJanken == (int)eJanken.チョキ)
            {
                pbCPU.Image = Properties.Resources.チョキ;
            }
            else if (comJanken == (int)eJanken.パー)
            {
                pbCPU.Image = Properties.Resources.パー;
            }

            com = (eJanken)comJanken;
        }

        private void Frmじゃんけん_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            btnグー.Enabled = false;
            btnチョキ.Enabled = false;
            btnパー.Enabled = false;

            btnグー.BackColor = Color.LightGray;
            btnチョキ.BackColor = Color.LightGray;
            btnパー.BackColor = Color.LightGray;
            
            Ibl勝敗.Visible = false;
            IblReady.Visible = false;
            pbCPU.Visible = false;
        }

        private void btnじゃんけん_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            IblReady.Visible = false;
            pbCPU.Visible = true;

            eJanken junken = eJanken.None;
            if (btn.Name == btnグー.Name)
            {
                junken = eJanken.グー;
                btnグー.BackColor = Color.LightGray;
            }
            else if (btn.Name == btnチョキ.Name)
            {
                junken = eJanken.チョキ;
                btnチョキ.BackColor = Color.LightGray;
            }
            else if (btn.Name == btnパー.Name)
            {
                junken = eJanken.パー;
                btnパー.BackColor = Color.LightGray;
            }

            judge(junken);

            btnグー.Enabled = false;
            btnチョキ.Enabled = false;
            btnパー.Enabled = false;

            btnスタート.Enabled = true;
            btn戻る.Enabled = true;

        }

        private void judge(eJanken janken)
        {
            if (janken == eJanken.グー)
            {
                //Console.WriteLine("グーが選択されました。");
                if (com == eJanken.グー)
                {
                    //Console.WriteLine("グー");
                    Ibl勝敗.Text = "あいこ";
                }
                else if (com == eJanken.チョキ)
                {
                    //Console.WriteLine("チョキ");
                    Ibl勝敗.Text = "勝ち";
                }
                else if (com == eJanken.パー)
                {
                    //Console.WriteLine("パー");
                    Ibl勝敗.Text = "負け";
                }
            }
            else if (janken == eJanken.チョキ)
            {
                if (com == eJanken.グー)
                {
                    //Console.WriteLine("グー");
                    Ibl勝敗.Text = "負け";
                }
                else if (com == eJanken.チョキ)
                {
                    //Console.WriteLine("チョキ");
                    Ibl勝敗.Text = "あいこ";
                }
                else if (com == eJanken.パー)
                {
                    //Console.WriteLine("パー");
                    Ibl勝敗.Text = "勝ち";
                }
            }
            else if (janken == eJanken.パー)
            {
                //Console.WriteLine("パーが選択されました。");
                if (com == eJanken.グー)
                {
                    //Console.WriteLine("グー");
                    Ibl勝敗.Text = "勝ち";
                }
                else if (com == eJanken.チョキ)
                {
                    //Console.WriteLine("チョキ");
                    Ibl勝敗.Text = "負け";
                }
                else if (com == eJanken.パー)
                {
                    //Console.WriteLine("パー");
                    Ibl勝敗.Text = "あいこ";
                }
            }

            Ibl勝敗.Visible = true;
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
