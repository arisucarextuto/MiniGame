using MiniGame.Cls;
using System;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frmメニュー : Form
    {
        public Frmメニュー()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name == btn神経衰弱.Name)
            {
                Frm神経衰弱 frm = new Frm神経衰弱();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btnじゃんけん.Name)
            {
                Frmじゃんけん frm = new Frmじゃんけん();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btnスロット.Name)
            {
                Frmスロット frm = new Frmスロット();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btnマインスイーパー.Name)
            {
                Frmマインスイーパー frm = new Frmマインスイーパー();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btnもぐらたたき.Name)
            {
                Frmもぐらたたき frm = new Frmもぐらたたき();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btnパズル.Name)
            {
                Frm画像読込み frm = new Frm画像読込み();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btnカレンダー.Name)
            {
                Frmカレンダー frm = new Frmカレンダー();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btnカレンダー管理.Name)
            {
                Frmカレンダー管理 frm = new Frmカレンダー管理();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btn在庫検索.Name)
            {
                Frm在庫検索 frm = new Frm在庫検索();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btn在庫更新.Name)
            {
                Frm在庫更新 frm = new Frm在庫更新();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btnタイマー.Name)
            {
                Frmタイマー frm = new Frmタイマー();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btn電卓.Name)
            {
                Frm電卓 frm = new Frm電卓();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btn時計.Name)
            {
                Frm時計 frm = new Frm時計();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btnスライドショー.Name)
            {
                Frm設定 frm = new Frm設定();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btn戻る.Name)
            {
                Frmログイン frm = new Frmログイン();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else if (btn.Name == btn終了.Name)
            {
                this.Close();
            }
        }
    }
}
