using System.Windows.Forms;

namespace MiniGame.Cls
{
    public class ClsForm
    {
        private static ClsForm _Instance = new ClsForm();

        //外部からnewできないおゆにするためにprivate
        private ClsForm()
        {
            _Ac = new ApplicationContext();
        }

        public static ClsForm Instance
        {
            get
            {
                return _Instance;
            }
        }

        ApplicationContext _Ac;

        public ApplicationContext Ac
        {
            get
            {
                return _Ac;
            }
        }

        public void formShow(Form frm)
        {
            ClsForm.Instance.Ac.MainForm = frm;
            frm.Show();
        }
    }
}
