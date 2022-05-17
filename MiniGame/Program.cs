using MiniGame.Cls;
using System;
using System.Windows.Forms;

namespace MiniGame
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //ApplicationContext ac = new ApplicationContext();
            //ac.MainForm = new Frmメニュー();

            ClsForm.Instance.Ac.MainForm = new Frmログイン();
            Application.Run(ClsForm.Instance.Ac);
        }
    }
}
