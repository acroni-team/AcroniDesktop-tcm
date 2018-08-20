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
            this.Size = new Size(38, 40);
            this.BackColor = Color.FromArgb(26, 26, 26);
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.TextAlign = ContentAlignment.TopLeft;
            this.Font = new Font("Open Sans", 12f);
            this.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// <para>Método que muda a cor de um botão.</para>
        /// </summary>
        /// <param name="color"></param>

        public void SetColor(Color color)
        {
            if (this.BackColor == color)
                this.BackColor = Color.Transparent;
            else
                this.BackColor = color;
        }
    }
}
