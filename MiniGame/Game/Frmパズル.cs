using MiniGame.Cls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frmパズル : Form
    {
        public string FileName { get; set; }
        public int N { get; set; }

        const int ImageH = 420;
        const int ImageW = 420;

        ClsPiece[,] borad = null;

        int pieceH;
        int pieceW;

        public Frmパズル(string fileName, int n)
        {

            InitializeComponent();
            FileName = fileName;
            N = n;
            borad = new ClsPiece[N, N];
            pieceH = ImageH / N;
            pieceW = ImageW / N;
            init();
        }

        private void init()
        {

            ClsUtil util = new ClsUtil();
            ClsPuzzle puzzle = new ClsPuzzle();
            #region ピースの作成

            //画像の切り抜き
            Image img = util.ScalingImage(new Bitmap(FileName), ImageW, ImageH);
            Bitmap bitmap = new Bitmap(img);
            Rectangle rect;
            int index = 0;
            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    borad[y, x] = new ClsPiece();
                    rect = new Rectangle(x * pieceW, y * pieceH, pieceW, pieceH);
                    borad[y, x].img = bitmap.Clone(rect, img.PixelFormat);
                    borad[y, x].No = index;

                    if (index == N * N - 1)
                    {
                        borad[y, x].isLastPiece = true;
                    }
                    else
                    {
                        borad[y, x].isLastPiece = false;
                    }

                    index++;

                    //スペースの初期位置
                    //(N - 1, N - 1)
                    // N * N -1 
                }
            }

            #endregion

            //シャッフル
            puzzle.shuffle(300, borad);
        }

        private void FrmPuzzle_Paint(object sender, PaintEventArgs e)
        {
            PaintImag(e.Graphics);

            ClsPuzzle puzzle = new ClsPuzzle();
            if (puzzle.isEnd(borad))
            {
                MessageBox.Show("完成しました！", "15パズル");
                borad[N - 1, N - 1].isLastPiece = false;
                PaintImag(e.Graphics);
                init();
            }
        }

        private void PaintImag(Graphics g)
        {
            Bitmap canvas = new Bitmap(ImageW, ImageH);
            g = Graphics.FromImage(canvas);

            int cnt = 1;

            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {

                    if (borad[y, x].isLastPiece)
                    {
                        continue;
                    }

                    g.DrawImage(borad[y, x].img, x * pieceW, y * pieceH, pieceW, pieceH);

                    cnt++;
                }
            }

            pictureBox.Image = canvas;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Point location = e.Location;

            int x = location.X;
            int y = location.Y;

            ClsPuzzle puzzle = new ClsPuzzle();
            if (!puzzle.movePiece(x / pieceW, y / pieceH, borad))
            {
                return;
            }

            this.Invalidate();
        }

        private void btn戻る_Click(object sender, EventArgs e)
        {
            Frm画像読込み frm = new Frm画像読込み();
            ClsForm.Instance.Ac.MainForm = frm;
            frm.Show();
            this.Close();
        }

        private void btnもう1回_Click(object sender, EventArgs e)
        {
            init();
        }
    }
}
