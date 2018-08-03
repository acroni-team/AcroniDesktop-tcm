using acroni.Forms.Customização;

namespace acroni.Forms.Seleção_do_teclado
{
    public partial class SelecionarTeclado : Layout_Master.LayoutMaster
    {
        public SelecionarTeclado()
        {
            InitializeComponent();
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
