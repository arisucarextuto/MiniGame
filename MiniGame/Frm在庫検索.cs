using MiniGame.Cls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frm在庫検索 : Form
    {
        public Frm在庫検索()
        {
            InitializeComponent();
        }

        private void btn検索_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string sql = "";

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
                //DataAdapter
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                SqlCommand cmd = con.CreateCommand();

                sql = "SELECT * FROM M_商品 ";
                sql = sql + "WHERE 1 = 1";  //ダミー条件
                if (txtコード.Text != "")
                {
                    sql = sql + "AND コード = @コード";
                }
                if (txt商品名.Text != "")
                {
                    sql = sql + "AND 商品名 LIKE @商品名";
                }

                cmd.CommandText = sql;

                cmd.Parameters.Clear();

                cmd.Parameters.Add("@コード", System.Data.SqlDbType.NVarChar, 3);
                cmd.Parameters["@コード"].Value = txtコード.Text;

                cmd.Parameters.Add("@商品名", System.Data.SqlDbType.NVarChar, 5);
                cmd.Parameters["@商品名"].Value = "%" + txt商品名.Text + "%";

                da.SelectCommand = cmd;
                da.Fill(dt);

                //データソースクリア
                this.dgv結果.DataSource = null;

                if (dt.Rows.Count > 0)
                {
                    this.dgv結果.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("検索結果0件です。");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("接続エラー");
            }
            finally
            {
                con.Close();    //接続解除
                con.Dispose();  //リリース開放
            }
        }

        private void btn戻る_Click(object sender, EventArgs e)
        {
            Frmメニュー frm = new Frmメニュー();
            ClsForm.Instance.formShow(frm);
            this.Close();
        }
    }
}
