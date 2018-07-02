using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool naofez = true;
        public Color Colorpicker { get; set; }
        List<string> IE = new List<string>();
        List<object> Fonte = new List<object>();

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox2.Image);
            Color c = b.GetPixel(e.X, e.Y);
            pictureBox3.BackColor = c;
            Colorpicker = c;
            lblCor.Text = Colorpicker.ToString();
        }

        private void btnAbstractus_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Colorpicker)
                b.BackColor = Color.Transparent;
            else
                b.BackColor = Colorpicker;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Colorpicker;
        }

        private void lblCorTotal_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is btnColor)
                {
                    (c as Button).BackColor = Colorpicker;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter outfile = new StreamWriter(@"C:\Users\Public\teste.acr"))
            {
                IE.Add("fez?");
                IE.Add("n fez");
                for (int i = 0; i < IE.Count; i++)
                {
                    outfile.WriteLine(IE[i]);
                }
                outfile.Flush();
            }
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            using (StreamReader outfile = new StreamReader(@"C:\Users\Public\teste.acr"))
            {
                label1.Text = outfile.ReadToEnd();
                outfile.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    cmbFont.Items.Add(fa.Name);
                    if (naofez)
                    {
                        Fonte.Add(fa.Name);
                    }
                }
                naofez = false;
            }
        }
        private void removeCmbBox()
        {
            foreach(string c in Fonte)
            {
                cmbFont.Items.Remove(c);
            }
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is btnColor)
                {
                    c.Font = new System.Drawing.Font(cmbFont.Text, 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex a = new Regex(textBox1.Text,RegexOptions.IgnoreCase);
            removeCmbBox();
            Form1_Load(sender, e);
            if (textBox1.Text != "")
            {
                foreach (string c in Fonte)
                {
                    if (!(a.IsMatch(c)))
                    {
                        cmbFont.Items.Remove(c);
                    }

                }
            }
        }
    }
}
