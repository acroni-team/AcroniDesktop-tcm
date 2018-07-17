using System;
using System.Windows.Forms;
using acroni.Colorpicker;
using acroni.Layout_Master;
using acroni.Login;
using acroni.Fontes;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace acroni
{
    public partial class Acroni : LayoutMaster
    {
        /// <summary>
        /// Construtor que carrega o login. 
        /// </summary>
        public Acroni()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            InitializeComponent();
            trocar_nome_usuario(ColorpickerHandlers.nome_usuario);
        }

        /// <summary>
            /// Essa parte do programa está destinada ao funcionamento do colorpicker.
            /// </summary>
        private void btnColorChosen_Click(object sender, EventArgs e)
        {
            SetColorpickerVisibility a = new SetColorpickerVisibility(ref pnlColorpicker, ref btnHist1, ref btnHist2, ref btnHist3, ref pnlHistorico);
        }

        /// <summary>
        // Método que pega a cor selecionada de um botão e atualiza o histórico de cores
        /// </summary>

        private void btnGetSelctedColor(object sender, EventArgs e)
        {
            Button btnCol = (Button)sender;
            SetHistColors a = new SetHistColors(ref pnlColorpicker, ref btnCol, ref btnColorChosen, ref btnHist1, ref btnHist2, ref btnHist3, ref pnlHistorico);
            lblCorRGB.Text = String.Format("R: {0}, G: {1}, B: {2} ", SetHistColors.GetColor.R, SetHistColors.GetColor.G, SetHistColors.GetColor.B);
            if (SetHistColors.GetColor.IsKnownColor)
            {
                lblKnownColorName.Visible = true;
                lblKnownColorName.Text = String.Format("Outro nome: {0}", SetHistColors.GetColor.Name);
            }
            else
                lblKnownColorName.Visible = false;
        }

        /// <summary>
        // Essa parte do programa é destinada para o funcionamento das fontes personalizadas.
        /// </summary>

        List<object> Fonte = new List<object>();

        private void Acroni_Load(object sender, EventArgs e)
        {
            LoadFontes a = new LoadFontes(ref cmbFonts, ref Fonte);
        }

        private void txtSelectFont_TextChanged(object sender, EventArgs e)
        {
            Regex a = new Regex(txtSelectFont.Text, RegexOptions.IgnoreCase);
            foreach (string c in Fonte)
            {
                cmbFonts.Items.Remove(c);
            }
            Acroni_Load(sender, e);
            if (txtSelectFont.Text != "")
            {
                foreach (string c in Fonte)
                {
                    if (!(a.IsMatch(c)))
                    {
                        cmbFonts.Items.Remove(c);
                    }
                }
            }
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Font = new System.Drawing.Font(cmbFonts.Text, 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    }
}
