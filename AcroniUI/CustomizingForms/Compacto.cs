using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using Transitions;
using AcroniControls;
using System.Collections.Generic;
using AcroniLibrary.CustomizingMethods.TextFonts;
using AcroniLibrary;
using AcroniLibrary.FileInfo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AcroniLibrary.CustomizingMethods;
using System.Linq;

namespace AcroniUI.CustomizingForms
{
    public partial class Compacto : Template
    {


        // Keycap genérica que serve para aplicar propriedades de estilo às keycaps através de um sender.
        private Kbtn kbtn;

        // Membro que definirá a cor do teclado no método de escolher a cor do colorpicker. 
        private Color Color { get; set; } = Color.FromArgb(26, 26, 26);

        // Essas propriedades são usadas no kbtn acima:
        private float FontSize { get; set; } = 12f;
        private Font FontSender { get; set; } = SystemFonts.GetFontByName("Open Sans");
        private FontStyle FontStyle { get; set; } = FontStyle.Regular;
        private ContentAlignment ContentAlignment { get; set; } = ContentAlignment.TopLeft;

        // Esse membro serve para pegar o ícone selecionado e botá-lo na fila de ícones.
        private Image icon { get; set; }
        private static List<FontFamily> lista_fontFamily = new List<FontFamily>();

        Teclado keyboard = new Teclado();

        private void kbtn_Click(object sender, EventArgs e)
        {
            kbtn = (Kbtn)sender;
            kbtn.Font = new Font(FontSender.FontFamily, FontSize, FontStyle);
            kbtn.TextAlign = ContentAlignment;
            kbtn.BackColor = kbtn.SetColor(Color);
        }

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
            if (Compartilha.editKeyboard)
                carregaTeclado();
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

            Color = p.BackColor;

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

        #region clicks dos botões de estilização da fonte

        private void btnStyleBold_Click(object sender, EventArgs e)
        {
            if (FontStyle != FontStyle.Bold)
            {
                FontStyle = FontStyle.Bold;
                btnStyleBold.BackColor = Color.FromArgb(90, 90, 90);
            }
            else
            {
                FontStyle = FontStyle.Regular;
                btnStyleBold.BackColor = Color.FromArgb(40, 40, 40);
            }
        }

        private void btnStyleItalic_Click(object sender, EventArgs e)
        {
            if (FontStyle != FontStyle.Italic)
            {
                FontStyle = FontStyle.Italic;
                btnStyleItalic.BackColor = Color.FromArgb(90, 90, 90);
            }
            else
            {
                FontStyle = FontStyle.Regular;
                btnStyleItalic.BackColor = Color.FromArgb(40, 40, 40);
            }
        }

        private void btnStyleUnderline_Click(object sender, EventArgs e)
        {
            if (FontStyle != FontStyle.Underline)
            {
                FontStyle = FontStyle.Underline;
                btnStyleUnderline.BackColor = Color.FromArgb(90, 90, 90);
            }
            else
                FontStyle = FontStyle.Regular;
        }

        private void btnStyleStrikeout_Click(object sender, EventArgs e)
        {
            if (FontStyle != FontStyle.Strikeout)
            {
                FontStyle = FontStyle.Strikeout;
                btnStyleStrikeout.BackColor = Color.FromArgb(90, 90, 90);
            }
            else
                FontStyle = FontStyle.Regular;
        }

        private void btnSizeBig_Click(object sender, EventArgs e)
        {
            if (FontSize != 14f)
            {
                FontSize = 14f;
                btnSizeBig.BackColor = Color.FromArgb(90, 90, 90);
            }
            else
            {
                FontSize = 12f;
            }
        }

        private void btnSizeMedium_Click(object sender, EventArgs e)
        {
            if (FontSize != 12f)
            {
                FontSize = 12f;
                btnSizeMedium.BackColor = Color.FromArgb(90, 90, 90);
            }
            else
            {
                btnSizeMedium.BackColor = Color.FromArgb(90, 90, 90);
            }
        }

        private void btnSizeSmall_Click(object sender, EventArgs e)
        {
            if (FontSize != 10f)
                FontSize = 10f;
            else
                FontSize = 12f;
        }
        #endregion

