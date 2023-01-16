using System;
using System.Windows.Forms;

namespace LOGIN
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // inicializar pantalla de login con usuario vacio
            Application.Run(new logueo(""));
        }
    }
}
