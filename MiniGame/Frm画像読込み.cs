using MiniGame.Cls;
using System;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frm画像読込み : Form
    {
        private string fileName = "";

        public Frm画像読込み()
        {
            InitializeComponent();
        }

        private void Frm画像読込み_Load(object sender, EventArgs e)
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

        private void btn次へ_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                MessageBox.Show("画像ファイルをドラックしてください。");
            }
            else if (cboN.Text == "")
            {
                MessageBox.Show("難易度を選択してください。");
            }
            else
            {
                Frmパズル frm = new Frmパズル(fileName, int.Parse(cboN.Text));
                frm.FileName = fileName;
                frm.N = int.Parse(cboN.Text);
                ClsForm.Instance.Ac.MainForm = frm;
                frm.Show();
                this.Close();
            }
            
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
