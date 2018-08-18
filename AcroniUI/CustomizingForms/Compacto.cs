using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using Transitions;
using AcroniUI;

namespace AcroniUI.CustomizingForms
{
    public partial class Compacto : LayoutMaster
    {
        /// <summary>
        /// Construtor que carrega o login. 
        /// </summary>

        public Compacto()
        {
            InitializeComponent();
            pnlCorEscolhida.Size = new Size(243, 103);
            
            foreach (Control c_panel in pnlCorEscolhida.Controls)
            {
                if (c_panel is Panel)
                {
                    if (!c_panel.Name.Contains("Divi"))
                    {
                        Bunifu.Framework.UI.BunifuElipse elipse = new Bunifu.Framework.UI.BunifuElipse();
                        elipse.ApplyElipse(c_panel, 5);
                    }
                }
            }
        }

        #region Métodos do Color Picker
        bool pnlcolorpickerEstaAberto = false;
        bool[] disponibilidade_pnlHistorico = { true, false, false};

        private void pnlColor_Click(object sender, EventArgs e)
        {
            if (!pnlcolorpickerEstaAberto)
            {
                aparece_colorpicker();
                pnlcolorpickerEstaAberto = true;
            }
            else
            {
                desaparece_colorpicker();
                pnlcolorpickerEstaAberto = false;
            }
        }

        private async void aparece_colorpicker()
        {

            for (int x = 243; x <= 631; x += 20)
            {
                await Task.Delay(1);
                pnlCorEscolhida.Width = x;
            }
            pnlCorEscolhida.Width = 631;
            await Task.Delay(10);
        }

        private async void desaparece_colorpicker()
        {
            for (int x = 631; x > 243; x -= 20)
            {
                await Task.Delay(1);
                pnlCorEscolhida.Width = x;
            }
            pnlCorEscolhida.Width = 243;
            await Task.Delay(10);
        }

        private void escolhe_cor(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            lblHexaColor.Text = $"#{p.BackColor.R.ToString("X2")}{p.BackColor.G.ToString("X2")}{p.BackColor.B.ToString("X2")}";
            lblNomeCor.Text = (!p.Name.Contains("pnl") ? p.Name.Replace("_", " ") : p.Tag.ToString());

            //--Transição para mudar de cor
            Transition t_cor = new Transition(new TransitionType_EaseInEaseOut(200));
            t_cor.add(pnlColor, "BackColor", p.BackColor);
            t_cor.run();

            desaparece_colorpicker();
            pnlcolorpickerEstaAberto = false;

            if (disponibilidade_pnlHistorico[0])
            {
                pnlHistorico1.BackColor = p.BackColor;
                disponibilidade_pnlHistorico[0] = false;
                disponibilidade_pnlHistorico[1] = true;
            }
            else if (disponibilidade_pnlHistorico[1])
            {
                pnlHistorico2.BackColor = p.BackColor;
                disponibilidade_pnlHistorico[1] = false;
                disponibilidade_pnlHistorico[2] = true;
            }
            else if (disponibilidade_pnlHistorico[2])
            {
                pnlHistorico3.BackColor = p.BackColor;
                disponibilidade_pnlHistorico[2] = false;
                disponibilidade_pnlHistorico[0] = true;
            }
        }
        #endregion

        //#region Métodos do colorpicker
        ///// <summary>
        ///// Essa parte do programa está destinada ao funcionamento do colorpicker.
        ///// </summary>

        ///// <summary>
        //// Método que pega a cor selecionada de um botão e atualiza o histórico de cores
        ///// </summary>
        //private void btnColorChosen_Click(object sender, EventArgs e)
        //{
        //    new SetColorpickerVisibility(ref pnlColorpicker, ref btnHist1, ref btnHist2, ref btnHist3, ref pnlHistorico);
        //}

    
        //private void btnGetSelctedColor(object sender, EventArgs e)
        //{
        //    Button btnCol = (Button)sender;
        //    new SetHistColors(ref pnlColorpicker, ref btnCol, ref btnColorChosen, ref btnHist1, ref btnHist2, ref btnHist3, ref pnlHistorico);
        //    lblCorRGB.Text = String.Format("R: {0}, G: {1}, B: {2} ", SetHistColors.GetColor.R, SetHistColors.GetColor.G, SetHistColors.GetColor.B);
        //    if (SetHistColors.GetColor.IsKnownColor)
        //    {
        //        lblKnownColorName.Visible = true;
        //        lblKnownColorName.Text = String.Format("Outro nome: {0}", SetHistColors.GetColor.Name);
        //    }
        //    else
        //        lblKnownColorName.Visible = false;
        //}

        //#endregion

    }
}