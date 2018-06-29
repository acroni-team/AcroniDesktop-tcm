using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

class btnColor : Button
    {
    /// <summary>
    /// <para>Metodo que muda a cor de um botão.</para>
    /// </summary>
    /// <param name="setColor"></param>

    public void setColor(Color c)
        {
        if (this.BackColor == c)
            this.BackColor = Color.Transparent;
        else
            this.BackColor = c;
        }
    }
