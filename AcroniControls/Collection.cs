using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AcroniControls
{
    public partial class Collection : Panel
    {
        int countColecao = 0;
        Bitmap collectionsImages;
        SqlConnection conexao_SQL = new SqlConnection("Data Source = " + Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = ACRONI_SQL; User ID = Acroni; Password = acroni7");

        public Collection()
        {
            InitializeComponent();
            this.BackColor = Compartilha.collectionColor;
            this.Controls.Add(this.lblColecao1NumTeclados);
            this.Controls.Add(this.lblColecao1);
            this.Controls.Add(this.colecao1);
            this.Size = new System.Drawing.Size(910, 161);
            collectionsImages = new Bitmap(this.Width, this.Height);          
            this.Name = "colecao" + countColecao;
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            this.lblColecao1NumTeclados.Location = new System.Drawing.Point((lblColecao1.Width + 10), 16);
            foreach (ControlTeclado teclado in Teclados_Colecoes.teclados)
            {
                colecao1.Controls.Add(teclado);
            }
            ellipse.ApplyElipse(this, 5);
            ellipse.ApplyElipse(colecao1, 5);
            this.DrawToBitmap(collectionsImages, this.ClientRectangle);
            passarProBanco();
            this.Controls.Add(this.btnEditarGaleria);
            this.Controls.Add(btnExcluirGaleria);
            countColecao++;
        }

        private void passarProBanco()
        {
            byte[] img = null;
            img = (Byte[])new ImageConverter().ConvertTo(collectionsImages, typeof(Byte[]));
            conexao_SQL.Open();
            try {
                using (SqlCommand sqlCommand = new SqlCommand("insert into tblColecao values ('" + Compartilha.colecao + "',@img,(select email from tblCliente where usuario like '" + Compartilha.nomeUsu + "'))", conexao_SQL))
                {
                    sqlCommand.Parameters.AddWithValue("@img", img);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                using (SqlCommand sqlCommand = new SqlCommand("update tblColecao set imagem_colecao = @img where nick_colecao like '"+Compartilha.colecao+"'", conexao_SQL))
                {
                    sqlCommand.Parameters.AddWithValue("@img", img);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            conexao_SQL.Close();
        }

    }

}


