using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MiniGame.Const;

namespace MiniGame
{
    public class Masu
    {
        public MasuType MType { get; set; }

        /// <summary>
        /// ヒントの数字
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// マスのOpen状態(true:Open状態)
        /// </summary>
        public bool IsOpen { get; set; }

        public Mark Memo { get; set; }

        public Masu()
        {
            MType = MasuType.Nomarl;
            IsOpen = false;
            Memo = Mark.Empty;
            Number = 0;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <returns></returns>
        public bool IsMine()
        {
            switch (this.MType)
            {
                case MasuType.Mine:

                    return true;

                default:

                    return false;
            }
        }

        public string getText()
        {
            switch (this.MType)
            {
                case MasuType.Mine:

                    return "●";

                case MasuType.Number:

                    return this.Number.ToString();

                default:

                    return "";
            }
        }

        public string getMemo()
        {
            switch (this.Memo)
            {
                case Mark.Flag:

                    return MARK_FLAG;

                case Mark.Hatena:

                    return MARK_HATENA;

                default:

                    return "";


            }
        }

        public Color getColor()
        {
            if (this.MType != MasuType.Number)
            {
                return Color.Black;
            }

            switch (this.Number)
            {
                case 1:

                    return Color.Black;

                case 2:

                    return Color.Blue;

                case 3:

                    return Color.Red;

                case 4:

                    return Color.Green;

                case 5:

                    return Color.Pink;

                case 6:

                    return Color.White;

                case 7:

                    return Color.White;

                case 8:

                    return Color.White;

                default:

                    return Color.Black;
            }
        }
    }
}
