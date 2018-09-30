using AcroniUI.CustomizingForms;

namespace AcroniUI
{
    public partial class SelectKeyboard : TemplateMenu
    {
        public SelectKeyboard()
        {
            InitializeComponent();
        }

        #region Inicializar todos os tipos de teclados
        #endregion

        private void btnAbrirCompacto_Click(object sender, System.EventArgs e)
        {
            Compacto compacto = new Compacto();
            compacto.Show();
            this.Close();
        }
    }
}
