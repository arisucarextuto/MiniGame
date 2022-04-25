using MiniGame.Cls;
using MiniGame.Screen;
using System;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frm設定 : Form
    {
        public Frm設定()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == btn設定.Text)
            {
                Frm設定1 frm = new Frm設定1();
                ClsForm.Instance.formShow(frm);
            }
            else if (btn.Text == btn実行.Text)
            {
                Frmプロジェクト読込み frm = new Frmプロジェクト読込み();
                ClsForm.Instance.formShow(frm);
            }
            else if (btn.Text == btn閉じる.Text)
            {

            }
            this.Close();
        }

        private void Frm設定_Load(object sender, EventArgs e)
        {
            btn設定.Focus();
        }
    }
}
