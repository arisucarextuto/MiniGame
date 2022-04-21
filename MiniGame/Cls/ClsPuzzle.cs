using System;

namespace MiniGame.Cls
{
    class ClsPuzzle
    {
        //上下左右
        public enum UDLR
        {
            up,
            down,
            left,
            right,
            max
        }


        public void shuffle(int suffleCnt, ClsPiece[,] borad)
        {
            Random r = new Random();
            int rand = 0;

            int spaceCY = 0; //スペースの開始位置y
            int spaceCX = 0; //スペースの開始位置x
            int checkY = 0;
            int checkX = 0;
            ClsPiece temp = new ClsPiece();

            for (int y = 0; y < borad.GetLength(0); y++)
            {
                for (int x = 0; x < borad.GetLength(1); x++)
                {
                    if (borad[y, x].isLastPiece)
                    {
                        spaceCY = y;
                        spaceCX = x;
                        checkY = y;
                        checkX = x;
                    }
                }
            }

            while (suffleCnt > 0)
            {
                rand = r.Next(4);

                if (rand == (int)UDLR.up)
                {
                    if (checkY != 0)
                    {
                        checkY--;
                    }
                }
                else if (rand == (int)UDLR.down)
                {
                    if (checkY != borad.GetLength(0) - 1)
                    {
                        checkY++;
                    }
                }
                else if (rand == (int)UDLR.left)
                {
                    if (checkX != 0)
                    {
                        checkX--;
                    }
                }
                else if (rand == (int)UDLR.right)
                {
                    if (checkX != borad.GetLength(1) - 1)
                    {
                        checkX++;
                    }
                }

                if (spaceCY == checkY && spaceCX == checkX)
                {
                    continue;
                }

                //値の入替え
                temp = borad[spaceCY, spaceCX]; //スペース
                borad[spaceCY, spaceCX] = borad[checkY, checkX]; //移動先にある画像をスペースの位置に持ってくる
                borad[checkY, checkX] = temp;
                spaceCY = checkY;
                spaceCX = checkX;

                suffleCnt--;
            }
        }

        /// <summary>
        /// ピースが移動させる
        /// マウスクリックした位置が、スペースの場合は移動できない。
        ///                           ピースの場合で上下左右にスペースが存在しない場合は移動できない。
        /// </summary>
        /// <returns></returns>
        public bool movePiece(int curX, int curY, ClsPiece[,] borad)
        {
            int checkY = 0;
            int checkX = 0;

            if (borad[curY, curX].isLastPiece)
            {
                return false; //スペースは移動できない
            }

            for (int i = 0; i < (int)UDLR.max; i++)
            {
                switch (i)
                {
                    case (int)UDLR.up:

                        if (curY != 0)
                        {
                            checkY = curY - 1;
                            checkX = curX;
                        }

                        break;
                    case (int)UDLR.down:

                        if (curY != borad.GetLength(0) - 1)
                        {
                            checkY = curY + 1;
                            checkX = curX;
                        }

                        break;
                    case (int)UDLR.left:

                        if (curX != 0)
                        {
                            checkY = curY;
                            checkX = curX - 1;
                        }

                        break;
                    case (int)UDLR.right:

                        if (curX != borad.GetLength(1) - 1)
                        {
                            checkY = curY;
                            checkX = curX + 1;
                        }

                        break;
                }

                ClsPiece temp = new ClsPiece();
                if (borad[checkY, checkX].isLastPiece)
                {
                    //マウスでクリックしたピースを入れ替える
                    temp = borad[curY, curX];
                    borad[curY, curX] = borad[checkY, checkX];
                    borad[checkY, checkX] = temp;
                    curY = checkY;
                    curX = checkX;

                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 終了判定
        /// </summary>
        public bool isEnd(ClsPiece[,] borad)
        {
            int num = 0;
            for (int y = 0; y < borad.GetLength(0); y++)
            {
                for (int x = 0; x < borad.GetLength(1); x++)
                {
                    if (num == borad.GetLength(0) * borad.GetLength(1))
                    {
                        break;
                    }

                    if (borad[y, x].No != num)
                    {
                        return false;
                    }
                    num++;
                }
            }

            return true;
        }
    }
}
