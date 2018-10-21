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

namespace AcroniControls
{
    public partial class CollectionUI : Panel
    {
        int countCollection = 0;
        Bitmap collectionsImages;
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
            bool alreadyExistsThisCollection = false;
            img = (Byte[])new ImageConverter().ConvertTo(collectionsImages, typeof(Byte[]));
            using (SqlConnection sqlConnection = new SqlConnection("Data Source = " + Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = ACRONI_SQL; User ID = Acroni; Password = acroni7"))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("select nick_colecao from tblColecao where id_cliente like (select id_cliente from tblCliente where usuario like '" + SQLConnection.nome_usuario + "')", sqlConnection))
                {
                    using (SqlDataReader return_value = sqlCommand.ExecuteReader())
                    {
                        if (return_value.HasRows)
                        {
                            return_value.Read();
                            for (int i=0;i< return_value.FieldCount;i++)
                                if (return_value[i].ToString().Equals(this.lblColecao1.Text))
                                {
                                    alreadyExistsThisCollection = true;
                                    break;
                                }
                        }
                    }
                }
                if (!alreadyExistsThisCollection)
                    using (SqlCommand sqlCommand = new SqlCommand("insert into tblColecao(nick_colecao,imagem_colecao,id_cliente) values ('" + Share.Collection.CollectionName + "',@img,(select id_cliente from tblCliente where usuario like '" + SQLConnection.nome_usuario + "'))", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@img", img);
                        sqlCommand.ExecuteNonQuery();
                    }

                else
                    using (SqlCommand sqlCommand = new SqlCommand("update tblColecao set imagem_colecao = @img where nick_colecao like '" + Share.Collection.CollectionName + "' and id_cliente like (select id_cliente from tblCliente where usuario like '" + SQLConnection.nome_usuario + "')", sqlConnection))
                    {

                        sqlCommand.Parameters.AddWithValue("@img", img);
                        sqlCommand.ExecuteNonQuery();
                    }

            }
        }
    }
}




