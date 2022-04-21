using MiniGame.Cls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frm神経衰弱 : Form
    {
        private string[] str = new string[] { "●", "▲", "◆", "■", "×" };
        private const int yLen = 2;
        private const int xLen = 5;
        private Color cBack = SystemColors.Control;     //裏
        private Color cCorrect = Color.Red;             //正解
        private Color cOpen = Color.Black;              //今開いている
        private Button oBtn;
        private int cntCorrect; //正解の数

        private bool is後半;

        public Frm神経衰弱()
        {
            InitializeComponent();
            //init();
        }

        private void init()
        {
            Random r = new Random();
            List<int> val = new List<int>();
            Control[] c;

            IblGameCnt.Text = "0";
            cntCorrect = 0;
            is後半 = false;
            btnStart.Enabled = false;
            btn戻る.Enabled = false;

            while (true)
            {
                int v = r.Next(0, 10);

                if (val.Contains(v) == false)
                {
                    val.Add(v);
                    Debug.WriteLine(v);
                }

                if (val.Count == 10)
                {
                    break;
                }
            }

            int index = 0;
            Button btn = null;
            for (int y = 0; y < yLen; y++)
            {
                for (int x = 0; x < xLen; x++)
                {

                    c = this.Controls.Find("btn" + y.ToString() + x.ToString(), true);
                    if (c.Length <= 0)
                    {
                        Debug.WriteLine(String.Format("指定されたコントロール({0})は、存在しません。"), "btn" + y.ToString() + x.ToString());
                    }

                    btn = (Button)c[0];
                    btn.Text = str[val[index] % 5];
                    btn.ForeColor = cBack;
                    btn.BackColor = cBack;

                    index++;

                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //表向きになっているボタンをクリックした場合は、何もしない
            if (btn.ForeColor != cBack)
            {
                return;
            }

            btn.ForeColor = cOpen;


            //前半の場合
            if (is後半 == false)
            {
                oBtn = btn;
                is後半 = true;
                return;
            }

            IblGameCnt.Text = (int.Parse(IblGameCnt.Text) + 1).ToString();

            if (oBtn.Text == btn.Text)
            {
                oBtn.ForeColor = cCorrect;
                btn.ForeColor = cCorrect;
                cntCorrect++;
            }
            else
            {
                Application.DoEvents();

                Thread.Sleep(1000);

                oBtn.ForeColor = cBack;
                btn.ForeColor = cBack;
            }

            oBtn = null;
            is後半 = !is後半;

            if (cntCorrect == str.Length)
            {
                btnStart.Enabled = true;
                btn戻る.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            init();
            btnStart.Enabled = false;
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
