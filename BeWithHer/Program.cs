using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeWithHer
{
    static class Program
    {
        public static void SwitchForm<T>(Form before)
        {
            Form newForm = Activator.CreateInstance<T>() as Form;
            mAppContext.MainForm = newForm;
            before.Close();
            newForm.Show();
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
