using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniControls
{
    public partial class
        Colecao : Panel
    {
        int contColecao = 0;
        public Colecao()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lblColecao1NumTeclados);
            this.Controls.Add(this.lblColecao1);
            this.Controls.Add(this.colecao1);
            this.Controls.Add(this.btnEditarGaleria);
            this.Controls.Add(btnExcluirGaleria);
            this.Size = new System.Drawing.Size(910, 161);
            this.Name = "colecao" + contColecao;
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            this.lblColecao1NumTeclados.Location = new System.Drawing.Point((lblColecao1.Width + 10), 16);
            foreach (ControlTeclado teclado in Teclados_Colecoes.teclados)
            {
                colecao1.Controls.Add(teclado);
            }
            ellipse.ApplyElipse(this, 5);
            ellipse.ApplyElipse(colecao1, 5);
            contColecao++;
        }

    }
}

