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
    public partial class Frm時計 : Form
    {
        Point P0;   //中心
        Point P1;   //秒針基準値(秒)
        Point P2;   //長針基準値(分)
        Point P3;   //短針基準値(時)

        Point Q1;   //秒針移動(秒)
        Point Q2;   //長針移動(分)
        Point Q3;   //短針移動(時)

        Point PN;   //数字
        Point PS;   //目盛り

        double AngleS;
        double AngleM;
        double AngleH;

        const double IntervalS = 6;     //秒針間隔
        const double IntervalM = 6;     //長針間隔
        const double IntervalH = 0.5;   //短針間隔

        public Frm時計()
        {
            InitializeComponent();

            P0 = new Point(150, 150);
            P1 = new Point(150, 50);    //秒針
            P2 = new Point(150, 60);    //長針
            P3 = new Point(150, 70);    //短針

            PN = new Point(150, 20);    //数字
            PS = new Point(150, 35);    //目盛り 

            Q1 = P1;
            Q2 = P2;
            Q3 = P3;

            AngleS = 0;
            AngleM = 0;
            AngleH = 0;

            this.DoubleBuffered = true;
        }

        private void Frm時計_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;

            AngleS = second * IntervalS;
            AngleM = minute * IntervalM;
            AngleH = (hour % 12 * 60 + minute) * IntervalH;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Frm時計_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.White);

            g.DrawLine(Pens.Blue, P0, Q2);  //長針
            g.DrawLine(Pens.Red, P0, Q3);   //短針
            g.DrawLine(Pens.Green, P0, Q1); //秒針
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateClock();
            this.Invalidate();
        }

        private void UpdateClock()
        {
            double radS;
            double radM;
            double radH;

            //針の位置計算
            AngleS += IntervalS;

            if (AngleS == 360)
            {
                AngleS = 0;
                AngleM += IntervalM;
                if (AngleM == 360)
                {
                    AngleM = 0;
                }
                AngleH += IntervalH;
                if (AngleH == 360)
                {
                    AngleH = 0;
                }
            }

            //秒針
            radS = AngleS * Math.PI / 180;
            Q1.X = (int)((P1.X - P0.X) * Math.Cos(radS) - (P1.Y - P0.Y) * Math.Sin(radS) + P0.X);
            Q1.Y = (int)((P1.X - P0.X) * Math.Sin(radS) + (P1.Y - P0.Y) * Math.Cos(radS) + P0.Y);

            //長針
            radM = AngleM * Math.PI / 180;
            Q2.X = (int)((P2.X - P0.X) * Math.Cos(radM) - (P2.Y - P0.Y) * Math.Sin(radM) + P0.X);
            Q2.Y = (int)((P2.X - P0.X) * Math.Sin(radM) + (P2.Y - P0.Y) * Math.Cos(radM) + P0.Y);

            //短針
            radH = AngleH * Math.PI / 180;
            Q3.X = (int)((P3.X - P0.X) * Math.Cos(radH) - (P3.Y - P0.Y) * Math.Sin(radH) + P0.X);
            Q3.Y = (int)((P3.X - P0.X) * Math.Sin(radH) + (P3.Y - P0.Y) * Math.Cos(radH) + P0.Y);

        }
    }
}
