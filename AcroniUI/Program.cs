using System;
using System.Windows.Forms;
using System.Threading;
using AcroniUI.Custom;
using AcroniControls;
using AcroniUI.LoginAndSignUp;

namespace AcroniUI
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.SetApartmentState(ApartmentState.Unknown);
            Application.Run(new Compacto());
        }
    }
}
