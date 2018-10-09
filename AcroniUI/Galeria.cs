using AcroniControls;
using AcroniLibrary;
using AcroniLibrary.FileInfo;
using AcroniLibrary.SQL;
using AcroniUI.Custom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniUI
{
    public partial class Galeria : TemplateMenu
    {
        SelectColor selectColor;
        bool isSelectColorOpen = false;
        int countHeightCollection = 0;
        int countWidthKeyboard = 0;
        bool selectMode;

        public Galeria(bool selectMode)
        {
            InitializeComponent();

            this.pnlScroll.AutoScroll = true;
            WelcomeUser();
            this.selectMode = selectMode;

            if (selectMode)
            {
                lblBoasVindas.Visible = false;
                lblNomeUsuBoasVindas.Visible = false;
                lblSavedCollections1.Visible = false;
                lblColecoesSalvas2.Visible = false;
                lblCollectionsQuantity.Visible = false;
                lblSelectKeyboard.Visible = true;
            }

            //Para pegar as imagens
            Share.ResourcesImage.Add(Image.FromFile(Application.StartupPath + "\\" + "icon.png"));
            Share.ResourcesImage.Add(Image.FromFile(Application.StartupPath + "\\" + "icon2.png"));

            #region Aplicar redondinho


            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            ellipse.ApplyElipse(btnAdicionarGaleria, 4);


            #endregion

            LoadCollections();

            #region Adicionar evento de click ao btnEditarGaleria e btnExcluirGaleria

            foreach (Control collection in pnlScroll.Controls)
            {
                if (collection is CollectionUI)
                {
                    foreach (Control itemColecao in collection.Controls)
                    {
                        if (itemColecao.Name.Equals("btnEditarGaleria"))
                            itemColecao.Click += new EventHandler(Edit);
                        else if (itemColecao.Name.Equals("btnExcluirGaleria"))
                            itemColecao.Click += new EventHandler(Exclude);
                    }
                }
            }

            #endregion
        }
        public void WelcomeUser() => lblNomeUsuBoasVindas.Text = SQLConnection.nome_usuario + "!";

        #region Carregar Coleções

        private void LoadCollections()
        {
            using (FileStream openarchive = new FileStream(Application.StartupPath + @"\" + SQLConnection.nome_usuario + ".acr", FileMode.OpenOrCreate))
            {
                try
                {
                    BinaryFormatter ofByteArrayToObject = new BinaryFormatter();
                    Share.User = (User)ofByteArrayToObject.Deserialize(openarchive);
                }
                catch (Exception)
                {
                    Share.User = new User();
                }
            }

            int countCollections = 0;

            try
            {
                foreach (Collection userCollection in Share.User.UserCollections)
                {
                    foreach (Keyboard k in userCollection.Keyboards)
                    {
                        Share.KeyboardsQuantity++;
                        MessageBox.Show(k.NickName);
                        Share.Keyboard.NickName = k.NickName;
                        ControlKeyboard controlKeyboard = new ControlKeyboard();
                        controlKeyboard.Click += new EventHandler(OpenKeyboard);
                        controlKeyboard.ForeColor = SystemColors.Control;
                        controlKeyboard.Location = new Point(countWidthKeyboard += 13, 10);
                        ControlKeyboard_Collections.keyboardsControl.Add(controlKeyboard);
                        countWidthKeyboard += 83;
                    }

                    Share.Collection.CollectionColor = userCollection.CollectionColor;
                    Share.Collection.CollectionName = userCollection.CollectionName;

                    //Chama o controle de usuário
                    AcroniControls.CollectionUI collectionUi = new AcroniControls.CollectionUI();

                    if (selectMode)
                    {
                        collectionUi.Cursor = Cursors.Hand;
                        collectionUi.MouseEnter += new EventHandler(changeColor_MouseEnter);
                        collectionUi.MouseLeave += new EventHandler(returnColor_MouseLeave);
                    }

                    collectionUi.Click += new EventHandler(collectionUi_Click);
                    collectionUi.Location = new Point(16, 8 + countHeightCollection);
                    pnlScroll.Controls.Add(collectionUi);

                    Share.KeyboardsQuantity = 0;
                    Share.Collection.CollectionName = "";
                    Share.Keyboard.Name = "";
                    countWidthKeyboard = 0;
                    countCollections++;
                    countHeightCollection += 179;

                    ControlKeyboard_Collections.keyboardsControl = new List<ControlKeyboard>();
                }
            }

            catch (Exception er)
            {
                System.Windows.Forms.MessageBox.Show(er.Message);
            }

            lblCollectionsQuantity.Text = Convert.ToString(countCollections);
        }


        #endregion

        private void collectionUi_Click(object sender, EventArgs e)
        {
            if (selectMode)
            {
                Regex keyboardsQuantity = new Regex(@"• \d+ Teclados");
                foreach (Control items in (sender as Panel).Controls)
                {
                    if (!(keyboardsQuantity.IsMatch(items.Text)))
                    {
                        Share.Collection.CollectionName = items.Text;
                        Share.KeyboardsQuantity = 0;
                        this.Close();
                        break;
                    }

                }
            }
            else
            {

            }

        }
        private void changeColor_MouseEnter(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.FromArgb((sender as Panel).BackColor.A - 60, (sender as Panel).BackColor.R, (sender as Panel).BackColor.G, (sender as Panel).BackColor.B);
        }
        private void returnColor_MouseLeave(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.FromArgb((sender as Panel).BackColor.A + 60, (sender as Panel).BackColor.R, (sender as Panel).BackColor.G, (sender as Panel).BackColor.B);
        }

        private async void btnAdicionarGaleria_Click(object sender, EventArgs e)
        {
            AcroniMessageBoxInput collectionNameDialog = new AcroniMessageBoxInput("Insira o nome de sua coleção:");

            if (collectionNameDialog.ShowDialog() == DialogResult.Cancel)
                this.Close();

            while (collectionNameDialog.Visible)
            {
                await Task.Delay(10);
            }

            if (!string.IsNullOrEmpty(Share.Collection.CollectionName))
            {
                Collection newCollection = new Collection();

                newCollection.CollectionName = Share.Collection.CollectionName;
                newCollection.CollectionColor = Color.DimGray;

                Share.User.UserCollections.Add(newCollection);

                Share.Collection.CollectionName = newCollection.CollectionName;

                AcroniControls.CollectionUI collectionUi = new AcroniControls.CollectionUI();

                if (selectMode)
                {
                    collectionUi.Cursor = Cursors.Hand;
                    collectionUi.MouseEnter += new EventHandler(changeColor_MouseEnter);
                    collectionUi.MouseLeave += new EventHandler(returnColor_MouseLeave);
                }

                foreach (Control itemColecao in collectionUi.Controls)
                {
                    if (itemColecao.Name.Equals("btnEditarGaleria"))
                    {
                        itemColecao.Click += new EventHandler(Edit);
                    }
                    else if (itemColecao.Name.Equals("btnExcluirGaleria"))
                    {
                        itemColecao.Click += new EventHandler(Exclude);
                    }
                }

                collectionUi.Click += new EventHandler(collectionUi_Click);
                collectionUi.Location = new Point(16, 8 + countHeightCollection);
                countHeightCollection += 179;
                collectionUi.BackColor = newCollection.CollectionColor;
                pnlScroll.Controls.Add(collectionUi);
                SendToFile();
                lblCollectionsQuantity.Text = Convert.ToString(Convert.ToInt16(lblCollectionsQuantity.Text) + 1);
                Share.KeyboardsQuantity = 0;
                Share.Collection.CollectionName = "";
                Share.Keyboard.Name = "";
            }

        }

        private void SendToFile()
        {
            using (FileStream savearchive = new FileStream(Application.StartupPath + @"\" + SQLConnection.nome_usuario + ".acr", FileMode.OpenOrCreate))
            {
                BinaryFormatter objectToByteArray = new BinaryFormatter();
                objectToByteArray.Serialize(savearchive, Share.User);
            }
        }

        private void Exclude(object sender, EventArgs e)
        {
            foreach (Control c in ((sender as PictureBox).Parent as Panel).Controls)
            {
                if (c.Name.Equals("lblColecao1"))
                {
                    foreach (Collection collection in Share.User.UserCollections)
                    {
                        if (collection.CollectionName.Equals(c.Text))
                        {
                            Share.User.UserCollections.Remove(collection);
                            break;
                        }
                    }
                }

            }

            SendToFile();
            Galeria recharge = new Galeria(false);
            recharge.Show();
            this.Close();
        }

        private void OpenKeyboard(object sender, EventArgs e)
        {
            foreach (Control itemsGallery in (((sender as Button).Parent as Panel).Parent as Panel).Controls)
            {
                if (itemsGallery.Name.Equals("lblColecao1"))
                {
                    foreach (Collection keyBoardGallery in Share.User.UserCollections)
                    {
                        if (keyBoardGallery.CollectionName.Equals(itemsGallery.Text))
                        {
                            foreach (Keyboard keyboardToOpen in keyBoardGallery.Keyboards)
                            {
                                if (keyboardToOpen.NickName.Equals((sender as Button).Text))
                                {
                                    Share.Keyboard = keyboardToOpen;
                                    Form editarTeclado = null;
                                    Share.EditKeyboard = true;

                                    if (keyboardToOpen.KeyboardType.Equals("Compacto"))
                                        editarTeclado = new Compacto();
                                    else if (keyboardToOpen.KeyboardType.Equals("Tenkeyless"))
                                        editarTeclado = new Tenkeyless();
                                    else if (keyboardToOpen.KeyboardType.Equals(("FullSize")))
                                        editarTeclado = new Fullsize();

                                    Share.Collection.CollectionName = keyBoardGallery.CollectionName;
                                    editarTeclado.Show();
                                    this.Close();
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public async void Edit(object sender, EventArgs e)
        {
            if (isSelectColorOpen)
            {
                selectColor.Close();
                Share.Collection.CollectionColor = Color.Empty;
            }
            selectColor = new SelectColor();
            selectColor.Show();
            isSelectColorOpen = true;

            while (selectColor.Visible)
            {
                await Task.Delay(10);
                if (Share.Collection.CollectionColor != Color.Empty)
                    ((sender as PictureBox).Parent as Panel).BackColor = Share.Collection.CollectionColor;
            }

            if (Share.Collection.CollectionColor != Color.Empty)
            {
                foreach (Control c in ((sender as PictureBox).Parent as Panel).Controls)
                {
                    if (c.Name.Equals("lblColecao1"))
                    {
                        foreach (Collection collection in Share.User.UserCollections)
                        {
                            if (collection.CollectionName.Equals(c.Text))
                            {
                                collection.CollectionColor = Share.Collection.CollectionColor;
                                break;
                            }
                        }
                    }
                }

                Share.Collection.CollectionColor = Color.Empty;
                SendToFile();
            }

            isSelectColorOpen = false;
        }
    }
}