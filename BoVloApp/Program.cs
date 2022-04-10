using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoVloApp
{
    static class Program
    {
        public static bool KeepRunning { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main main = new Main();
            Application.Run(main);
            KeepRunning = true;
            while (KeepRunning)
            {
                KeepRunning = false;
                main.clear();
                MessageBox.Show("ok");
            }
        }
    }
}