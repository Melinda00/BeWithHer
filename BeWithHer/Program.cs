using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeWithHer
{
    static class Program
    {
        public static void SwitchForm<T>(Form formToClose, params object[] args)
        {
            Form newForm = Activator.CreateInstance(typeof(T), args) as Form;
            mAppContext.MainForm = newForm;
            formToClose.Close();
            newForm.Show();
        }

        public static void SwitchForm<T>(Form[] formToClose, params object[] args)
        {
            Form newForm = Activator.CreateInstance(typeof(T), args) as Form;
            mAppContext.MainForm = newForm;
            foreach(Form f in formToClose) f.Close();
            newForm.Show();
        }

        public static void CreateFormDialog<T>(params object[] args)
        {
            Form newForm = Activator.CreateInstance(typeof(T), args) as Form;
            newForm.ShowDialog();
        }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            BeWithHerConnector.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mAppContext.MainForm = new LogIn();
            Application.Run(mAppContext);
            BeWithHerConnector.Disconnect();
        }



        private static ApplicationContext mAppContext = new ApplicationContext();
    }
}
