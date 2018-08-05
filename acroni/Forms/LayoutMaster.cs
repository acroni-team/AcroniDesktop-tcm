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

namespace acroni.Layout_Master
{
    public partial class LayoutMaster : Form
    {

        #region Construtor
        public LayoutMaster()
        {
            InitializeComponent();
            #region Atribuição de Dragging aos controles e no próprio form 

            ///<summary> 
            /// Esses métodos não foram gerados automaticamente. Trata-se duma maneira de permitir que não apenas o formulário seja arrastável, mas os controles também. 
            ///</summary>
            ///
            foreach (Control c in this.Controls)
            {
                c.MouseDown += new System.Windows.Forms.MouseEventHandler(FormDrag.Form_MouseDown);
                c.MouseMove += new System.Windows.Forms.MouseEventHandler(FormDrag.Form_MouseMove);
            }
            #endregion    
        }
        #endregion

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

        #region Métodos para transição de cores dos botões do menu

        
        private void bunifuImageButton1_MouseMove(object sender, MouseEventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(244, 134, 134);
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(238, 63, 63);
        }

        private void bunifuImageButton2_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(166, 169, 173);
        }

        private void bunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(47, 47, 47);
        }

        #endregion

        #region Ações dos botões do menuStrip e transição de cores
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Fontes das teclas
        /// <summary>
        // Essa parte do programa é destinada para o funcionamento das fontes personalizadas.
        /// </summary>

        static List<object> Fontes = new List<object>();
        static List<object> EstiloDasFontes = new List<object>();

        protected virtual void LayoutMaster_Load(object sender, EventArgs e)
        {
            new CarregarFontes(ref cmbFontes, ref Fontes);
            //foreach (Font fonte in Fontes)
            //{
            //    cmbEstilizacaoDaFonte.Items.Add(fonte);
            //}
        }
        

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
            foreach (FontFamily fonte in Fontes)
            {
                cmbFontes.Items.Remove(fonte);
            }
            LayoutMaster_Load(sender, e);
            if (txtBuscarFontes.Text != "")
            {
                foreach (FontFamily fonte in Fontes)
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