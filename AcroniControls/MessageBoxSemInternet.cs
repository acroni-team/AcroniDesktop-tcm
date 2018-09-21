using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniControls
{
    public partial class MessageBoxSemInternet : Form
    {
        public MessageBoxSemInternet()
        {
            InitializeComponent();
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            ellipse.ApplyElipse(this, 15);
            btnEntendi.Cursor = Cursors.Hand;
            lblEntendi.Cursor = Cursors.Hand;

        }

        private void btnEntendi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEntendi_Click(object sender, EventArgs e)
        {
            btnEntendi_Click(sender, e);
        }
    }
}
