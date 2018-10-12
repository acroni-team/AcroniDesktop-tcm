using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniUI.Custom.CustomModules
{
    public partial class KeycapSwitchModule : KeycapParentModule
    {
        public KeycapSwitchModule()
        {
            InitializeComponent();
            Bunifu.Framework.UI.BunifuElipse e = new Bunifu.Framework.UI.BunifuElipse();
            foreach (Control c in this.Controls)
            {
                if (!(c is Label))
                {
                    e.ApplyElipse(c, 5);
                }
            }
        }
    }
}
