using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcroniLibrary.DesignMethods;

namespace AcroniUI.Custom.CustomModules
{
    public partial class KeycapParentModule : Form
    {
        public KeycapParentModule()
        {
            InitializeComponent();
        }

        private void KeycapParentModule_Load(object sender, EventArgs e)
        {
            FadeIn();
        }

        ~KeycapParentModule()
        {
            FadeOut();
        }

        #region FadeIn e FadeOut
        public async void FadeOut()
        {
            while (Opacity > 0)
            {
                await Task.Delay(1);
                Opacity -= 0.05;
            }
            Application.Exit();
        }

        public async void FadeIn()
        {
            while (Opacity < 1)
            {
                await Task.Delay(1);
                Opacity += 0.05;
            }
            Opacity = 1.0;
        }
        #endregion
    }
}
