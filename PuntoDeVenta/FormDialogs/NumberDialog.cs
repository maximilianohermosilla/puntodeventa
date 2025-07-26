namespace PuntoDeVenta.FormDialogs
{
    public partial class NumberDialog : Form
    {
        public NumberDialog()
        {
            InitializeComponent();
            txtNumber.TabIndex = 0;
            btnAceptar.TabIndex = 1;
            btnCancelar.TabIndex = 2;
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
