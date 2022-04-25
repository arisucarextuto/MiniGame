using MiniGame.Cls;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace MiniGame.Screen
{
    public partial class Frmプロジェクト読込み : Form
    {
        public Frmプロジェクト読込み()
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
                this.Close();
            }
            else if (btn.Text == btn次へ.Text)
            {
                Frmスライドショー frm = new Frmスライドショー();
                frm.proFilePath = txtフォルダパス.Text;
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
        }

        private void btn参照_Click(object sender, EventArgs e)
        {
            ofdProject.InitialDirectory = Assembly.GetExecutingAssembly().Location;

            if (ofdProject.ShowDialog() == DialogResult.OK)
            {
                txtフォルダパス.Text = ofdProject.FileName;
            }
        }
    }
}
