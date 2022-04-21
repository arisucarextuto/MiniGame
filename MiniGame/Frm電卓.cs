using MiniGame.Cls;
using System;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Frm電卓 : Form
    {
        enum eArithmetic
        {
            Div,
            Mutl,
            Sub,
            Add,
            None
        }

        eArithmetic gArithmetic;
        decimal gVal1;

        public Frm電卓()
        {
            InitializeComponent();
            this.txtResult.Text = "0";
            gArithmetic = eArithmetic.None;
            gVal1 = 0;
        }

        /// <summary>
        /// 数字が押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            decimal iNum = Decimal.Parse(this.txtResult.Text + btn.Text);

            this.txtResult.Text = iNum.ToString();
        }

        /// <summary>
        /// 四則演算が押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "÷")
            {
                gArithmetic = eArithmetic.Div;
            }
            else if (btn.Text == "×")
            {
                gArithmetic = eArithmetic.Mutl;
            }
            else if (btn.Text == "-")
            {
                gArithmetic = eArithmetic.Sub;
            }
            else if (btn.Text == "+")
            {
                gArithmetic = eArithmetic.Add;
            }

            gVal1 = Decimal.Parse(this.txtResult.Text);
            this.txtResult.Text = "0";
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            decimal val2 = Decimal.Parse(this.txtResult.Text);
            decimal valResult = 0;

            switch (gArithmetic)
            {
                case eArithmetic.Div:
                    valResult = gVal1 / val2;
                    break;
                case eArithmetic.Mutl:
                    valResult = gVal1 * val2;
                    break;
                case eArithmetic.Sub:
                    valResult = gVal1 - val2;
                    break;
                case eArithmetic.Add:
                    valResult = gVal1 + val2;
                    break;
                default:
                    break;
            }

            this.txtResult.Text = valResult.ToString();
        }

        /// <summary>
        /// クリアボタンが押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "0";
            gArithmetic = eArithmetic.None;
            gVal1 = 0;
        }

        private void btn戻る_Click(object sender, EventArgs e)
        {
            Frmメニュー frm = new Frmメニュー();
            ClsForm.Instance.formShow(frm);
            this.Close();
        }
    }
}
