namespace PuntoDeVenta.FormDialogs
{
    public partial class FormaPagoDialog : Form
    {
        public int formaPago = 0;
        public FormaPagoDialog()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            formaPago = 1;
            this.DialogResult = DialogResult.OK;
        }

        private void btnMercadoPago_Click(object sender, EventArgs e)
        {
            formaPago = 5;
            this.DialogResult = DialogResult.OK;
        }

        private void FormaPagoDialog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)49)
            {
                formaPago = 1;
                this.DialogResult = DialogResult.OK;
            }

            else if (e.KeyChar == '2')
            {
                formaPago = 5;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FormaPagoDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                formaPago = 1;
                this.DialogResult = DialogResult.OK;
            }

            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                formaPago = 5;
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
