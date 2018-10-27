using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniControls
{
    public partial class Keyboard_CollectionSelected : Panel
    {
        public Keyboard_CollectionSelected()
        {
            InitializeComponent();
            Bunifu.Framework.UI.BunifuElipse roundCorners = new Bunifu.Framework.UI.BunifuElipse();
            roundCorners.ApplyElipse(this, 7);
        }

    }
}
