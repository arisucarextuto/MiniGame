using MiniGame.Cls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frmログイン : Form
    {
        public Frmログイン()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool ret = false;

            //入力チェック
            ret = this.Check();
            if (ret == false)
            {
                return;
            }

            //認証
            ret = this.Authenticate();
            if (ret)
            {
                //MessageBox.Show("ログイン成功!");
                Frmメニュー frm = new Frmメニュー();
                ClsForm.Instance.formShow(frm);
                this.Close();
            }
            else
            {
                MessageBox.Show("ユーザーまたはパスワードが間違っています。");
            }
        }

        private bool Check()
        {
            //必須チェック
            if (txtUser.Text == "")
            {
                MessageBox.Show("ユーザー名:入力して下さい。");
                return false;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("パスワード:入力して下さい。");
                return false;
            }

            //文字数チェック
            if (txtUser.Text.Length > 10)
            {
                MessageBox.Show("ユーザー名:入力値に誤りがあります。");
                return false;
            }
            if (txtPass.Text.Length > 5)
            {
                MessageBox.Show("パスワード:入力値に誤りがあります。");
                return false;
            }

            //禁則文字チェック

            return true;
        }

        private bool Authenticate()
        {
            SqlConnection con = new SqlConnection();

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

                cmd.CommandText = "SELECT パスワード FROM M_USER WHERE ユーザー名 = @ユーザー";
                cmd.Parameters.Add("@ユーザー", System.Data.SqlDbType.NVarChar, 10);
                cmd.Parameters["@ユーザー"].Value = txtUser.Text;

                da.SelectCommand = cmd;
                da.Fill(dt);

                //検索結果が1件でない場合
                if (dt.Rows.Count != 1)
                {
                    return false;
                }

                //パスワードが一致しない場合
                if (dt.Rows[0]["パスワード"].ToString() != txtPass.Text)
                {
                    return false;
                }

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("接続エラー");
                return false;
            }
            finally
            {
                con.Close();    //接続解除
                con.Dispose();  //リリース開放
            }

        }
    }
}