        #region Definição dos métodos de alinhamento

        private void btnTextAlignLeft_Click(object sender, EventArgs e)
        {
            ContentAlignment = ContentAlignment.TopLeft;
        }

        private void btnTextAlignCenter_Click(object sender, EventArgs e)
        {
            if (ContentAlignment == ContentAlignment.TopCenter)
                ContentAlignment = ContentAlignment.TopLeft;
            else
                ContentAlignment = ContentAlignment.TopCenter;
        }

        private void btnTextAlignRight_Click(object sender, EventArgs e)
        {
            if (ContentAlignment == ContentAlignment.TopRight)
                ContentAlignment = ContentAlignment.TopLeft;
            else
                ContentAlignment = ContentAlignment.TopRight;
        }
        #endregion

        #region ComboBox de FontFace
        protected virtual void cmbFontes_SelectedIndexChanged(object sender, EventArgs e) => FontSender = new Font(cmbFontes.Text, FontSize, FontStyle);

        private void FormLoad(object sender, EventArgs e)
        {
            new LoadFontTypes(ref cmbFontes, ref lista_fontFamily);
            cmbFontes.SelectedIndex = cmbFontes.Items.IndexOf("Open Sans");
        }

        #endregion

        private void lblDefinirParaTodasTeclas_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Kbtn)
                {
                    (c as Button).Font = new Font(cmbFontes.Text, FontSize, FontStyle);
                    (c as Button).TextAlign = ContentAlignment;
                    (c as Button).BackColor = Color;
                }
            }
        }

        #endregion Fim das fontes

        #region Carrega Teclado
        private void carregaTeclado()
        {
            picBoxKeyboardBackground.Image = CompartilhaObjetosUser.teclado.BackgroundImage;
            picBoxKeyboardBackground.SizeMode = (PictureBoxSizeMode)CompartilhaObjetosUser.teclado.BackgroundModeSize;
            foreach (Control tecla in this.Controls)
            {
                if (tecla is Kbtn)
                {
                    foreach (Keycaps keycap in CompartilhaObjetosUser.teclado.Keycaps)
                    {
                        if (tecla.Name.Equals(keycap.ID))
                        {
                            tecla.Font = keycap.Font;
                            tecla.BackColor = keycap.Color;
                            tecla.Text = keycap.Text;
                            break;
                        }
                    }
                }
            }
        }
        #endregion

        #region Salvamento e Carregamento teclados

        //private void btnLer_Click(object sender, EventArgs e)
        //{
        //    using (FileStream openarchive = new FileStream(Application.StartupPath + @"\" + Conexao.nome_usuario +".acr", FileMode.Open))
        //    {
        //        BinaryFormatter ofByteArrayToObject = new BinaryFormatter();
        //        colecao = (AcroniLibrary.FileInfo.Colecao)ofByteArrayToObject.Deserialize(openarchive);

        //    }

        //    pictureBox1.Image = colecao.collection[0].BackgroundImage;
        //    pictureBox1.SizeMode = (PictureBoxSizeMode)colecao.collection[0].BackgroundModeSize;
        //    foreach (Control control in this.Controls)
        //    {
        //        if (control is Kbtn)
        //        {
        //            foreach (Keycaps tecla in this.colecao.collection[0].Keycaps)
        //            {
        //                if (control.Name.Equals(tecla.ID))
        //                {
        //                    control.Name = tecla.ID;
        //                    control.Font = tecla.Font;
        //                    control.BackColor = tecla.Color;
        //                    control.Text = tecla.Text;
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //}

        //private async void btnSalvar_Click(object sender, EventArgs e)
        //{
        //    MessageBoxInput nameteclado = new MessageBoxInput("Insira o nome de seu teclado");
        //    this.Hide();
        //    nameteclado.ShowDialog();
        //    this.Show();
        //    while (nameteclado.Visible)
        //    if (!Compartilha.editKeyboard)
        //  saveTeclado();

        //    #endregion
        //}
        //private async void saveTeclado()
        //{
        //    if (!Compartilha.editKeyboard)
        //    {
        //        if (SetNames.teclado != null)
        //        {
        //            Galeria selectGaleria = new Galeria(true);
        //            selectGaleria.Show();
        //            while (selectGaleria.Visible)
        //            {
        //                await Task.Delay(100);
        //            }
        //            if (SetNames.colecao != null)
        //            {
        //                setPropriedadesTeclado();
        //            }
        //        }
        //    }
        //    else
        //    {
        //        foreach (AcroniLibrary.FileInfo.Colecao c in CompartilhaObjetosUser.user.userCollections)
        //        {
        //            if (Compartilha.colecao.Equals(c.collectionNome))
        //            {
        //                c.collection.Remove(CompartilhaObjetosUser.teclado);

        //            }
        //        }
        //        setPropriedadesTeclado();


        //    }


        //    MessageBox.Show("Teclado adicionado/salvo com sucesso!");
        //}
        private void setPropriedadesTeclado()
        {
            keyboard.Name = "FX-4370";
            if (Compartilha.editKeyboard)
                keyboard.NickName = CompartilhaObjetosUser.teclado.NickName;
            else
                keyboard.NickName = SetNames.teclado;
            keyboard.Material = "Madeira";
            keyboard.isMechanicalKeyboard = true;
            keyboard.hasRestPads = false;
            keyboard.BackgroundImage = picBoxKeyboardBackground.Image;
            keyboard.BackgroundModeSize = picBoxKeyboardBackground.SizeMode;
            keyboard.ID = "ID";
            keyboard.tipoTeclado = this.Name;
            foreach (Control tecla in this.Controls)
                if (tecla is Kbtn)
                {
                    {
                        keyboard.Keycaps.Add(new Keycaps { ID = tecla.Name, Text = tecla.Text, Font = tecla.Font, Color = tecla.BackColor });
                    }
                }
            if (!Compartilha.editKeyboard)
                foreach (AcroniLibrary.FileInfo.Colecao c in CompartilhaObjetosUser.user.userCollections)
                {
                    if (c.collectionNome.Equals(SetNames.colecao))
                    {
                        c.collection.Add(keyboard);
                        break;
                    }
                }
            MessageBox.Show("Teclado adicionado com sucesso!");
            #endregion
        }

        private List<PictureBox> iconsBoxes = new List<PictureBox>();

        //private void btnIcons_Click(object sender, EventArgs e)
        //{
        //    foreach (Control c in this.Controls)
        //        iconsBoxes.Add(iconsBoxes.Where(c.Name.Contains("picBoxIcon")).ToList());

        //    using (OpenFileDialog dlg = new OpenFileDialog())
        //    {
        //        dlg.Title = "Carregar ícone";
        //        dlg.Filter = "Arquivos de imagem |*.bmp; *.png; *.jpg";

        //        if (dlg.ShowDialog() == DialogResult.OK)
        //        {
        //            IconsQueue.AttPanel(Image.FromFile(dlg.FileName));
        //            foreach (PictureBox pb in iconsBoxes)
        //            {
        //                if (pb == null || pb.Image == null)
        //                    pb.Image = IconsQueue.Images.Peek();
        //            }
        //        }
        //    }
        //    foreach (AcroniLibrary.FileInfo.Colecao c in CompartilhaObjetosUser.user.userCollections)
        //        {
        //            if (c.collectionNome.Equals(Compartilha.colecao))
        //            {
        //                c.collection.Add(keyboard);
        //                break;
        //            }
        //        }
            
        //    using (FileStream savearchive = new FileStream(Application.StartupPath + @"\" + Conexao.nome_usuario + ".acr", FileMode.OpenOrCreate))
        //    {
        //        BinaryFormatter Serializer = new BinaryFormatter();
        //        Serializer.Serialize(savearchive, CompartilhaObjetosUser.user);
        //    }
        //}

        //private void btnVoltar_Click(object sender, EventArgs e)
        //{
        //    Galeria a = new Galeria(false);
        //    a.Show();
        //    Compartilha.editKeyboard = false;
        //    this.Close();
        //}
    }
}