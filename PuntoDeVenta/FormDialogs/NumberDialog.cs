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

        private void txtNumber_Enter(object sender, EventArgs e)
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

        private void NumberDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
