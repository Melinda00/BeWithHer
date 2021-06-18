using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeWithHer
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            BeWithHerConnector.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CurrentCredential = null;
            Application.Run(new LogIn());
            BeWithHerConnector.Disconnect();
        }

        public static Credential CurrentCredential { get; set; }




    }
}
