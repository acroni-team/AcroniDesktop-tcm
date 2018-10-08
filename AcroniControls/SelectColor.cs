using AcroniLibrary.FileInfo;
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
    public partial class SelectColor : Form
    {
        Button selected;
        List<int> rgb = new List<int>();
        int contRGB = 0;
        public SelectColor()
        {
            InitializeComponent();
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            if (selected != null)
                selected.FlatAppearance.BorderSize = 0;
            selected = (Button)sender;
            Share.Collection.CollectionColor = (sender as Button).BackColor;
            (sender as Button).FlatAppearance.BorderSize = 1;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            if (txtColor.Text.Length >= 4)
            {
                try
                {
                    Share.Collection.CollectionColor = ColorTranslator.FromHtml(txtColor.Text);
                }
                catch (Exception)
                {
                    try
                    {
                        foreach (char c in txtColor.Text)
                        {
                            if (c != ';')
                                rgb[contRGB] += c;
                            else
                                contRGB++;
                        }
                        Share.Collection.CollectionColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
                    }
                    catch (Exception) { }
                }
            }
        }
    }
}
