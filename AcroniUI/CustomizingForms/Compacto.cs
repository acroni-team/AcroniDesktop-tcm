using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using Transitions;
using AcroniControls;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AcroniLibrary.CustomizingMethods.TextFonts;

namespace AcroniUI.CustomizingForms
{
    public partial class Compacto : Template
    {
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
        bool[] disponibilidade_pnlHistorico = { true, false, false };

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

        #region Fontes das teclas

        static List<FontFamily> lista_fontFamily = new List<FontFamily>();

        private void FormLoad(object sender, EventArgs e)
        {
            new LoadFontTypes(ref cmbFontes, ref lista_fontFamily);
        }

        protected float FontSize { get; set; } = 12f;
        protected FontStyle FontStyle { get; set; } = FontStyle.Regular;

        #region Métodos de selecionar estilo da fonte e tamanho
        private void btnStyleBold_Click(object sender, EventArgs e)
        {
            FontStyle = FontStyle.Bold;
            AtualizarFontes();
        }

        private void btnStyleItalic_Click(object sender, EventArgs e)
        {
            FontStyle = FontStyle.Italic;
            AtualizarFontes();
        }

        private void btnStyleUnderline_Click(object sender, EventArgs e)
        {
            FontStyle = FontStyle.Underline;
            AtualizarFontes();
        }

        private void btnStyleStrikeout_Click(object sender, EventArgs e)
        {
            FontStyle = FontStyle.Strikeout;
            AtualizarFontes();
        }

        private void btnSizeBig_Click(object sender, EventArgs e)
        {
            FontSize = 14f;
            AtualizarFontes();
        }

        private void btnSizeMedium_Click(object sender, EventArgs e)
        {
            FontSize = 12f;
            AtualizarFontes();
        }

        private void btnSizeSmall_Click(object sender, EventArgs e)
        {
            FontSize = 10f;
            AtualizarFontes();
        }

        #region Definição dos métodos de alinhamento
        private void setButtonTextAlignment(ContentAlignment contentAlignment)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Kbtn)
                {
                    (c as Button).TextAlign = contentAlignment;
                }
            }
        }

        private void btnTextAlignLeft_Click(object sender, EventArgs e)
        {
            setButtonTextAlignment(ContentAlignment.TopLeft);
        }

        private void btnTextAlignCenter_Click(object sender, EventArgs e)
        {
            setButtonTextAlignment(ContentAlignment.TopCenter);
        }

        private void btnTextAlignRight_Click(object sender, EventArgs e)
        {
            setButtonTextAlignment(ContentAlignment.TopRight);
        }
        #endregion

        #endregion

        private void AtualizarFontes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Kbtn)
                {
                    (c as Button).Font = new Font(cmbFontes.Text, FontSize, FontStyle);
                }
            }
        }

        protected virtual void cmbFontes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarFontes();
        }

        private void txtFiltrarFontes_OnValueChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(txtFiltrarFontes.Text, RegexOptions.IgnoreCase);
            foreach (FontFamily fonte in lista_fontFamily)
            {
                cmbFontes.Items.Remove(fonte);
            }
            FormLoad(sender, e);
            if (!txtFiltrarFontes.Text.Equals(""))
            {
                foreach (FontFamily fonte in lista_fontFamily)
                {
                    if (!(regex.IsMatch(fonte.ToString())))
                    {
                        cmbFontes.Items.Remove(fonte);
                    }
                }
            }
        }

        #endregion
    }
}