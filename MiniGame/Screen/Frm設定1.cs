using MiniGame.Cls;
using System;
using System.Windows.Forms;

namespace MiniGame.Screen
{
    public partial class Frm設定1 : Form
    {
        public ClsSetting Args { get; set; }

        public Frm設定1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == btn戻る.Text)
            {
                Frm設定 frm = new Frm設定();
                ClsForm.Instance.formShow(frm);
            }
            else if (btn.Text == btn次へ.Text)
            {
                string errMsg = "";
                if (CheckData(out errMsg) == false)
                {
                    MessageBox.Show(errMsg);
                    return;
                }

                Frm設定2 frm = new Frm設定2();
                frm.Args = GetArgsData();
                ClsForm.Instance.formShow(frm);
            }
            this.Close();
        }

        private void Frm設定1_Load(object sender, EventArgs e)
        {
            LoadMain();
        }

        private void LoadMain()
        {
            InitControl();
            Setdata();
        }

        private void InitControl()
        {
            rdo手動.Checked = true;
        }

        private void rdo手動_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo手動.Checked)
            {
                txt画像表示間隔.Enabled = false;
            }
            else
            {
                txt画像表示間隔.Enabled = true;
            }
        }

        private bool CheckData(out string msg)
        {
            if (rdo自動.Checked)
            {
                //未入力チェック
                if (txt画像表示間隔.Text == "")
                {
                    msg = "画像表示間隔を入力して下さい。";
                    return false;
                }

                //数値チェック
                double val = 0;
                if (double.TryParse(txt画像表示間隔.Text, out val) == false)
                {
                    msg = "画像表示間隔には数値を入力して下さい。";
                    return false;
                }

                //0以下チェック
                if (val <= 0)
                {
                    msg = "画像表示間隔は0より大きい値を入力して下さい。";
                    return false;
                }
            }

            msg = "";
            return true;
        }

        private ClsSetting GetArgsData()
        {
            ClsSetting data = null;

            if (Args == null)
            {
                data = new ClsSetting();
            }
            else
            {
                data = Args;
            }

            if (rdo手動.Checked)
            {
                data.Val画像切替 = ClsSetting.e画像切替.手動;
                data.Val画像表示間隔 = 0;
            }
            else
            {
                data.Val画像切替 = ClsSetting.e画像切替.自動;
                data.Val画像表示間隔 = double.Parse(txt画像表示間隔.Text);
            }

            return data;
        }

        private void Setdata()
        {
            if (Args != null)
            {
                if (Args.Val画像切替 == ClsSetting.e画像切替.手動)
                {
                    rdo手動.Checked = true;
                    txt画像表示間隔.Text = "0";
                }
                else
                {
                    rdo自動.Checked = true;
                    txt画像表示間隔.Text = Args.Val画像表示間隔.ToString();
                }
            }
        }
    }
}
