using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TheKhanSoftsWatermarkTextbox
{
    public partial class TextboxWithPlaceholder: TextBox
    {
        public TextboxWithPlaceholder()
        {
            InitializeComponent();
        }
        // Declaration of variables

        private string _watermarktext;
        private bool _multiline = false;

        public string WatermarkText
        {
            get
            {
                return _watermarktext;
            }
            set
            {
                _watermarktext = value;
                GetSetWatermark();
            }
        }

        [Browsable(false)]
        public new bool Multiline
        {
            get { return _multiline; }
            set {_multiline = false; }
        }

        // This method will check if the custom TextBox is wheter empty or not
        private void GetSetWatermark()
        {
            if ((this.Text == WatermarkText)||(this.Text == string.Empty))
            {
                this.ForeColor = Color.FromArgb(114, 137, 218);
                this.Text = WatermarkText;
            }
            else
            {
                this.ForeColor = Color.Black;
            }
        }

        private void Caixinha_Enter(object sender, EventArgs e)
        {
            if (this.Text == WatermarkText || this.Text == string.Empty)
            {
                this.Text = string.Empty;
                this.ForeColor = Color.Black;
            }
        }

        private void Caixinha_Leave(object sender, EventArgs e)
        {
            GetSetWatermark();
        }
    }
}
