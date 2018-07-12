using System;
using System.Windows.Forms;
using acroni.Colorpicker;

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

        private void btnColorChosen_Click(object sender, EventArgs e)
        {
            SetColorpickerVisibility a = new SetColorpickerVisibility(ref pnlColorpicker, ref btnHist1, ref btnHist1, ref btnHist1); 
        }

        /// <summary>
        // Método que pega a cor selecionada de um botão e atualiza o histórico de cores
        /// </summary>

        private void btnGetSelctedColor(object sender, EventArgs e)
        {
            Button btnCol = (Button)sender;
            GetSelectedColor a = new GetSelectedColor(ref pnlColorpicker, ref btnCol, ref btnColorChosen, ref btnHist1, ref btnHist2, ref btnHist3);
        }
    }
}
