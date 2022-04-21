using MiniGame.Cls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frmカレンダー管理 : Form
    {
        public Frmカレンダー管理()
        {
            InitializeComponent();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int diffVal = 0;

            if (btn == btnPrev)         //前年
            {
                diffVal = -1;
            }
            else if (btn == btnNext)    //次年
            {
                diffVal = 1;
            }

            IblYaer.Text = (int.Parse(IblYaer.Text) + diffVal).ToString();
            InitDgv();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDgv();
        }

        /// <summary>
        /// カレンダーの初期化
        /// </summary>
        private void InitDgv()
        {
            List<DateTime> hList = GetHoliday();
            for (int i = 1; i <= 12; i++)
            {
                setDgvCal(i, hList);
            }
        }

        private List<DateTime> GetHoliday()
        {
            SqlConnection con = new SqlConnection();
            List<DateTime> hList = new List<DateTime>();
            DateTime d;
            DateTime sdate;
            DateTime edate;

            try
            {
                sdate = new DateTime(int.Parse(IblYaer.Text), 1, 1);    //年始
                edate = new DateTime(int.Parse(IblYaer.Text), 12, 31);  //年末

                SqlConnectionStringBuilder bilder = new SqlConnectionStringBuilder();

                //SQLServer認証
                bilder.DataSource = "(local)";
                bilder.InitialCatalog = "TEST_DB";
                bilder.UserID = "user1";
                bilder.Password = "12345";

                con.ConnectionString = bilder.ConnectionString;

                con.Open(); //DB接続
                Console.WriteLine("接続完了");

                //DB操作はこれ以降に記載する
                SqlCommand cmd = con.CreateCommand();

                //➀固定SQLを実行する。
                cmd.CommandText = "SELECT Date FROM M_休日 WHERE Date >= @sDate AND Date <= @eDate";

                //Parameterを使ってSQLを実行する。
                cmd.Parameters.Add("@sDate", SqlDbType.Date);
                cmd.Parameters["@sDate"].Value = sdate;

                cmd.Parameters.Add("@eDate", SqlDbType.Date);
                cmd.Parameters["@eDate"].Value = edate;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())   //Read(により読み込みレコードを１つ先に進める)
                {
                    d = DateTime.Parse(reader["Date"].ToString());

                    hList.Add(d);
                }

                reader.Close();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine("接続エラー");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();    //接続解除
                con.Dispose();  //リリース開放
            }

            return hList;
        }

        /// <summary>
        /// カレンダーの作成
        /// </summary>
        /// <param name="month">月</param>
        private void setDgvCal(int month, List<DateTime> hList)
        {
            //6列7行
            string[,] calender = new string[6, 7];
            DataGridView dgv = null;

            //dgvCal + 01
            Control[] cs = this.Controls.Find("dgvCal" + string.Format("{0:00}", month), true);
            if (cs.Length > 0)
            {
                dgv = (DataGridView)cs[0];
            }
            else
            {
                return;
            }

            //カレンダー作成
            dgv.Rows.Clear();

            DateTime firstDate = new DateTime(int.Parse(IblYaer.Text), month, 1);   //月初(1日)

            int dow = (int)firstDate.DayOfWeek; //日曜日=0 ～ 土曜日=6

            DateTime startDay = firstDate.AddDays(-1 * dow); //左上 (カレンダーの始まり)
            DateTime endDate = firstDate.AddMonths(1).AddDays(-1);  //月末 (月初　+ 1ヶ月 - 1日)


            int addDay = 0; //月初を1ずつ増やしてカウンター
            DateTime wkDay = startDay;
            dgv.RowCount = 0;    //行数を0に初期化
            for (int y = 0; y < calender.GetLength(0); y++)    //カレンダーの最大行分ループ
            {
                dgv.Rows.Add();  //行追加

                for (int x = 0; x < calender.GetLength(1); x++)
                {
                    wkDay = startDay.AddDays(addDay);
                    addDay++;

                    if (wkDay.Month != month)
                    {
                        //現在の月が、指定月と異なる場合は、カレンダーに表示させたくないため
                        //スキップ
                        continue;
                    }

                    //(注意)DateGridViewは、[列, 行]で位置を指定する。
                    dgv[x, y].Value = wkDay.Day;

                    if (hList.Contains(wkDay))
                    {
                        dgv[x, y].Style.BackColor = Color.Red;
                    }

                    if (wkDay.CompareTo(endDate) == 0)
                    {
                        //現在の日にち = 月末日と異なる場合、処理終了
                        // (以降は翌月となるため)
                        break;
                    }
                }

                if (wkDay.CompareTo(endDate) == 0)
                {
                    //現在の日にち = 月末日と異なる場合、処理終了
                    // (以降は翌月となるため)
                    break;
                }
            }

            dgv.ClearSelection();   //選択状態を解除
        }

        /// <summary>
        /// 休日の場合、赤にする。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex;
            int y = e.RowIndex;

            DataGridView dgv = (DataGridView)sender;

            if (dgv[x, y].Value == null)
            {
                return;
            }

            Console.WriteLine(dgv[x, y].Style.BackColor);
            if (dgv[x, y].Style.BackColor == Color.Empty)
            {
                dgv[x, y].Style.BackColor = Color.Red;
            }
            else
            {
                dgv[x, y].Style.BackColor = Color.Empty;
            }
            dgv.ClearSelection();   //選択状態をクリア
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //M_休日マスタ登録
            //カレンダーで赤色になっている日付を登録

            //DELTE - INSERT
            //表示している年(例:2022)
            //  ①2022/1/1 ～ 2022/12/31の休日を全削除
            //  ②画面に設定されている休日を登録

            SqlConnection con = new SqlConnection();
            SqlTransaction tran = null;

            try
            {
                int year = int.Parse(IblYaer.Text);
                DateTime sDate = new DateTime(year, 1, 1);      //年初
                DateTime eDate = new DateTime(year, 12, 31);    //年末

                SqlConnectionStringBuilder bilder = new SqlConnectionStringBuilder();

                //SQLServer認証
                bilder.DataSource = "(local)";
                bilder.InitialCatalog = "TEST_DB";
                bilder.UserID = "user1";
                bilder.Password = "12345";

                con.ConnectionString = bilder.ConnectionString;
                con.Open(); //DB接続
                //DB操作はこれ以降に記載する
                //トランザクション開始
                tran = con.BeginTransaction();

                SqlCommand cmd = con.CreateCommand();

                cmd.Transaction = tran; //トランザクション設定

                //SQL➀Delete
                cmd.CommandText = "DELETE FROM M_休日 " +
                                  "      WHERE DATE >= @sDate" +
                                  "        AND DATE <= @eDate";

                cmd.Parameters.Add("@sDate", SqlDbType.Date);
                cmd.Parameters["@sDate"].Value = sDate;

                cmd.Parameters.Add("@eDate", SqlDbType.Date);
                cmd.Parameters["@eDate"].Value = eDate;

                int cnt = cmd.ExecuteNonQuery();    //SQL実行

                //INSERT
                DataGridView dgv = null;
                DateTime d;

                cnt = 0;
                for (int month = 1; month <= 12; month++)
                {
                    Control[] cs = this.Controls.Find("dgvCal" + string.Format("{0:00}", month), true);
                    if (cs.Length > 0)
                    {
                        dgv = (DataGridView)cs[0];
                    }
                    else
                    {
                        continue;
                    }

                    for (int row = 0; row < dgv.RowCount; row++)
                    {
                        for (int col = 0; col < dgv.ColumnCount; col++)
                        {
                            if (dgv.Rows[row].Cells[col].Value == null)
                            {
                                continue;
                            }

                            if (dgv.Rows[row].Cells[col].Style.BackColor == Color.Empty)
                            {
                                continue;
                            }

                            d = new DateTime(year, month, (int)dgv.Rows[row].Cells[col].Value);

                            cmd.CommandText = "INSERT INTO M_休日 VALUES(@Date)";

                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@Date", SqlDbType.Date);
                            cmd.Parameters["@Date"].Value = d;

                            cnt = cnt + cmd.ExecuteNonQuery();  //SQL実行
                        }
                    }
                }

                Console.WriteLine(cnt + "件処理しました。");

                tran.Commit();

                MessageBox.Show(cnt + "件登録しました。");

            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                Console.WriteLine("接続エラー");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (tran != null)
                {
                    tran.Dispose();
                }
                con.Close();    //接続解除
                con.Dispose();  //リリース開放
            }

            Console.ReadLine(); //実行を停止
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
