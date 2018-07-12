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
using Bunifu.Framework;

namespace acroni
{
    public partial class Acroni : Form
    {
        public Acroni()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Label que sai da aplicação. 
        /// </summary>
        /// 
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int NoOfColorsVisibleOnDisplay { get; set; } = 0;
        private bool isChosen { get; set; }  = true;

        private void btnColorChosen_Click(object sender, EventArgs e)
        {
            if (isChosen)
            {
                isChosen = false;
                panel5.Visible = true;
                if (NoOfColorsVisibleOnDisplay > 0)
                {
                    pnlHistorico.Visible = true;
                    if (NoOfColorsVisibleOnDisplay == 1)
                        btnHist1.Visible = true;
                    else if (NoOfColorsVisibleOnDisplay == 2)
                        btnHist2.Visible = true;
                    else
                        btnHist3.Visible = true;
                }
                
            }
            else
            {
                panel5.Visible = false;
                pnlHistorico.Visible = false;
                isChosen = true;
            }

        }

        /// <summary>
        // Método que pega a cor selecionada de um botão e atualiza o histórico de cores
        /// </summary>

        private void btnGetSelctedColor(object sender, EventArgs e)
        {
            isChosen = true;
            Button btnCol = (Button)sender;
            panel5.Visible = false;
            btnColorChosen.BackColor = btnCol.BackColor;
            if (NoOfColorsVisibleOnDisplay < 3)
                NoOfColorsVisibleOnDisplay++;
            else
                NoOfColorsVisibleOnDisplay = 1;

            if (NoOfColorsVisibleOnDisplay == 1)
                btnHist1.BackColor = btnCol.BackColor;
            else if (NoOfColorsVisibleOnDisplay == 2)
                btnHist2.BackColor = btnCol.BackColor;
            else
                 btnHist3.BackColor = btnCol.BackColor;
            pnlHistorico.Visible = false;
        }
    }
}
