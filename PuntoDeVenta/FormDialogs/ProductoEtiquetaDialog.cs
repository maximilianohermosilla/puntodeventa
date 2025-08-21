namespace PuntoDeVenta.FormDialogs
{
    public partial class ProductoEtiquetaDialog : Form
    {
        public ProductoEtiquetaDialog()
        {
            InitializeComponent();
            txtEtiqueta.TabIndex = 0;
            txtCantidad.TabIndex = 1;
            btnAceptar.TabIndex = 2;
            btnCancelar.TabIndex = 3;
        }
        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;

            if (numericUpDown != null)
            {
                numericUpDown.Select(0, numericUpDown.Text.Length);
            }
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
