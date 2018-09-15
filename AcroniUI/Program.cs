using System;
using System.Windows.Forms;
using AcroniUI.CustomizingForms;
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
            Application.Run(new Compacto());
        }
    }
}
