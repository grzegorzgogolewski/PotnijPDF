using System;
using System.Windows.Forms;

namespace PotnijPDF
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzYxMjE1QDMyMzAyZTMzMmUzMG0zQVpHR1dyQVdmblBZTGJGRm1vdTU1R1ZtLzJMWDBiTWxiSll5K1JGVzA9");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
