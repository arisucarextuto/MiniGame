using System;
using System.Data;

namespace MiniGame.Cls
{
    public class ClsSetting
    {
        public enum e画像切替
        {
            手動,
            自動,
            None
        }

        public enum DgvImageCOL
        {
            No,
            選択,
            画像名称,
            画像ファイルパス,
            画像,
            Max
        }

        public enum DgvImageListCOL
        {
            No,
            選択,
            画像名称,
            画像ファイルパス,
            画像,
            Max
        }

        public e画像切替 Val画像切替 { get; set; }
        public double Val画像表示間隔 { get; set; }
        public DataTable dtImageList { get; set; }

        public string フォルダパス { get; set; }

        public ClsSetting()
        {
            InitDtImageList();
            Val画像切替 = e画像切替.None;
            Val画像表示間隔 = 0;
            フォルダパス = "";
        }

        public void InitDtImageList()
        {
            dtImageList = new DataTable();

            dtImageList.Columns.Add(DgvImageListCOL.No.ToString(), typeof(string));
            dtImageList.Columns.Add(DgvImageListCOL.画像名称.ToString(), typeof(string));
            dtImageList.Columns.Add(DgvImageListCOL.画像ファイルパス.ToString(), typeof(string));

            dtImageList.TableName = "ImageList";

        }

        public void ToStringValue()
        {

            Console.WriteLine("Val画像切替 = " + Val画像切替.ToString());
            Console.WriteLine("Val画像表示間隔 = " + Val画像表示間隔.ToString());

            Console.WriteLine(DgvImageListCOL.No.ToString() + ", " + DgvImageListCOL.画像名称.ToString() + ", " + DgvImageListCOL.画像ファイルパス.ToString());
            foreach (DataRow row in dtImageList.Rows)
            {
                Console.WriteLine("    " + row[DgvImageListCOL.No.ToString()] + ", " + row[DgvImageListCOL.画像名称.ToString()] + ", " + row[DgvImageListCOL.画像ファイルパス.ToString()]);
            }
        }
    }
}
