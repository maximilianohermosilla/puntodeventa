using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Login : Form
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IParametroService _parametroService;
        private readonly IUsuarioService _usuarioService;

        public Login()
        {
            _parametroService = new ParametroService(_context);
            _usuarioService = new UsuarioService(_context);
            InitializeComponent();

            txtPassword.PasswordChar = '*';
            txtPassword.UseSystemPasswordChar = true;

            _ = GetParametroLogo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms[nameof(Main)] == null)
            {
                labelErrors.Visible = false;
                _ = LoginUser();
            }
            else
            {
                System.Windows.Forms.Application.OpenForms[nameof(Main)]!.Focus();
            }
        }

        private async Task LoginUser()
        {
            try
            {
                txtUser.Text = "admin";
                txtPassword.Text = "12345";
                var usuario = await _usuarioService.GetByUserAndPassword(txtUser.Text, txtPassword.Text);

                if (usuario != null == usuario!.success)
                {
                    Main form = new Main(1);
                    form.Show(this);
                    this.Hide();
                }
                else
                {
                    labelErrors.Text = "Credenciales incorrectas";
                    labelErrors.Visible = true;
                }
            }
            catch (Exception ex)
            {
                labelErrors.Text = ex.Message;
                labelErrors.Visible = true;
            }
        }

        public async Task GetParametroLogo()
        {
            string path = Path.Combine(System.Windows.Forms.Application.StartupPath, "assets");
            string nombreLogo = "logo.png";
            try
            {
                var response = await _parametroService.GetByClave("Logo");
                if (response != null && response!.success)
                {
                    nombreLogo = response!.response!.Valor;
                }
            }
            catch (Exception ex)
            {
                nombreLogo = "logo.png";
            }

            pictureBox1.ImageLocation = Path.Combine(path, nombreLogo);
        }

        private void txtPassword_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ = LoginUser();
            }
        }
    }
}
