using System;
using System.Windows.Forms;
using System.Threading;
using AcroniUI.Custom;
using AcroniControls;
using AcroniUI.LoginAndSignUp;
using AcroniLibrary.SQL;
using System.IO;

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
            //SQLProcMethods.createProceduresSelect();
            if (File.Exists($@"{Application.StartupPath}\Users\{SQLConnection.nome_usuario}.acr"))
                Application.Run(new SelectKeyboard());
            else
                Application.Run(new FrmLogin());
        }
    }
}
