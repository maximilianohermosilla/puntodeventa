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

        public Login()
        {
            _parametroService = new ParametroService(_context);
            InitializeComponent();
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
                Main form = new Main(1);
                form.Show(this);
                this.Hide();
            }
            else
            {
                System.Windows.Forms.Application.OpenForms[nameof(Main)].Focus();
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
    }
}
