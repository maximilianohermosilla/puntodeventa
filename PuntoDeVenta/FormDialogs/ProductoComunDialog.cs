namespace PuntoDeVenta.FormDialogs
{
    public partial class ProductoComunDialog : Form
    {
        public ProductoComunDialog()
        {
            InitializeComponent();
            txtDescripcion.TabIndex = 0;
            txtCantidad.TabIndex = 1;
            txtPrecio.TabIndex = 2;
            btnAceptar.TabIndex = 3;
            btnCancelar.TabIndex = 4;
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
