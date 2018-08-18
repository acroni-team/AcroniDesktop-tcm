using System;
using System.Windows.Forms;
using FormsDesign;
using System.Drawing;
//Eu não sei porque carlos meu VS não atualiza esse diretório: using acroni.Forms.Customizacao.Galeria;
using acroni.Forms.Seleção_do_teclado;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using Svg;
using SVGSample.svg;
using acroni.Fontes;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using acroni.Forms.Formulario_de_template;

namespace acroni.Layout_Master
{
    public partial class LayoutMaster : FrmTemplate
    {

        public LayoutMaster()
        {
            InitializeComponent();
        }

        #region Métodos de abrir formulários
        protected void btnAbrirGaleria_Click(object sender, EventArgs e)
        {
            Galeria.Galeria galeria = new Galeria.Galeria();
            galeria.Show();
        }

        private void btnAbrirSelecaoDeTeclado_Click(object sender, EventArgs e)
        {
            SelecionarTeclado selecionarTeclado = new SelecionarTeclado();
            selecionarTeclado.Show();
        }

        private void btnContinuarCustomizando_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Fontes das teclas
        /// <summary>
        // Essa parte do programa é destinada para o funcionamento das fontes personalizadas.
        /// </summary>

        static List<FontFamily> lista_fontFamily = new List<FontFamily>();
        static List<Font> lista_fonte = new List<Font>();

        protected virtual void LayoutMaster_Load(object sender, EventArgs e)
        {
            new CarregarFontes(ref cmbFontes, ref lista_fontFamily);

            foreach (FontFamily fonteFamily in lista_fontFamily)
            {
                if (fonteFamily.IsStyleAvailable(FontStyle.Bold))
                    cmbEstilizacaoDaFonte.Items.Add(new Font(fonteFamily,5,FontStyle.Bold).Name);
            }
        }

        public delegate void Fonte(Font font);
        private void cmbFontes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Font = new System.Drawing.Font(cmbFontes.Text, 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void txtBuscarFontes_OnValueChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(txtBuscarFontes.Text, RegexOptions.IgnoreCase);
            foreach (FontFamily fonte in lista_fontFamily)
            {
                cmbFontes.Items.Remove(fonte);
            }
            LayoutMaster_Load(sender, e);
            if (txtBuscarFontes.Text != "")
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