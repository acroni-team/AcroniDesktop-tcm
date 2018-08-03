using acroni.Forms.Customização;
<<<<<<< HEAD
using System.Windows.Forms;
=======
>>>>>>> 8a77b57f7efeb3af93650277e76aa1b2849fcdf3

namespace acroni.Forms.Seleção_do_teclado
{
    public partial class SelecionarTeclado : Layout_Master.LayoutMaster
    {
        public SelecionarTeclado()
        {
            InitializeComponent();
<<<<<<< HEAD
            trocar_nome_usuario("Bem vindo, " + Classes_internas.Conexao.nome_usuario + "!");
            trocar_imagem_usuario(selecionar_imagem_cliente());
=======
>>>>>>> 8a77b57f7efeb3af93650277e76aa1b2849fcdf3
        }

        #region Inicializar todos os tipos de teclados
        Compacto compacto = new Compacto();
        #endregion

        private void btnAbrirCompacto_Click(object sender, System.EventArgs e)
        {
            compacto.Show();
            this.Close();
        }
    }
}
