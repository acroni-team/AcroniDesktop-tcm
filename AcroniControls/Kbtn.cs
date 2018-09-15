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
        }

        /// <summary>
        /// <para>Método que muda a cor de um botão.</para>
        /// </summary>
        /// <param name="color"></param>

        public void Fontyle(Font fontFace, FontStyle fontStyle)
        {
            if (this.Font.Style == fontStyle)
                this.Font = new Font(fontFace, FontStyle.Regular);
            else
                this.Font = new Font(fontFace, fontStyle);
        }

        public void SetColor(Color color)
        {
            if (this.BackColor == color)
                this.BackColor = Color.Transparent;
            else
                this.BackColor = color;
        }
    }
}
