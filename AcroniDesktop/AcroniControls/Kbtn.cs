using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniControls
{
    public partial class Kbtn : Button
    {
        public Kbtn()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// <para>Método que muda a cor de um botão.</para>
        /// </summary>
        /// <param name="color"></param>

        public Color SetColor(Color color)
        {
            if (this.BackColor == color)
                return Color.FromArgb(26, 26, 26);
            else
                return color;
        }
    }
}
