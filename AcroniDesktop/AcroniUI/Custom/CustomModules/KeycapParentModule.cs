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

        #region FadeIn e FadeOut
        public virtual async void FadeOut(int delay)
        {
            while (Opacity > 0)
            {
                await Task.Delay(delay);
                Opacity -= 0.05;
            }
        }

        public async void FadeIn()
        {
            while (Opacity < 1)
            {
                await Task.Delay(30);
                Opacity += 0.05;
            }
            Opacity = 1.0;
        }
        #endregion

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
