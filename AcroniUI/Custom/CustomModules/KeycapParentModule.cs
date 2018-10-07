using System;
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
            Fade.FadeIn(this);
        }
    }
}
