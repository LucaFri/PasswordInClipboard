using System;
using System.Linq;
using System.Windows.Forms;

namespace PasswordInClipboard
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            string password = arg.Count() >  0 ? arg[0] : string.Empty;  
            Clipboard.SetData(DataFormats.Text, (Object)password);
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
