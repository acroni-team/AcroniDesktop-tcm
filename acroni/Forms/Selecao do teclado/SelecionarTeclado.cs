using acroni.Forms.Customização;
using System.Windows.Forms;

namespace acroni.Forms.Seleção_do_teclado
{
    public partial class SelecionarTeclado : Layout_Master.LayoutMaster
    {
        public SelecionarTeclado()
        {
            InitializeComponent();
            trocar_nome_usuario("Bem vindo, " + Classes_internas.Conexao.nome_usuario + "!");
            trocar_imagem_usuario(selecionar_imagem_cliente());
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
