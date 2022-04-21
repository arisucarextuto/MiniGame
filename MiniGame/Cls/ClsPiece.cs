using System.Drawing;

namespace MiniGame.Cls
{
    class ClsPiece
    {
        public Image img { get; set; }

        public int No;

        public bool isLastPiece { get; set; }

        public ClsPiece()
        {
            img = null;
            isLastPiece = false;
        }
    }
}
