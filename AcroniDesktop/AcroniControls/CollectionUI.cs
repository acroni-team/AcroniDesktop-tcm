using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using AcroniLibrary.FileInfo;
using AcroniLibrary.SQL;
using AcroniLibrary.Drawing;
using System.Drawing.Imaging;

namespace AcroniControls
{
    public partial class CollectionUI : Panel
    {
        int countCollection = 0;
        public CollectionUI()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
            this.BackColor = Share.Collection.CollectionColor;
            this.Controls.Add(this.lblColecao1NumTeclados);
            this.Controls.Add(this.lblColecao1);
            this.Controls.Add(this.colecao1);
            this.Size = new System.Drawing.Size(910, 161);
            this.Name = "colecao" + countCollection;
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            this.lblColecao1NumTeclados.Location = new System.Drawing.Point((lblColecao1.Width + 10), 16);
            foreach (ControlKeyboard ck in ControlKeyboard_Collections.keyboardsControl)
            {
                colecao1.Controls.Add(ck);
            }

            ellipse.ApplyElipse(this, 5);
            ellipse.ApplyElipse(colecao1, 5);
            sendToDatabase();
            this.Controls.Add(this.btnEditarGaleria);
            this.Controls.Add(btnExcluirGaleria);
            countCollection++;
        }

        private void sendToDatabase()
        {
            Bitmap collectionPicture = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(collectionPicture, this.ClientRectangle);
            byte[] img = ImageConvert.ImageToByteArray(collectionPicture, ImageFormat.Bmp);
            bool alreadyExistsThisCollection = false;

            try
            {
                DataTable fetch = SQLProcMethods.SELECT_NicknameColecaoFrom(Share.User.ID);

                foreach (DataRow linha in fetch.Rows) {
                    if (linha[0].ToString().Equals(this.lblColecao1.Text))
                    {
                        alreadyExistsThisCollection = true;
                        break;
                    }
                }
                if (!alreadyExistsThisCollection)
                    SQLProcMethods.INSERT_Colecao(Share.User.ID, Share.Collection.CollectionName, img);
                else
                    SQLProcMethods.UPDATE_ImgColecao(img,Share.User.ID,Share.Collection.CollectionName);
            }
            catch (Exception)
            {
            }
        }
    }
}