using MiniGame.Cls;
using System;
using System.Windows.Forms;

namespace MiniGame.Screen
{
    public partial class Frmプロジェクト読込み : Form
    {
        private string fileName = "";
        public Frmプロジェクト読込み()
        {
            InitializeComponent();
        }

        private void Frmプロジェクト読込み_Load(object sender, EventArgs e)
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
                frm.proFilePath = fileName;
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
        }
    }
}
