using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame
{
    public class Const
    {

        public enum EndCode
        {
            Continue,
            GameOver,
            Success
        }

        public enum MasuType
        {
            Nomarl,
            Mine,
            Number
        }

        /*public enum MemoType
        {
            Hatena,
            Flag,
            None
        }*/

        public enum Mark
        {
            Empty,
            Flag,
            Hatena
        }

        public const string MINE = "●";
        public const string MARK_FLAG = "▲";
        public const string MARK_HATENA = "?";
    }
}
