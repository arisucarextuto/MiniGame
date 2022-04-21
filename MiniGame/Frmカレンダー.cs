using MiniGame.Cls;
using System;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frmカレンダー : Form
    {
        const int MAXROW = 6;   //最大行
        const int MAXCOL = 7;   //最大列(日～土の7列)

        public Frmカレンダー()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDataGridView(dtp.Value);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            SetDataGridView(dtp.Value);
        }

        private void SetDataGridView(DateTime dt)
        {
            dgvCal.Rows.Clear();

            DateTime baseDate = dt;
            Console.WriteLine(String.Format("{0} = {1}", "指定日", baseDate.ToShortDateString()));

            DateTime firstDate = new DateTime(baseDate.Year, baseDate.Month, 1);    //月初(1日)
            Console.WriteLine(String.Format("{0} = {1}", "1日", firstDate.ToShortDateString()));

            //➀1日は何曜日? (位置)
            int num = (int)firstDate.DayOfWeek; //日曜日=0 ～ 土曜日=6
            Console.WriteLine(String.Format("{0} = {1}", firstDate.ToShortDateString(), num));

            DateTime starDay = firstDate.AddDays(-1 * num); //左上 (カレンダーの始まり)
            DateTime endDate = firstDate.AddMonths(1).AddDays(-1);  //月末 (月初　+ 1ヶ月 - 1日)
            Console.WriteLine(String.Format("{0} = {1}", "左上", starDay.ToShortDateString()));
            Console.WriteLine(String.Format("{0} = {1}", "月末", endDate.ToShortDateString()));

            int addDay = 0; //月初を1ずつ増やしてカウンター
            DateTime wkDay = starDay;
            dgvCal.RowCount = 0;    //行数を0に初期化
            for (int y = 0; y < MAXROW; y++)    //カレンダーの最大行分ループ
            {
                dgvCal.Rows.Add();  //行追加

                for (int x = 0; x < MAXCOL; x++)
                {
                    wkDay = starDay.AddDays(addDay);
                    addDay++;

                    if (wkDay.Month != baseDate.Month)
                    {
                        //現在の月が、指定月と異なる場合は、カレンダーに表示させたくないため
                        //スキップ
                        continue;
                    }

                    //(注意)DateGridViewは、[列, 行]で位置を指定する。
                    dgvCal[x, y].Value = wkDay.Day;

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
