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
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[nameof(Main)] == null)
            {
                Main form = new Main();
                form.Show(this);
            }
            else
            {
                Application.OpenForms[nameof(Main)].Focus();
            }
        }
    }
}
