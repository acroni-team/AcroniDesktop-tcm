using AcroniUI.CustomizingForms;

namespace AcroniUI
{
    public partial class SelectKeyboard : Master
    {
        public SelectKeyboard()
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
