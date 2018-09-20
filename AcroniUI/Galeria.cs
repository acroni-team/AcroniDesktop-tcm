using AcroniControls;
using AcroniLibrary;
using AcroniLibrary.FileInfo;
using AcroniUI.CustomizingForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniUI
{
    public partial class Galeria : Master
    {

        int contHeighColecao = 0;
        int contWidthTeclado = 0;
        bool modeSelect;
        List<string> listaNomeCollection = new List<string>();
        public Galeria(bool modeSelect)
        {
            InitializeComponent();

            this.pnlScroll.AutoScroll = true;
            BoasVindas();
            this.modeSelect = modeSelect;
            if (modeSelect)
            {
                lblBoasVindas.Visible = false;
                lblNomeUsuBoasVindas.Visible = false;
                lblColecoesSalvas1.Visible = false;
                lblColecoesSalvas2.Visible = false;
                lblQtdColecoes.Visible = false;
                lblSelectKeyboard.Visible = true;
            }
            Compartilha.resourcesImg.Add(Image.FromFile(Application.StartupPath + "\\" + "icon.png"));
            Compartilha.resourcesImg.Add(Image.FromFile(Application.StartupPath + "\\" + "icon2.png"));
            //Para pegar as imagens
            #region Aplicar redondinho
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            ellipse.ApplyElipse(btnAdicionarGaleria, 4);
            #endregion
            CarregaColecoes();
            #region Adicionar evento de click aos btnEditarGaleria e btnExcluirGaleria
            foreach (Control collection in pnlScroll.Controls)
            {
                if (collection is AcroniControls.Colecao)
                {
                    foreach (Control itemColecao in collection.Controls)
                    {
                        if (itemColecao.Name.Equals("btnEditarGaleria"))
                            itemColecao.Click += new EventHandler(Editar);
                        else if (itemColecao.Name.Equals("btnExcluirGaleria"))
                            itemColecao.Click += new EventHandler(Excluir);
                    }
                }
            }

            #endregion
        }
        public void BoasVindas() => lblNomeUsuBoasVindas.Text = Conexao.nome_usuario + "!";
        #region Carregar Coleções
        private void CarregaColecoes()
        {
            using (FileStream openarchive = new FileStream(Application.StartupPath + @"\" + Conexao.nome_usuario + ".acr", FileMode.Open))
            {
                BinaryFormatter ofByteArrayToObject = new BinaryFormatter();
                CompartilhaObjetosUser.user = (User)ofByteArrayToObject.Deserialize(openarchive);
            }
            int contColecao = 0;
            try
            {
                foreach (AcroniLibrary.FileInfo.Colecao userCollection in CompartilhaObjetosUser.user.userCollections)
                {
                    foreach (Teclado teclado in userCollection.collection)
                    {
                        Compartilha.numTeclados++;
                        Compartilha.teclado = teclado.NickName;
                        ControlTeclado controlTeclado = new ControlTeclado();
                        controlTeclado.Click += new EventHandler(abrirTeclado);
                        controlTeclado.ForeColor = SystemColors.Control;
                        controlTeclado.Location = new Point(contWidthTeclado += 13, 10);
                        Teclados_Colecoes.teclados.Add(controlTeclado);
                        contWidthTeclado += 83;
                    }
                    Compartilha.colecao = userCollection.collectionNome;
                    AcroniControls.Colecao collection = new AcroniControls.Colecao();
                    if (modeSelect)
                    {
                        collection.Cursor = Cursors.Hand;
                        collection.MouseEnter += new EventHandler(changeColor_MouseEnter);
                        collection.MouseLeave += new EventHandler(returnColor_MouseLeave);
                    }
                    collection.Click += new EventHandler(colecao_Click);
                    collection.Location = new Point(16, 8 + contHeighColecao);
                    collection.BackColor = userCollection.backColor;
                    pnlScroll.Controls.Add(collection);
                    Compartilha.numTeclados = 0;
                    Compartilha.colecao = "";
                    Compartilha.teclado = "";
                    contWidthTeclado = 0;
                    contColecao++;
                    contHeighColecao += 179;
                    contWidthTeclado = 0;
                    Teclados_Colecoes.teclados = new System.Collections.Generic.List<ControlTeclado>();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            lblQtdColecoes.Text = Convert.ToString(contColecao);
        }


        #endregion
        private void colecao_Click(object sender, EventArgs e)
        {
            if (modeSelect)
            {
                Regex qtdTeclados = new Regex(@"• \d+ Teclados");
                foreach (Control items in (sender as Panel).Controls)
                {
                    if (!(qtdTeclados.IsMatch(items.Text)))
                    {
                        SetNames.colecao = items.Text;
                        Compartilha.numTeclados = 0;
                        this.Hide();
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

            MessageBoxInput nameteclado = new MessageBoxInput("Insira o nome de sua coleção");
            nameteclado.Show();
            while (nameteclado.Visible)
            {
                await Task.Delay(100);
            }
            if (SetNames.colecao != null)
            {
                AcroniLibrary.FileInfo.Colecao newCollection = new AcroniLibrary.FileInfo.Colecao();
                newCollection.collectionNome = SetNames.colecao;
                newCollection.backColor = Color.DimGray;
                CompartilhaObjetosUser.user.userCollections.Add(newCollection);
                Compartilha.colecao = SetNames.colecao;
                AcroniControls.Colecao collection = new AcroniControls.Colecao();
                if (modeSelect)
                {
                    collection.Cursor = Cursors.Hand;
                    collection.MouseEnter += new EventHandler(changeColor_MouseEnter);
                    collection.MouseLeave += new EventHandler(returnColor_MouseLeave);
                }
                foreach (Control itemColecao in collection.Controls)
                {
                    if (itemColecao.Name.Equals("btnEditarGaleria"))
                    {
                        itemColecao.Click += new EventHandler(Editar);
                    }
                    else if (itemColecao.Name.Equals("btnExcluirGaleria"))
                    {
                        itemColecao.Click += new EventHandler(Excluir);
                    }
                }

                collection.Click += new EventHandler(colecao_Click);
                collection.Location = new Point(16, 8 + contHeighColecao);
                contHeighColecao += 179;
                pnlScroll.Controls.Add(collection);
                passarParaArquivo();
                lblQtdColecoes.Text = Convert.ToString(Convert.ToInt16(lblQtdColecoes.Text) + 1);
                Compartilha.numTeclados = 0;
                Compartilha.colecao = "";
                Compartilha.teclado = "";
            }

        }
        private void passarParaArquivo()
        {
            using (FileStream savearchive = new FileStream(Application.StartupPath + @"\" + Conexao.nome_usuario + ".acr", FileMode.Open))
            {
                BinaryFormatter objectToByteArray = new BinaryFormatter();
                objectToByteArray.Serialize(savearchive, CompartilhaObjetosUser.user);
            }
        }
        private void Excluir(object sender, EventArgs e)
        {
            foreach (Control c in ((sender as PictureBox).Parent as Panel).Controls)
            {
                if (c.Name.Equals("lblColecao1"))
                {
                    foreach (AcroniLibrary.FileInfo.Colecao collection in CompartilhaObjetosUser.user.userCollections)
                    {
                        if (collection.collectionNome.Equals(c.Text))
                        {
                            CompartilhaObjetosUser.user.userCollections.Remove(collection);
                            break;
                        }
                    }
                }

            }
            passarParaArquivo();
            Galeria recharge = new Galeria(false);
            recharge.Show();
            this.Close();
        }
        private void abrirTeclado(object sender, EventArgs e)
        {
            foreach (Control itemsGaleria in (((sender as Button).Parent as Panel).Parent as Panel).Controls)
            {
                if (itemsGaleria.Name.Equals("lblColecao1"))
                {
                    foreach (AcroniLibrary.FileInfo.Colecao tecladoGaleria in CompartilhaObjetosUser.user.userCollections)
                    {
                        if (tecladoGaleria.collectionNome.Equals(itemsGaleria.Text))
                        {
                            foreach (Teclado tecladoToOpen in tecladoGaleria.collection)
                            {
                                if (tecladoToOpen.NickName.Equals((sender as Button).Text))
                                {
                                    CompartilhaObjetosUser.teclado = tecladoToOpen;
                                    Form editarTeclado = null;
                                    Compartilha.editKeyboard = true;
                                    if (tecladoToOpen.tipoTeclado.Equals("Compacto"))
                                    {
                                        editarTeclado = new Compacto();
                                    }
                                    else if (tecladoToOpen.tipoTeclado.Equals("Tenkeyless"))
                                    {
                                        editarTeclado = new Tenkeyless();
                                    }
                                    else if (tecladoToOpen.tipoTeclado.Equals(("FullSize")))
                                    {
                                        editarTeclado = new Fullsize();
                                    }
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
        public async void Editar(object sender, EventArgs e)
        {
            SelectColor selectColor = new SelectColor();
            selectColor.Show();
            while (selectColor.Visible)
            {
                await Task.Delay(100);
                if (Compartilha.colorSelected != Color.Empty)
                    ((sender as PictureBox).Parent as Panel).BackColor = Compartilha.colorSelected;
            }
            foreach (Control c in ((sender as PictureBox).Parent as Panel).Controls)
            {
                if (c.Name.Equals("lblColecao1"))
                {
                    foreach (AcroniLibrary.FileInfo.Colecao collection in CompartilhaObjetosUser.user.userCollections)
                    {
                        if (collection.collectionNome.Equals(c.Text))
                        {
                            collection.backColor = Compartilha.colorSelected;
                            break;
                        }
                    }
                }
            }
            Compartilha.colorSelected = Color.Empty;
            passarParaArquivo();

        }
    }
}