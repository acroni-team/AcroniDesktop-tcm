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
        //SelectColor selectColor;
        //bool isSelectColorOpen = false;
        //int countHeightCollection = 0;
        //int countWidthKeyboard = 0;
        //bool selectMode;

        public Galeria(bool selectMode)
        {
            InitializeComponent();

            this.pnlScroll.AutoScroll = true;
            WelcomeUser();
            //this.selectMode = selectMode;
            if (selectMode)
            {
                lblBoasVindas.Visible = false;
                lblNomeUsuBoasVindas.Visible = false;
                lblSavedCollections1.Visible = false;
                lblColecoesSalvas2.Visible = false;
                lblCollectionsQuantity.Visible = false;
                lblSelectKeyboard.Visible = true;
            }

            //Compartilha.resourcesImg.Add(Image.FromFile(Application.StartupPath + "\\" + "icon.png"));
            //Compartilha.resourcesImg.Add(Image.FromFile(Application.StartupPath + "\\" + "icon2.png"));
            //Para pegar as imagens
            #region Aplicar redondinho
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            ellipse.ApplyElipse(btnAdicionarGaleria, 4);
            #endregion
            //CarregaColecoes();
            //#region Adicionar evento de click aos btnEditarGaleria e btnExcluirGaleria
            //foreach (Control collection in pnlScroll.Controls)
            //{
            //    if (collection is AcroniControls.Collection)
            //    {
            //        foreach (Control itemColecao in collection.Controls)
            //        {
            //            if (itemColecao.Name.Equals("btnEditarGaleria"))
            //                itemColecao.Click += new EventHandler(Editar);
            //            else if (itemColecao.Name.Equals("btnExcluirGaleria"))
            //                itemColecao.Click += new EventHandler(Excluir);
            //        }
            //    }
            //}

            //#endregion
        }
        public void WelcomeUser() => lblNomeUsuBoasVindas.Text = SQLConnection.nome_usuario + "!";

        //#region Carregar Coleções
        //private void CarregaColecoes()
        //{
        //    using (FileStream openarchive = new FileStream(Application.StartupPath + @"\" + SQLConnection.nome_usuario + ".acr", FileMode.OpenOrCreate))
        //    {
        //        try {
        //            BinaryFormatter ofByteArrayToObject = new BinaryFormatter();
        //            CompartilhaObjetosUser.user = (User)ofByteArrayToObject.Deserialize(openarchive);
        //        }
        //        catch (Exception) { CompartilhaObjetosUser.user = new User(); }
        //    }
        //    int contColecao = 0;
        //    try
        //    {
        //        foreach (AcroniLibrary.FileInfo.Colecao userCollection in CompartilhaObjetosUser.user.userCollections)
        //        {
        //            foreach (Teclado teclado in userCollection.collection)
        //            {
        //                Compartilha.numTeclados++;
        //                Compartilha.teclado = teclado.NickName;
        //                ControlTeclado controlTeclado = new ControlTeclado();
        //                controlTeclado.Click += new EventHandler(abrirTeclado);
        //                controlTeclado.ForeColor = SystemColors.Control;
        //                controlTeclado.Location = new Point(contWidthTeclado += 13, 10);
        //                Teclados_Colecoes.teclados.Add(controlTeclado);
        //                contWidthTeclado += 83;
        //            }
        //            Compartilha.collectionColor = userCollection.backColor;
        //            Compartilha.colecao = userCollection.collectionNome;
        //            AcroniControls.Collection collection = new AcroniControls.Collection();
        //            if (modeSelect)
        //            {
        //                collection.Cursor = Cursors.Hand;
        //                collection.MouseEnter += new EventHandler(changeColor_MouseEnter);
        //                collection.MouseLeave += new EventHandler(returnColor_MouseLeave);
        //            }
        //            collection.Click += new EventHandler(colecao_Click);
        //            collection.Location = new Point(16, 8 + contHeighColecao);
        //            pnlScroll.Controls.Add(collection);
        //            Compartilha.numTeclados = 0;
        //            Compartilha.colecao = "";
        //            Compartilha.teclado = "";
        //            contWidthTeclado = 0;
        //            contColecao++;
        //            contHeighColecao += 179;
        //            contWidthTeclado = 0;
        //            Teclados_Colecoes.teclados = new System.Collections.Generic.List<ControlTeclado>();
        //        }
        //    }
        //    catch (Exception er)
        //    {
        //        System.Windows.Forms.MessageBox.Show(er.Message);
        //    }
        //    lblCollectionsQuantity.Text = Convert.ToString(contColecao);
        //}


        //#endregion
        private void colecao_Click(object sender, EventArgs e)
        {
            //if (modeSelect)
            //{
            //    Regex qtdTeclados = new Regex(@"• \d+ Teclados");
            //    foreach (Control items in (sender as Panel).Controls)
            //    {
            //        if (!(qtdTeclados.IsMatch(items.Text)))
            //        {
            //            SetNames.colecao = items.Text;
            //            Compartilha.numTeclados = 0;
            //            this.Hide();
            //            break;
            //        }

            //    }
            //}
            //else
            //{

            //}

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
            //AcroniMessageBoxInput nameteclado = new AcroniMessageBoxInput("Insira o nome de sua coleção","");
            //nameteclado.Show();
            //while (nameteclado.Visible)
            //{
            //    await Task.Delay(100);
            //}
            //if (SetNames.colecao != "")
            //{
            //    AcroniLibrary.FileInfo.Colecao newCollection = new AcroniLibrary.FileInfo.Colecao();
            //    newCollection.collectionNome = SetNames.colecao;
            //    newCollection.backColor = Color.DimGray;
            //    CompartilhaObjetosUser.user.userCollections.Add(newCollection);
            //    Compartilha.colecao = SetNames.colecao;
            //    AcroniControls.Collection collection = new AcroniControls.Collection();
            //    if (modeSelect)
            //    {
            //        collection.Cursor = Cursors.Hand;
            //        collection.MouseEnter += new EventHandler(changeColor_MouseEnter);
            //        collection.MouseLeave += new EventHandler(returnColor_MouseLeave);
            //    }
            //    foreach (Control itemColecao in collection.Controls)
            //    {
            //        if (itemColecao.Name.Equals("btnEditarGaleria"))
            //        {
            //            itemColecao.Click += new EventHandler(Editar);
            //        }
            //        else if (itemColecao.Name.Equals("btnExcluirGaleria"))
            //        {
            //            itemColecao.Click += new EventHandler(Excluir);
            //        }
            //    }

            //    collection.Click += new EventHandler(colecao_Click);
            //    collection.Location = new Point(16, 8 + contHeighColecao);
            //    contHeighColecao += 179;
            //    pnlScroll.Controls.Add(collection);
            //    passarParaArquivo();
            //    lblCollectionsQuantity.Text = Convert.ToString(Convert.ToInt16(lblCollectionsQuantity.Text) + 1);
            //    Compartilha.numTeclados = 0;
            //    Compartilha.colecao = "";
            //    Compartilha.teclado = "";
            }

        //}
        //private void passarParaArquivo()
        //{
        //    using (FileStream savearchive = new FileStream(Application.StartupPath + @"\" + SQLConnection.nome_usuario + ".acr", FileMode.OpenOrCreate))
        //    {
        //        BinaryFormatter objectToByteArray = new BinaryFormatter();
        //        objectToByteArray.Serialize(savearchive, CompartilhaObjetosUser.user);
        //    }
        //}
        //private void Excluir(object sender, EventArgs e)
        //{
        //    foreach (Control c in ((sender as PictureBox).Parent as Panel).Controls)
        //    {
        //        if (c.Name.Equals("lblColecao1"))
        //        {
        //            foreach (AcroniLibrary.FileInfo.Colecao collection in CompartilhaObjetosUser.user.userCollections)
        //            {
        //                if (collection.collectionNome.Equals(c.Text))
        //                {
        //                    CompartilhaObjetosUser.user.userCollections.Remove(collection);
        //                    break;
        //                }
        //            }
        //        }

        //    }
        //    passarParaArquivo();
        //    Galeria recharge = new Galeria(false);
        //    recharge.Show();
        //    this.Close();
        //}
        //private void abrirTeclado(object sender, EventArgs e)
        //{
        //    foreach (Control itemsGaleria in (((sender as Button).Parent as Panel).Parent as Panel).Controls)
        //    {
        //        if (itemsGaleria.Name.Equals("lblColecao1"))
        //        {
        //            foreach (AcroniLibrary.FileInfo.Colecao tecladoGaleria in CompartilhaObjetosUser.user.userCollections)
        //            {
        //                if (tecladoGaleria.collectionNome.Equals(itemsGaleria.Text))
        //                {
        //                    foreach (Teclado tecladoToOpen in tecladoGaleria.collection)
        //                    {
        //                        if (tecladoToOpen.NickName.Equals((sender as Button).Text))
        //                        {
        //                            CompartilhaObjetosUser.teclado = tecladoToOpen;
        //                            Form editarTeclado = null;
        //                            Compartilha.editKeyboard = true;
        //                            if (tecladoToOpen.tipoTeclado.Equals("Compacto"))
        //                            {
        //                                editarTeclado = new Compacto();
        //                            }
        //                            else if (tecladoToOpen.tipoTeclado.Equals("Tenkeyless"))
        //                            {
        //                                editarTeclado = new Tenkeyless();
        //                            }
        //                            else if (tecladoToOpen.tipoTeclado.Equals(("FullSize")))
        //                            {
        //                                editarTeclado = new Fullsize();
        //                            }
        //                            Compartilha.colecao = tecladoGaleria.collectionNome;
        //                            editarTeclado.Show();
        //                            this.Close();
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
       
        //public async void Editar(object sender, EventArgs e)
        //{
        //    if (isSelectColorOpen)
        //    {
        //        selectColor.Close();
        //        Compartilha.colorSelected = Color.Empty;
        //    }
        //    selectColor = new SelectColor();
        //    selectColor.Show();
        //        isSelectColorOpen = true;
        //        while (selectColor.Visible)
        //        {
        //            await Task.Delay(10);
        //            if (Compartilha.colorSelected != Color.Empty)
        //                ((sender as PictureBox).Parent as Panel).BackColor = Compartilha.colorSelected;
              
        //        }
        //        if (Compartilha.colorSelected != Color.Empty)
        //        {
        //            foreach (Control c in ((sender as PictureBox).Parent as Panel).Controls)
        //            {
        //                if (c.Name.Equals("lblColecao1"))
        //                {
        //                    foreach (AcroniLibrary.FileInfo.Colecao collection in CompartilhaObjetosUser.user.userCollections)
        //                    {
        //                        if (collection.collectionNome.Equals(c.Text))
        //                        {
        //                            collection.backColor = Compartilha.colorSelected;
        //                            break;
        //                        }
        //                    }
        //                }
        //            }

        //            Compartilha.colorSelected = Color.Empty;
        //            passarParaArquivo();
        //        }
        //        isSelectColorOpen = false;
            
            

        //}
    }
}