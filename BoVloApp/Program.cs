using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoVloApp
{
    static class Program
    {
        public static string session_id { get; set; }
        public static Dictionary<string, int> basket = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            session_id = GlobalVar.RandomString(20);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main main = new Main();
            Application.Run(main);
            string Session_id  = GlobalVar.RandomString(20);
        }
    }
}