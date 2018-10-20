using System;
using System.Windows.Forms;
using System.Drawing;
using Transitions;
using AcroniControls;
using System.Collections.Generic;
using AcroniLibrary.CustomizingMethods.TextFonts;
using AcroniLibrary.FileInfo;
using AcroniUI.Custom.CustomModules;
using System.Threading.Tasks;
using System.IO;
using AcroniLibrary.SQL;
using System.Runtime.Serialization.Formatters.Binary;
using AcroniLibrary.Drawing;
using System.Drawing.Imaging;

namespace AcroniUI.Custom
{
    public partial class Compacto : Template
    {
        bool isBottomSelected, isUpperSelected, isLeftSelected, isCenterSelected, isRightSelected = false;
        #region Declarações 
        // Definição do botão de teclado genérico (kbtn)
        Label keybutton;

        // Definição das propriedades de salvamento
        //private bool SetKeyboardProperties;
        Keyboard keyboard = new Keyboard();
        Collection collection = new Collection();

        //Definição das propriedades das fontes
        ContentAlignment ContentAlignment { get; set; }
        private static List<FontFamily> lista_fontFamily = new List<FontFamily>();

        // Definição das propriedades do colorpicker 
        private Color Color { get; set; } = Color.FromArgb(26, 26, 26);
        private Color FontColor { get; set; } = Color.White;

        // Definição de PictureBox privada que conterá a imagem de fundo para aplicação do efeito de Blur.
        private PictureBox __PictureBox { get; set; }
        private Panel __pnl { get; set; }


        #endregion

        #region Eventos a nível do formulário

        //Ao clicar num botão do teclado
        private void kbtn_Click(object sender, EventArgs e)
        {
            keybutton = (Label)sender;

            if (btnStyleFontColor.Tag.Equals("true"))
                keybutton.ForeColor = FontColor;

            else
            {
                keybutton.BackColor = Color;

                if (Color != Color.FromArgb(26, 26, 26))
                {
                    //if (keybutton == Cb14sExtensao || keybutton == Cb14s)
                    //{
                    //    Cb14s.Parent.BackgroundImage = null;
                    //    Cb14sExtensao.Parent.BackgroundImage = null;
                    //}

                    //else 
                    //{
                    //    keybutton.Parent.BackgroundImage = null;
                    //    keybutton.Parent.BackColor = Color.FromArgb(90, keybutton.BackColor);
                    //}

                    keybutton.Parent.BackgroundImage = null;
                    keybutton.Parent.BackColor = Color.FromArgb(90, keybutton.BackColor);
                }

                else
                    keybutton.Parent.BackgroundImage = global::AcroniUI.Properties.Resources.keycapbackgrounddefault;
            }

            if (isUpperSelected)
            {
                if (isLeftSelected)
                    keybutton.TextAlign = ContentAlignment.TopLeft;
                if (isCenterSelected)
                    keybutton.TextAlign = ContentAlignment.TopCenter;
                if (isRightSelected)
                    keybutton.TextAlign = ContentAlignment.TopRight;
            }

            if (isBottomSelected)
            {
                if (isLeftSelected)
                    keybutton.TextAlign = ContentAlignment.BottomLeft;
                if (isCenterSelected)
                    keybutton.TextAlign = ContentAlignment.BottomCenter;
                if (isRightSelected)
                    keybutton.TextAlign = ContentAlignment.BottomRight;
            }


            if (btnOpenModuleTextIcons.Tag.Equals("true"))
            {
                KeycapTextIconModule ktm;
                if (keybutton.Name.Contains("Ca"))
                    ktm = new KeycapTextIconModule(false);
                else 
                    ktm = new KeycapTextIconModule(true);
                OpenModule(ktm);
                if (ktm.DialogResult == DialogResult.OK)
                {

                    if (!string.IsNullOrEmpty(ktm.Maintext) || !string.IsNullOrEmpty(ktm.Uppertext) || !string.IsNullOrEmpty(ktm.Bottomtext))
                    {
                        if (keybutton.Name.Contains("Ca"))
                            keybutton.Text = $"{ktm.Uppertext}\n{ktm.Maintext} {ktm.Bottomtext}";
                        else
                            keybutton.Text = ktm.Maintext;
                    }
                }

                if (KeycapTextIconModule.HasChosenAIcon)
                {
                    keybutton.Image = ktm.SelectedIcon;
                }
            }

            if (btnOpenModuleSwitch.Tag.Equals("true"))
            {
                KeycapSwitchModule ksm = new KeycapSwitchModule();
                OpenModule(ksm);
            }

            if (btnOpenModuleTexture.Tag.Equals("true"))
            {
                KeycapTextureModule ktm = new KeycapTextureModule();
                OpenModule(ktm);
            }

        }


