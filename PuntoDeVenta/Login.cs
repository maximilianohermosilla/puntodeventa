namespace PuntoDeVenta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms[nameof(Main)] == null)
            {
                Main form = new Main();
                form.Show(this);
                this.Hide();
            }
            else
            {
                System.Windows.Forms.Application.OpenForms[nameof(Main)].Focus();
            }
        }
    }
}
