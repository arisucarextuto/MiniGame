using MiniGame.Cls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frm在庫更新 : Form
    {
        private string fileName = "";

        public Frm在庫更新()
        {
            InitializeComponent();
        }

        private void Frm在庫更新_Load(object sender, EventArgs e)
        {
            // ドラッグドロップを受け付ける
            lbFilePath.AllowDrop = true;
        }

        private void btnCsvImport_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;
            string line = "";

            SqlConnection con = new SqlConnection();
            SqlTransaction tran = null;
            SqlCommand cmd = con.CreateCommand();
            int cnt = 0;    //処理件数

            try
            {
                //接続文字列にSqlConnectionStringBuilderを使用するケース
                SqlConnectionStringBuilder bilder = new SqlConnectionStringBuilder();

                //SQLServer認証
                bilder.DataSource = "(local)";
                bilder.InitialCatalog = "TEST_DB";
                bilder.UserID = "user1";
                bilder.Password = "12345";

                Console.WriteLine(bilder.ConnectionString);
                con.ConnectionString = bilder.ConnectionString;

                con.Open(); //DB接続
                Console.WriteLine("接続完了");

                //DB操作はこれ以降に記載する
                //トランザクション開始
                tran = con.BeginTransaction();

                cmd = con.CreateCommand();
                cmd.Transaction = tran; //トランザクション設定

                //DELETE
                cmd.CommandText = "DELETE FROM M_商品";   //全権削除
                cnt = cmd.ExecuteNonQuery();  //SQL実行
                Console.WriteLine(cnt + "件削除しました。");

                cnt = 0;
                sr = new StreamReader(fileName, Encoding.GetEncoding("UTF-8"));
                while (sr.EndOfStream == false)
                {
                    line = sr.ReadLine();   //1行分読込む

                    String[] col = line.Split(',');

                    cmd.CommandText = "INSERT INTO M_商品 VALUES(@コード, @商品名, @価格)";

                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("@コード", SqlDbType.NVarChar, 3);
                    cmd.Parameters["@コード"].Value = col[0];

                    cmd.Parameters.Add("@商品名", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@商品名"].Value = col[1];

                    cmd.Parameters.Add("@価格", SqlDbType.Int);
                    cmd.Parameters["@価格"].Value = int.Parse(col[2]);

                    cnt = cnt + cmd.ExecuteNonQuery();  //SQL実行

                }

                Console.WriteLine(cnt + "件処理しました。");
                MessageBox.Show("登録完了!");
                tran.Commit();  //コミット
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                Console.WriteLine("接続エラー");
            }
            finally
            {
                //DB関連
                if (tran != null)
                {
                    tran.Dispose();
                }
                con.Close();    //接続解除
                con.Dispose();  //リリース開放

                //ファイル関連
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        private void btn戻る_Click(object sender, EventArgs e)
        {
            Frmメニュー frm = new Frmメニュー();
            ClsForm.Instance.formShow(frm);
            this.Close();
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
    }
}
