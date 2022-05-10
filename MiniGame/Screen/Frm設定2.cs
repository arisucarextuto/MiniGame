using MiniGame.Cls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using static MiniGame.Cls.ClsSetting;

namespace MiniGame.Screen
{
    public partial class Frm設定2 : Form
    {
        public ClsSetting Args { get; set; }

        const int dgvImageRowHeight = 60;
        const int dgvImageListRowHeight = 60;
        const int imgWidth = 50;
        const int imgHeight = 50;

        public bool savecheck = false;
        public Frm設定2()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == btn戻る.Text)
            {
                if (savecheck)
                {
                    savecheck = false;
                }
                else
                {
                    SaveData();
                }

                Frm設定1 frm = new Frm設定1();
                frm.Args = Args;
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
        }

        private void Frm設定2_Load(object sender, EventArgs e)
        {

            //列の定義
            InitDgvImage();
            InitDgvImageList();

            txtフォルダパス.Text = Args.フォルダパス;

            //DataGridviewにデータリセット
            SetDataImageList();
        }

        private void btn参照_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //上部の表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要である
            fbd.SelectedPath = @"C:\";
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = true;

            txtフォルダパス.TextChanged -= txtフォルダパス_TextChanged;

            //ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                SearchFolder(fbd.SelectedPath);
            }
            txtフォルダパス.TextChanged += txtフォルダパス_TextChanged;

        }

        private void txtフォルダパス_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(txtフォルダパス.Text))
            {
                SearchFolder(txtフォルダパス.Text);
            }
        }

        private void SearchFolder(string folderpath)
        {
            txtフォルダパス.Text = folderpath;

            ClsSlideshow slid = new ClsSlideshow();

            string path = folderpath;
            string[] patterns = { ".jpg", ".bmp", ".png" };
            IEnumerable<string> files = Directory.EnumerateFiles(path, "*");
            var ret = files.Where(File => patterns.Any(pateern => File.ToLower().EndsWith(pateern)));

            //列の定義
            InitDgvImage();
            InitDgvImageList();

            int rowNo = 0;

            foreach (string str in ret)
            {
                dgvImage.Rows.Add();

                dgvImage[(int)DgvImageCOL.No, rowNo].Value = (rowNo + 1);
                dgvImage[(int)DgvImageCOL.選択, rowNo].Value = false;
                dgvImage[(int)DgvImageCOL.画像名称, rowNo].Value = Path.GetFileName(str);
                dgvImage[(int)DgvImageCOL.画像ファイルパス, rowNo].Value = str;
                dgvImage[(int)DgvImageCOL.画像, rowNo].Value = slid.ScalingImage(new Bitmap(str), imgWidth, imgHeight);

                rowNo++;
            }
        }

        /// <summary>
        /// dvgImageの定義
        /// </summary>
        public void InitDgvImage()
        {
            dgvImage.RowTemplate.Height = dgvImageRowHeight;
            dgvImage.AllowUserToAddRows = false;
            dgvImage.RowHeadersVisible = false;
            dgvImage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImage.MultiSelect = false;

            //列の定義
            DataGridViewTextBoxColumn txtColumn;
            DataGridViewCheckBoxColumn chkColumn;
            DataGridViewImageColumn imgColumn;

            //No(テキスト)
            txtColumn = new DataGridViewTextBoxColumn();
            txtColumn.Name = "col" + DgvImageCOL.No.ToString();
            txtColumn.HeaderText = "No";
            txtColumn.Width = 30;
            dgvImage.Columns.Add(txtColumn);

            //選択(チェックボックス)
            chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.Name = "col" + DgvImageCOL.選択.ToString();
            chkColumn.HeaderText = DgvImageCOL.選択.ToString();
            chkColumn.Width = 30;
            dgvImage.Columns.Add(chkColumn);

            //画像名称(テキスト)
            txtColumn = new DataGridViewTextBoxColumn();
            txtColumn.Name = "col" + DgvImageCOL.画像名称.ToString();
            txtColumn.HeaderText = DgvImageCOL.画像名称.ToString();
            txtColumn.Width = 150;
            dgvImage.Columns.Add(txtColumn);

            //画像ファイルパス(テキスト)
            txtColumn = new DataGridViewTextBoxColumn();
            txtColumn.Name = "col" + DgvImageCOL.画像ファイルパス.ToString();
            txtColumn.HeaderText = DgvImageCOL.画像ファイルパス.ToString();
            txtColumn.Width = 70;
            txtColumn.Visible = false;
            dgvImage.Columns.Add(txtColumn);

            //画像(image)
            imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "col" + DgvImageCOL.画像.ToString();
            imgColumn.HeaderText = DgvImageCOL.画像.ToString();
            imgColumn.Width = 80;
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            dgvImage.Columns.Add(imgColumn);
        }

        /// <summary>
        /// dgvImageListの定義
        /// </summary>
        public void InitDgvImageList()
        {
            dgvImageList.RowTemplate.Height = dgvImageListRowHeight;
            dgvImageList.AllowUserToAddRows = false;
            dgvImageList.RowHeadersVisible = false;

            //列の定義
            DataGridViewTextBoxColumn txtColumn;
            DataGridViewCheckBoxColumn chkColumn;
            DataGridViewImageColumn imgColumn;

            //No(テキスト)
            txtColumn = new DataGridViewTextBoxColumn();
            txtColumn.Name = "col" + DgvImageListCOL.No.ToString();
            txtColumn.HeaderText = "No";
            txtColumn.Width = 30;
            dgvImageList.Columns.Add(txtColumn);

            //選択(チェックボックス)
            chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.Name = "col" + DgvImageListCOL.選択.ToString();
            chkColumn.HeaderText = DgvImageListCOL.選択.ToString();
            chkColumn.Width = 30;
            dgvImageList.Columns.Add(chkColumn);

            //画像名称(テキスト)
            txtColumn = new DataGridViewTextBoxColumn();
            txtColumn.Name = "col" + DgvImageListCOL.画像名称.ToString();
            txtColumn.HeaderText = DgvImageListCOL.画像名称.ToString();
            txtColumn.Width = 150;
            dgvImageList.Columns.Add(txtColumn);

            //画像ファイルパス(テキスト)
            txtColumn = new DataGridViewTextBoxColumn();
            txtColumn.Name = "col" + DgvImageListCOL.画像ファイルパス.ToString();
            txtColumn.HeaderText = DgvImageListCOL.画像ファイルパス.ToString();
            txtColumn.Width = 70;
            txtColumn.Visible = false;
            dgvImageList.Columns.Add(txtColumn);

            //画像(image)
            imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "col" + DgvImageListCOL.画像.ToString();
            imgColumn.HeaderText = DgvImageListCOL.画像.ToString();
            imgColumn.Width = 80;
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            dgvImageList.Columns.Add(imgColumn);
        }

        private void btn追加_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (DataGridViewRow row in dgvImage.Rows)
            {
                if ((bool)row.Cells[(int)DgvImageCOL.選択].Value == true)
                {
                    Debug.WriteLine(row.Cells[(int)DgvImageCOL.No].Value);

                    dgvImageList.Rows.Add();

                    index = dgvImageList.Rows.Count - 1;
                    dgvImageList[(int)DgvImageCOL.No, index].Value = (index + 1);
                    dgvImageList[(int)DgvImageCOL.選択, index].Value = false;
                    dgvImageList[(int)DgvImageCOL.画像名称, index].Value = row.Cells[(int)DgvImageCOL.画像名称].Value;
                    dgvImageList[(int)DgvImageCOL.画像ファイルパス, index].Value = row.Cells[(int)DgvImageCOL.画像ファイルパス].Value;
                    dgvImageList[(int)DgvImageCOL.画像, index].Value = row.Cells[(int)DgvImageCOL.画像].Value;
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            List<int> rowNoList = GetdgvImageListRowNo();

            //チェックが１つであること
            if (rowNoList.Count != 1)
            {
                MessageBox.Show("行を移動する場合はチェックを１つにして下さい。");
                return;
            }

            int curNo = rowNoList[0];   //現在No

            //これ以上、上に移動できない
            if (curNo == 1)
            {
                MessageBox.Show("選択された行は、先頭行です。");
                return;
            }
            int preNo = curNo - 1;  //ひとつ上のNo

            int preIndex = preNo - 1;
            int curIndex = curNo - 1;

            //Tempデータ
            //1.ひとつ上のデータを退避
            string tmp画像名称 = dgvImageList[(int)DgvImageCOL.画像名称, preIndex].Value.ToString();
            string tmp画像ファイルパス = dgvImageList[(int)DgvImageCOL.画像ファイルパス, preIndex].Value.ToString();
            Image tmp画像 = (Image)dgvImageList[(int)DgvImageCOL.画像, preIndex].Value;

            //2.カレント行のデータを、ひとつ上の行に設定する。
            dgvImageList[(int)DgvImageCOL.No, preIndex].Value = preNo;
            dgvImageList[(int)DgvImageCOL.選択, preIndex].Value = true;
            dgvImageList[(int)DgvImageCOL.画像名称, preIndex].Value = dgvImageList[(int)DgvImageCOL.画像名称, curIndex].Value;
            dgvImageList[(int)DgvImageCOL.画像ファイルパス, preIndex].Value = dgvImageList[(int)DgvImageCOL.画像ファイルパス, curIndex].Value;
            dgvImageList[(int)DgvImageCOL.画像, preIndex].Value = dgvImageList[(int)DgvImageCOL.画像, curIndex].Value;

            //3.退避データを、カレント行に設定する。
            dgvImageList[(int)DgvImageCOL.No, curIndex].Value = curNo;
            dgvImageList[(int)DgvImageCOL.選択, curIndex].Value = false;
            dgvImageList[(int)DgvImageCOL.画像名称, curIndex].Value = tmp画像名称;
            dgvImageList[(int)DgvImageCOL.画像ファイルパス, curIndex].Value = tmp画像ファイルパス;
            dgvImageList[(int)DgvImageCOL.画像, curIndex].Value = tmp画像;

            dgvImageList.Rows[preIndex].Selected = true;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            List<int> rowNoList = GetdgvImageListRowNo();

            //チェックが１つであること
            if (rowNoList.Count != 1)
            {
                MessageBox.Show("行を移動する場合はチェックを１つにして下さい。");
                return;
            }

            int curNo = rowNoList[0];   //現在No

            //これ以上、下に移動できない
            if (curNo == dgvImageList.Rows.Count)
            {
                MessageBox.Show("選択された行は、末尾行です。");
                return;
            }
            int nextNo = curNo + 1;  //ひとつ上のNo

            int curIndex = curNo - 1;
            int nextIndex = nextNo - 1;

            //Tempデータ
            //1.ひとつ上のデータを退避
            string tmp画像名称 = dgvImageList[(int)DgvImageCOL.画像名称, nextIndex].Value.ToString();
            string tmp画像ファイルパス = dgvImageList[(int)DgvImageCOL.画像ファイルパス, nextIndex].Value.ToString();
            Image tmp画像 = (Image)dgvImageList[(int)DgvImageCOL.画像, nextIndex].Value;

            //2.カレント行のデータを、ひとつ下の行に設定する。
            dgvImageList[(int)DgvImageCOL.No, nextIndex].Value = nextNo;
            dgvImageList[(int)DgvImageCOL.選択, nextIndex].Value = true;
            dgvImageList[(int)DgvImageCOL.画像名称, nextIndex].Value = dgvImageList[(int)DgvImageCOL.画像名称, curIndex].Value;
            dgvImageList[(int)DgvImageCOL.画像ファイルパス, nextIndex].Value = dgvImageList[(int)DgvImageCOL.画像ファイルパス, curIndex].Value;
            dgvImageList[(int)DgvImageCOL.画像, nextIndex].Value = dgvImageList[(int)DgvImageCOL.画像, curIndex].Value;

            //3.退避データを、カレント行に設定する。
            dgvImageList[(int)DgvImageCOL.No, curIndex].Value = curNo;
            dgvImageList[(int)DgvImageCOL.選択, curIndex].Value = false;
            dgvImageList[(int)DgvImageCOL.画像名称, curIndex].Value = tmp画像名称;
            dgvImageList[(int)DgvImageCOL.画像ファイルパス, curIndex].Value = tmp画像ファイルパス;
            dgvImageList[(int)DgvImageCOL.画像, curIndex].Value = tmp画像;

            dgvImageList.Rows[nextIndex].Selected = true;
        }

        private List<int> GetdgvImageListRowNo()
        {
            List<int> rowNoList = new List<int>();

            foreach (DataGridViewRow row in dgvImageList.Rows)
            {
                if ((bool)row.Cells[(int)DgvImageCOL.選択].Value == true)
                {
                    rowNoList.Add((int)row.Cells[(int)DgvImageCOL.No].Value);
                }
            }
            return rowNoList;
        }

        private void btn削除_Click(object sender, EventArgs e)
        {
            List<int> rowNoList = GetdgvImageListRowNo();

            //チェックが１つであること
            if (rowNoList.Count != 1)
            {
                MessageBox.Show("行を移動する場合はチェックを１つにして下さい。");
                return;
            }

            //後ろから消していく
            for (int i = dgvImageList.Rows.Count - 1; i >= 0; i--)
            {
                if ((bool)dgvImageList.Rows[i].Cells[(int)DgvImageCOL.選択].Value == true)
                {
                    //削除箇所の更新
                    dgvImageList.Rows[i + 1].Cells[(int)DgvImageCOL.No].Value = dgvImageList.Rows[i].Cells[(int)DgvImageCOL.No].Value;

                    //修正番号
                    Debug.WriteLine("削除あり : " + dgvImageList.Rows[i].Cells[(int)DgvImageCOL.No].Value + " 番");
                    dgvImageList.Rows.RemoveAt(i);
                }
                else
                {
                    Debug.WriteLine("削除なし : " + dgvImageList.Rows[i].Cells[(int)DgvImageCOL.No].Value + " 番");
                }
            }
            Debug.WriteLine("個数 : " + dgvImageList.Rows.Count + " 個");
        }

        private void btn保存_Click(object sender, EventArgs e)
        {
            string fileName = "";
            StreamWriter sw = null;
            savecheck = true;

            if (check() == false)
            {
                return;
            }

            saveFileDialog.FileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                SaveData();

                fileName = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), saveFileDialog.FileName);

                XmlSerializer serializer = new XmlSerializer(typeof(ClsSetting));
                sw = new StreamWriter(fileName, false, new UTF8Encoding(false));

                serializer.Serialize(sw, Args);

                MessageBox.Show("保存しました。");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public bool check()
        {
            if (dgvImageList.Rows.Count == 0)
            {
                MessageBox.Show("画像が1件も追加されていません。");
                return false;
            }

            return true;
        }


        public void SaveData()
        {

            Args.フォルダパス = txtフォルダパス.Text;

            for (int i = 0; i < dgvImageList.Rows.Count; i++)
            {
                DataRow row = Args.dtImageList.NewRow();

                row[DgvImageListCOL.No.ToString()] = dgvImageList[(int)ClsSetting.DgvImageListCOL.No, i].Value;
                row[DgvImageListCOL.画像名称.ToString()] = dgvImageList[(int)ClsSetting.DgvImageListCOL.画像名称, i].Value;
                row[DgvImageListCOL.画像ファイルパス.ToString()] = dgvImageList[(int)ClsSetting.DgvImageListCOL.画像ファイルパス, i].Value;

                Args.dtImageList.Rows.Add(row);
            }
        }


        private void SetDataImageList()
        {
            int index = 0;
            ClsSlideshow slide = new ClsSlideshow();
            foreach (DataRow row in Args.dtImageList.Rows)
            {
                dgvImageList.Rows.Add();

                dgvImageList[(int)DgvImageCOL.No, index].Value = row[(int)ClsSetting.DgvImageCOL.No];
                dgvImageList[(int)DgvImageCOL.選択, index].Value = false;
                dgvImageList[(int)DgvImageCOL.画像名称, index].Value = row[ClsSetting.DgvImageCOL.画像名称.ToString()];
                dgvImageList[(int)DgvImageCOL.画像ファイルパス, index].Value = row[ClsSetting.DgvImageCOL.画像ファイルパス.ToString()];
                dgvImageList[(int)DgvImageCOL.画像, index].Value = slide.ScalingImage(new Bitmap(row[ClsSetting.DgvImageCOL.画像ファイルパス.ToString()].ToString()), imgWidth, imgHeight);

                index++;
            }
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (System.IO.Path.GetExtension(saveFileDialog.FileName) != ".xml") //.xml
            {
                MessageBox.Show("ファイル拡張子は[xml]として下さい。");
                e.Cancel = true;
            }
        }
    }
}
