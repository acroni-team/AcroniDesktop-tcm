using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acroni
{
    public partial class Acroni : Form
    {
        public Acroni()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int contHist = 0; bool selectColor = true;
        private void btnColorSelector_Click(object sender, EventArgs e)
        {
            if (selectColor)
            {
                selectColor = false;
                panel5.Visible = true;
                if (contHist > 0)
                {
                    pnlHistorico.Visible = true;
                    if (contHist == 1)
                        btnHist1.Visible = true;
                    else if (contHist == 2)
                        btnHist2.Visible = true;
                    else
                        btnHist3.Visible = true;
                }
                
            }else
            {
                panel5.Visible = false;
                pnlHistorico.Visible = false;
                selectColor = true;
            }

        }
        //Método que pega a cor selecionada de um botão e atualiza o histórico de cores
        private void btnGetSelctedColor(object sender, EventArgs e)
        {
            selectColor = true;
            Button btnCol = (Button)sender;
            panel5.Visible = false;
            btnColorSelector.BackColor = btnCol.BackColor;
            if (contHist < 3)
                contHist++;
            else
                contHist = 1;
            //------------------
            if (contHist == 1)
                btnHist1.BackColor = btnCol.BackColor;
            else if (contHist == 2)
                btnHist2.BackColor = btnCol.BackColor;
            else
                 btnHist3.BackColor = btnCol.BackColor;
            pnlHistorico.Visible = false;
        }
    }
}
