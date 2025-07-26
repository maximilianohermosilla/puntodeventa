namespace PuntoDeVenta.FormDialogs
{
    public partial class ProductoComunDialog : Form
    {
        public ProductoComunDialog()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
