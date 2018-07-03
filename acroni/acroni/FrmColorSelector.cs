using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acroni
{
    public partial class FrmColorSelector : Form
    {
        public FrmColorSelector()
        {
            InitializeComponent();
        }
        private static Color c;
        private void btnGetSelctedColor(object sender, EventArgs e)
        {
            Button btnCol = (Button)sender;
            c = btnCol.BackColor;
            
            this.Dispose();
            this.Close();
        }
       
        public Color GetColor()
        {
            return c;
        }
    }
}
