using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using AcroniLibrary.FileInfo;

namespace AcroniControls
{
    public partial class CollectionUI : Panel
    {
        int countCollection = 0;
        Bitmap collectionsImages;
        SqlConnection sqlConnection = new SqlConnection("Data Source = " + Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = ACRONI_SQL; User ID = Acroni; Password = acroni7");

        public CollectionUI()
        {
            InitializeComponent();
            this.BackColor = Share.Collection.CollectionColor;
            this.Controls.Add(this.lblColecao1NumTeclados);
            this.Controls.Add(this.lblColecao1);
            this.Controls.Add(this.colecao1);
            this.Size = new System.Drawing.Size(910, 161);
            collectionsImages = new Bitmap(this.Width, this.Height);
            this.Name = "colecao" + countCollection;
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            this.lblColecao1NumTeclados.Location = new System.Drawing.Point((lblColecao1.Width + 10), 16);

            foreach (ControlKeyboard ck in ControlKeyboard_Collections.keyboardsControl)
            {
                colecao1.Controls.Add(ck);
            }

            ellipse.ApplyElipse(this, 5);
            ellipse.ApplyElipse(colecao1, 5);
            this.DrawToBitmap(collectionsImages, this.ClientRectangle);
            sendToDatabase();
            this.Controls.Add(this.btnEditarGaleria);
            this.Controls.Add(btnExcluirGaleria);
            countCollection++;
        }

        private void sendToDatabase()
        {
            byte[] img = null;
            img = (Byte[])new ImageConverter().ConvertTo(collectionsImages, typeof(Byte[]));
            sqlConnection.Open();
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("insert into tblColecao values ('" + Share.Collection.CollectionName + "',@img,(select email from tblCliente where usuario like '" + Share.User.UserName + "'))", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@img", img);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                using (SqlCommand sqlCommand = new SqlCommand("update tblColecao set imagem_colecao = @img where nick_colecao like '" + Share.Collection.CollectionName + "'", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@img", img);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            sqlConnection.Close();
        }

    }

}


