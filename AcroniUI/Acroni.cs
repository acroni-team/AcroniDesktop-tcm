using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading.Tasks;
using Transitions;
using AcroniLibrary.CustomizingMethods.TextFonts;

namespace acroni
{
    public partial class Acroni : AcroniUI.LayoutMaster
    {
       protected FontStyle penis;
        /// <summary>
        /// Construtor que carrega o login. 
        /// </summary>

            //public void initialize_Splash()
            //{
            //Application.Run(new SplashEscrita());
            //}

        public Acroni()
        {
            //Thread t_splash = new Thread(new ThreadStart(initialize_Splash));
            //t_splash.Start();
            AcroniUI.LoginAndSignUp.FrmLogin frmLogin = new AcroniUI.LoginAndSignUp.FrmLogin();
            InitializeComponent();
            pnlCorEscolhida.Size = new Size(243, 103);
            //t_splash.Abort();
            frmLogin.ShowDialog();

            foreach (Control c_panel in pnlCorEscolhida.Controls)
            {
                if (c_panel is Panel)
                {
                    if (!c_panel.Name.Contains("Divi"))
                    {
                        Bunifu.Framework.UI.BunifuElipse elipse = new Bunifu.Framework.UI.BunifuElipse();
                        elipse.ApplyElipse(c_panel,5);
                    }
                }
            }
        }

        #region Métodos do Color Picker
        bool pnlCorEscolhida_estaAberto = false;
        bool[] disponibilidade_pnlHistorico = { true, true , true };

        private void pnlColor_Click(object sender, EventArgs e)
        {
            if (!pnlCorEscolhida_estaAberto)
            {
                aparece_colorpicker();
                pnlCorEscolhida_estaAberto = true;
            }
            else
            {
                desaparece_colorpicker();
                pnlCorEscolhida_estaAberto = false;
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
            
            lblHexaColor.Text = "#" + (p.BackColor.R.ToString("X").Length == 1 ? "0" + p.BackColor.R.ToString("X") : p.BackColor.R.ToString("X")) + (p.BackColor.G.ToString("X").Length == 1 ? "0" + p.BackColor.G.ToString("X") : p.BackColor.G.ToString("X")) + (p.BackColor.B.ToString("X").Length == 1 ? "0" + p.BackColor.B.ToString("X") : p.BackColor.B.ToString("X"));
            lblNomeCor.Text = p.BackColor.Name;

            //--Transição para mudar de cor
            Transition t_cor = new Transition(new TransitionType_EaseInEaseOut(200));
            t_cor.add(pnlColor, "BackColor", p.BackColor);
            t_cor.run();

            desaparece_colorpicker();
            pnlCorEscolhida_estaAberto = false;

            if (disponibilidade_pnlHistorico[0])
            {
                pnlHistorico1.BackColor = p.BackColor;
                disponibilidade_pnlHistorico[0] = false;
                disponibilidade_pnlHistorico[1] = true;
            }else if (disponibilidade_pnlHistorico[1])
            {
                pnlHistorico2.BackColor = p.BackColor;
                disponibilidade_pnlHistorico[1] = false;
                disponibilidade_pnlHistorico[2] = true;
            }else if (disponibilidade_pnlHistorico[2])
            {
                pnlHistorico3.BackColor = p.BackColor;
                disponibilidade_pnlHistorico[2] = false;
                disponibilidade_pnlHistorico[0] = true;
            }
        }
        #endregion

        #region Fontes das teclas
        /// <summary>
        // Essa parte do programa é destinada para o funcionamento das fontes personalizadas.
        /// </summary>
        List<FontFamily> Fontes = new List<FontFamily>();

        private void Acroni_Load(object sender, EventArgs e)
        {
            new LoadFonts(ref cmbFonts, ref Fontes);
        }

        ComboBox fontestilo = new ComboBox();

        private void Adicionar()
        {
            fontestilo.Items.Add(FontStyle.Regular);
            fontestilo.Items.Add(FontStyle.Italic);
            fontestilo.Items.Add(FontStyle.Bold);
        }
        
        private void fontestilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            penis = (FontStyle) fontestilo.SelectedItem;
            cmbFonts_SelectedIndexChanged(sender, e);
        }

        private void txtSelectFont_TextChanged(object sender, EventArgs e)
        {
            Regex a = new Regex(txtSelectFont.Text, RegexOptions.IgnoreCase);
            foreach (FontFamily F in Fontes)
            {
                cmbFonts.Items.Remove(F);
            }
            Acroni_Load(sender, e);
            if (txtSelectFont.Text != "")
            {
                foreach (FontFamily FF in Fontes)
                {
                    if (!(a.IsMatch(FF.Name)))
                    {
                        cmbFonts.Items.Remove(FF);
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
                    c.Font = new System.Drawing.Font(cmbFonts.Text, 6.8F, penis, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        #endregion
    }
}