using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcroniLibrary;

namespace AcroniUI.CustomizingForms.CustomizingModules
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