        #region Método inicializador de módulos


        private void OpenModule(KeycapParentModule kpm)
        {
            GenerateDarkScreenshot();
            kpm.StartPosition = FormStartPosition.CenterScreen;
            kpm.FadeIn();
            kpm.ShowDialog(this);
            if (kpm.DialogResult == DialogResult.OK || kpm.DialogResult == DialogResult.Cancel)
                DisposePanel();
        }


        #endregion

        #endregion

        #region Métodos do darken form

        private Panel darkenPanel;
        // Tira uma screenshot do formulário e escurece-a.
        private void GenerateDarkScreenshot()
        {
            darkenPanel = new Panel();
            Bitmap bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), this.ClientRectangle.Size);
                double percent = 0.75;
                Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    G.FillRectangle(brsh, this.ClientRectangle);
                }
            }

            darkenPanel.Location = new Point(0, 0);
            darkenPanel.Size = this.ClientRectangle.Size;
            darkenPanel.BackgroundImage = bmp;
            this.Controls.Add(darkenPanel);
            darkenPanel.BringToFront();
        }

        private void DisposePanel() => darkenPanel.Dispose();

        #endregion

        #region btnVoltar
        //Ao clicar no botão de fechar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            SelectKeyboard __selectKeyboard = new SelectKeyboard();
            __selectKeyboard.ShowDialog();
            Share.EditKeyboard = false;
            this.Close();
        }

        private void btnVoltar_MouseMove(object sender, MouseEventArgs e)
        {
            btnVoltar.Font = new Font(btnVoltar.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            btnVoltar.Font = new Font(btnVoltar.Font, FontStyle.Bold);
        }
        #endregion

        #region Construtor
        public Compacto()
        {
            InitializeComponent();

            //Fazendo com que o label do nome do teclado tenha localização exatamente após o label que contém o nome da coleção.

            lblKeyboardName.Location = new Point(lblCollectionName.Location.X + lblCollectionName.Size.Width - 5, lblCollectionName.Location.Y);
            if (string.IsNullOrEmpty(Share.Keyboard.NickName))
            {
                lblKeyboardName.Text = KeyboardIDGenerator.GenerateID('C');
                lblCollectionName.Visible = false;
                lblKeyboardName.Location = lblCollectionName.Location;
            }
            else
            {
                lblKeyboardName.Text = Share.Keyboard.NickName;
                lblCollectionName.Text = Share.Collection.CollectionName;
            }

            //Eu preciso disso no construtor, sorry. Não dá pra colocar dois estilos na Open Sans logo no designer.

            btnStyleUnderline.Font = new Font(btnStyleUnderline.Font, FontStyle.Underline);
            btnStyleStrikeout.Font = new Font(btnStyleStrikeout.Font, FontStyle.Strikeout);


            Bunifu.Framework.UI.BunifuElipse be = new Bunifu.Framework.UI.BunifuElipse();
            be.ApplyElipse(pnlBtnStyleFontColor, 5);
            //Foreach para arredondar cores do colorpicker
            foreach (Control c in pnlBodyColorpicker.Controls)
            {
                if (c is Button)
                {
                    Bunifu.Framework.UI.BunifuElipse elipse = new Bunifu.Framework.UI.BunifuElipse();
                    elipse.ApplyElipse(c, 5);
                }
            }

            if (Share.EditKeyboard)
                LoadKeyboard();

        }
        #endregion

        #region Métodos do Color Picker

        private bool[] __IsSlotAvailable { get; set; } = { true, false, false, false };

        //Clicks que ocorrem ao selecionar uma cor
        private void btnColor_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            lblHexaColor.Text = $"#{b.BackColor.R.ToString("X2")}{b.BackColor.G.ToString("X2")}{b.BackColor.B.ToString("X2")}";

            if (btnStyleFontColor.Tag.Equals("true"))
                FontColor = b.BackColor;

            if (b.Tag.ToString().Contains("Ambar"))
                lblColorName.Text = "Âmbar";
            else if (b.Tag.ToString().Contains("_"))
                lblColorName.Text = b.Name.Replace("_", " ");
            else if (b.Tag.ToString().Contains("Preto"))
                lblColorName.Text = "Preto (cor padrão)";
            else
                lblColorName.Text = b.Name;

            //--Transição para mudar de cor
            Transition transition = new Transition(new TransitionType_EaseInEaseOut(200));
            transition.add(pnlChosenColor, "BackColor", b.BackColor);
            transition.run();

            //Define a cor da tecla no kbtn_Click
            Color = b.BackColor;

            if (__IsSlotAvailable[0])
            {
                btnHist1.Tag = b.Tag;
                lblColorName.Text = btnHist1.Tag.ToString();
                btnHist1.Visible = true;
                btnHist1.BackColor = b.BackColor;
                __IsSlotAvailable[0] = false;
                __IsSlotAvailable[1] = true;
            }

            else if (__IsSlotAvailable[1])
            {
                btnHist2.Tag = b.Tag;
                lblColorName.Text = btnHist2.Tag.ToString();
                btnHist2.Visible = true;
                btnHist2.BackColor = b.BackColor;
                __IsSlotAvailable[1] = false;
                __IsSlotAvailable[2] = true;
            }

            else if (__IsSlotAvailable[2])
            {
                btnHist3.Tag = b.Tag;
                lblColorName.Text = btnHist3.Tag.ToString();
                btnHist3.Visible = true;
                btnHist3.BackColor = b.BackColor;
                __IsSlotAvailable[2] = false;
                __IsSlotAvailable[3] = true;
            }

            else if (__IsSlotAvailable[3])
            {
                btnHist4.Tag = b.Tag;
                lblColorName.Text = btnHist4.Tag.ToString();
                btnHist4.Visible = true;
                btnHist4.BackColor = b.BackColor;
                __IsSlotAvailable[3] = false;
                __IsSlotAvailable[0] = true;
            }
        }

        private void ChangeColorFundoKbtn(object sender, PaintEventArgs e)
        {
            try
            {
                if (!keybutton.BackColor.Equals(Color.FromArgb(26, 26, 26)))
                {
                    Controls.Find("fundo" + keybutton.Name, true)[0].BackColor = Color.FromArgb(90, keybutton.BackColor);
                }
            }
            catch (Exception) { }
        }

        #region Hover para cada uma das cores do colorpicker


        private void btnColor_MouseLeave(object sender, EventArgs e)
        {
            Button btnColor = (Button)sender;
            btnColor.Size = new Size(btnColor.Size.Width - 5, btnColor.Size.Height - 5);
            btnColor.Location = new Point(btnColor.Location.X + (5 / 2), btnColor.Location.Y + (5 / 2));
            Bunifu.Framework.UI.BunifuElipse bunifuElipse = new Bunifu.Framework.UI.BunifuElipse();
            bunifuElipse.ApplyElipse(btnColor, 5);
        }

        private void btnColor_MouseEnter(object sender, EventArgs e)
        {
            Button btnColor = (Button)sender;
            btnColor.Size = new Size(btnColor.Size.Width + 5, btnColor.Size.Height + 5);
            btnColor.Location = new Point(btnColor.Location.X - (5 / 2), btnColor.Location.Y - (5 / 2));
            Bunifu.Framework.UI.BunifuElipse bunifuElipse = new Bunifu.Framework.UI.BunifuElipse();
            bunifuElipse.ApplyElipse(btnColor, 5);
        }

        #endregion

        #endregion

        #region Fontes das teclas e texto

        #region Definição dos métodos de alinhamento

        private void btnTextAlignLeft_Click(object sender, EventArgs e)
        {
            isLeftSelected = true;
            isCenterSelected = false;
            isRightSelected = false;
            btnTextAlignLeft.BackColor = Color.FromArgb(90, Color.Transparent);
            btnTextAlignCenter.BackColor = Color.Transparent;
            btnTextAlignRight.BackColor = Color.Transparent;
            ContentAlignment = ContentAlignment.TopLeft;
        }

        private void btnTextAlignCenter_Click(object sender, EventArgs e)
        {
            isLeftSelected = false;
            isCenterSelected = true;
            isRightSelected = false;
            btnTextAlignLeft.BackColor = Color.Transparent;
            btnTextAlignCenter.BackColor = Color.FromArgb(90, Color.Transparent);
            btnTextAlignRight.BackColor = Color.Transparent;
            if (ContentAlignment == ContentAlignment.TopCenter)
                ContentAlignment = ContentAlignment.TopLeft;
            else
                ContentAlignment = ContentAlignment.TopCenter;
        }

        private void btnTextAlignRight_Click(object sender, EventArgs e)
        {
            isLeftSelected = false;
            isCenterSelected = false;
            isRightSelected = true;
            btnTextAlignLeft.BackColor = Color.Transparent;
            btnTextAlignCenter.BackColor = Color.Transparent;
            btnTextAlignRight.BackColor = Color.FromArgb(90, Color.Transparent);
            if (ContentAlignment == ContentAlignment.TopRight)
                ContentAlignment = ContentAlignment.TopLeft;
            else
                ContentAlignment = ContentAlignment.TopRight;
        }
        #endregion

        //#region ComboBox de FontFace
        //protected virtual void cmbFontes_SelectedIndexChanged(object sender, EventArgs e) => FontSender = new Font(cmbFontes.Text, FontSize, FontStyle);

        private void FormLoad(object sender, EventArgs e)
        {
            FadeIn();

            //Carregar todas as fontes que o usuário possui na máquina
            new LoadFontTypes(ref cmbFontes, ref lista_fontFamily);

            //Index padrão da combobox
            cmbFontes.SelectedIndex = cmbFontes.Items.IndexOf("Open Sans");
        }

        private void lblDefinirParaTodasTeclas_Click(object sender, EventArgs e)
        {

        }

        #endregion Fim das fontes

        #region Controladores dos módulos e das cores dos botões de módulo.


        private void ApplyColorToModuleButton(Control c, bool isDeactivationNecessary)
        {
            if (isDeactivationNecessary == true || c != btnStyleFontColor)
            {
                foreach (Control btnOpenModule in pnlBtnOpenModules.Controls)
                {
                    if (!btnOpenModule.Tag.Equals("true"))
                    {
                        if (btnOpenModule != c)
                        {
                            btnOpenModule.BackColor = Color.FromArgb(31, 32, 34);
                            btnOpenModule.Tag = "false";
                        }
                        else
                        {
                            btnOpenModule.BackColor = Color.FromArgb(80, 80, 80);
                            btnOpenModule.Tag = "true";
                        }
                    }
                    else
                    {
                        btnOpenModule.BackColor = Color.FromArgb(31, 32, 34);
                        btnOpenModule.Tag = "false";
                    }
                }
            }
            else
            {
                if (!c.Tag.Equals("true"))
                {
                    c.BackColor = Color.FromArgb(80, 80, 80);
                    c.Tag = "true";
                }
                else
                {
                    c.BackColor = Color.FromArgb(31, 32, 34);
                    c.Tag = "false";
                }
            }
        }

        private void btnOpenModuleSwitch_Click(object sender, EventArgs e)
        {
            ApplyColorToModuleButton(btnOpenModuleSwitch, true);
        }

        private void btnStyleFontColor_Click(object sender, EventArgs e)
        {
            ApplyColorToModuleButton(btnStyleFontColor, false);
        }

        private void btnTextAndIcons_Click(object sender, EventArgs e)
        {
            ApplyColorToModuleButton(btnOpenModuleTextIcons, true);
        }

        private void btnOpenModuleBackground_Click(object sender, EventArgs e)
        {
            KeycapBackgroundModule kbm = new KeycapBackgroundModule();
            OpenModule(kbm);
        }

        private void btnOpenModuleTexture_Click(object sender, EventArgs e)
        {
            ApplyColorToModuleButton(btnOpenModuleTexture, true);
        }


        #endregion

        #region Carregar e salvar teclado
        private void LoadKeyboard()
        {
            picBoxKeyboardBackground.Image = Share.Keyboard.BackgroundImage;
            picBoxKeyboardBackground.SizeMode = (PictureBoxSizeMode)Share.Keyboard.BackgroundModeSize;

            foreach (Control keycap in pnlWithKeycaps.Controls)
            {
                if (keycap.Name.Contains("fundo"))
                {
                    foreach (Keycap k in Share.Keyboard.Keycaps)
                    {
                        if (("lbl"+keycap.Name.Remove(0,5)).Equals(k.ID))
                        {
                            try {
                                foreach (Control c in keycap.Controls)
                                {
                                    if (c.Name.Contains("lbl"))
                                    {
                                        c.ForeColor = k.ForeColor;
                                        (c as Label).Image = k.Icon;
                                        c.Font = k.Font;
                                        c.Text = k.Text;
                                        c.BackColor = k.Color;
                                        keycap.BackColor = Color.FromArgb(90, k.Color);
                                        (c as Label).TextAlign = (ContentAlignment) ContentAlignment;
                                    }
                                }
                                ////keycap.Text = k.Text;


                                break;
                            }catch(Exception) { }
                        }
                    }
                }
            }
        }

        //private void btnLer_Click(object sender, EventArgs e)
        //{
        //    using (FileStream openarchive = new FileStream(Application.StartupPath + @"\" + SQLConnection.nome_usuario + ".acr", FileMode.Open))
        //    {
        //        BinaryFormatter ofByteArrayToObject = new BinaryFormatter();
        //        collection = (Collection)ofByteArrayToObject.Deserialize(openarchive);
        //    }

        //    picBoxKeyboardBackground.Image = collection.Keyboards[0].BackgroundImage;

        //    picBoxKeyboardBackground.SizeMode = (PictureBoxSizeMode)collection.Keyboards[0].BackgroundModeSize;

        //    foreach (Control control in this.Controls)
        //    {
        //        if (control is Kbtn)
        //        {
        //            foreach (Keycap tecla in this.collection.Keyboards[0].Keycaps)
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

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Share.EditKeyboard)
            {
                AcroniMessageBoxInput keyboardName = new AcroniMessageBoxInput("Insira o nome de seu teclado");
                keyboardName.Show();
                while (keyboardName.Visible)
                {
                    await Task.Delay(100);
                }
            }
            SaveKeyboard();
            ExportToWebSite();
        }

        private async void SaveKeyboard()
        {
            if (!Share.EditKeyboard)
            {
                if (!String.IsNullOrEmpty(Share.KeyboardNameNotCreated))
                {
                    Galeria selectGallery = new Galeria(true);
                    selectGallery.Show();

                    while (selectGallery.Visible)
                    {
                        await Task.Delay(100);
                    }

                    if (!String.IsNullOrEmpty(Share.Collection.CollectionName))
                    {
                        setPropriedadesTeclado();
                    }
                }
            }

            else
            {
                foreach (Collection col in Share.User.UserCollections)
                {
                    if (Share.Collection.CollectionName.Equals(col.CollectionName))
                    {
                        col.Keyboards.Remove(Share.Keyboard);
                        setPropriedadesTeclado();
                        break;
                    }
                }

            }

            if ((!String.IsNullOrEmpty(Share.Collection.CollectionName) && !String.IsNullOrEmpty(Share.KeyboardNameNotCreated)) || Share.EditKeyboard)
            {
                System.Windows.MessageBox.Show("Teclado adicionado/salvo com sucesso!");
                Share.EditKeyboard = true;
                Share.Keyboard = keyboard;
                using (FileStream savearchive = new FileStream(Application.StartupPath + @"\" + SQLConnection.nome_usuario + ".acr", FileMode.OpenOrCreate))
                {
                    BinaryFormatter Serializer = new BinaryFormatter();
                    Serializer.Serialize(savearchive, Share.User);
                }
            }
            else
                MessageBox.Show("Teclado não foi salvo! Você ser lix");
        }

        private void setPropriedadesTeclado()
        {
            keyboard.Name = "FX-4370";
            keyboard.ID = KeyboardIDGenerator.GenerateID('C');
            if (!Share.EditKeyboard)
                keyboard.NickName = Share.KeyboardNameNotCreated;
            else
                keyboard.NickName = Share.Keyboard.NickName;
            keyboard.Material = "Madeira";
            keyboard.IsMechanicalKeyboard = true;
            keyboard.HasRestPads = false;
            keyboard.KeyboardType = this.Name;
            keyboard.BackgroundImage = picBoxKeyboardBackground.Image;
            keyboard.BackgroundModeSize = picBoxKeyboardBackground.SizeMode;
            string text = "";
            Color backcolor = Color.Empty;
            Color forecolor = Color.Empty;
            Font font = null;
            Image image = null;
            ContentAlignment textalign = ContentAlignment.TopLeft;
            string name = "";
            foreach (Control tecla in pnlWithKeycaps.Controls)
                if (tecla.Name.Contains("fundo"))
                {
                    {
                        foreach (Control c in tecla.Controls)
                        {
                            if (c.Name.Contains("lbl"))
                            {
                                image = (c as Label).Image;
                                text = c.Text;
                                forecolor = c.ForeColor;
                                font = c.Font;
                                backcolor = c.BackColor;
                                name = c.Name;
                                textalign = (c as Label).TextAlign;
                            }


                        }
                        keyboard.Keycaps.Add(new Keycap
                        {
                            ForeColor = forecolor,
                            ID = name,
                            //Text = tecla.Text,
                            Text = text,
                            Font = font,
                            Color = backcolor,
                            ContentAlignment = textalign,
                            Icon = image
                            //ContentAlignment = (tecla as Button).TextAlign
                        });
                    }
                }

            foreach (Collection col in Share.User.UserCollections)
            {
                if (col.CollectionName.Equals(Share.Collection.CollectionName))
                {
                    col.Keyboards.Add(keyboard);
                    break;
                }
            }

            using (FileStream savearchive = new FileStream(Application.StartupPath + @"\" + SQLConnection.nome_usuario + ".acr", FileMode.OpenOrCreate))
            {
                BinaryFormatter Serializer = new BinaryFormatter();
                Serializer.Serialize(savearchive, Share.User);
            }
        }

        #endregion

        #region Exportar pro site
        private void ExportToWebSite()
        {
            if (SQLMethods.INSERT_INTO($"insert into tblTecladoCustomizado (nickname, preco) values ('{keyboard.NickName}', 254.00)") != 0)
                MessageBox.Show("Fez");
            else
                MessageBox.Show("Não fez");
            byte[] img = ImageConvert.ImageToByteArray(Screenshot.TakeSnapshot(picBoxKeyboardBackground), ImageFormat.Bmp);
            //if (SQLMethods.INSERT_INTO($"insert into tblPedidosTecladoCustomizado values ((select top 1 id_teclado_customizado from tblTecladoCustomizado order by id_teclado_customizado DESC), @image)", img) != 0)
            //MessageBox.Show("Fez");
            //else
            //    MessageBox.Show("Não fez");
        }



        #endregion

        private void btnStyle_Click(object sender, EventArgs e)
        {

        }

        private void lblUpperBottom_Click(object sender, EventArgs e)
        {
            kbtn_Click(sender,e);
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            btnBottom.BackColor = Color.FromArgb(123, 123, 123);
            isUpperSelected = true;
            isBottomSelected = false;
            (sender as Button).BackColor = Color.FromArgb(90, (sender as Button).BackColor);
        }

        private void Compacto_MouseEnter(object sender, EventArgs e)
        {

        }
        private void btnBottom_Click(object sender, EventArgs e)
        {
            btnUpper.BackColor = Color.FromArgb(123, 123, 123);
            (sender as Button).BackColor = Color.FromArgb(90, (sender as Button).BackColor);
            isUpperSelected = false;
            isBottomSelected = true;
        }


    }
}

