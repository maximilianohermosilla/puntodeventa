using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.UserControls.TurnosControls;


namespace PuntoDeVenta.UserControls
{
    public partial class ConfiguracionControl : UserControl
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IParametroService _parametroService;
        public delegate void PictureChangedEventHandler(object sender, Image newImage);
        public event PictureChangedEventHandler PictureChanged;
        public event EventHandler TextUpdateRequested;

        public ConfiguracionControl()
        {
            _parametroService = new ParametroService(_context);
            InitializeComponent();
            InitializeControls();
            _ = GetParametroNombre();
        }

        public void InitializeControls()
        {
            usuarioControl = new ConfiguracionControls.UsuariosControl();

            panelMain.Controls.Add(usuarioControl);

            usuarioControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            usuarioControl.Dock = DockStyle.Fill;
            usuarioControl.Location = new Point(0, 0);
            usuarioControl.Name = "usuarioControl";
            usuarioControl.Size = new Size(319, 529);
            usuarioControl.TabIndex = 1;

            usuarioControl.Visible = false;
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            SetActivePanel(null);
            panelGeneral.Visible = true;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SetActivePanel(usuarioControl);
        }

        public void SetActivePanel(UserControl? control)
        {
            usuarioControl.Visible = false;
            panelGeneral.Visible = false;

            if (control != null)
            {
                control.Visible = true;
            }

            panelMain.Refresh();
            this.Refresh();
        }


        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            _ = UploadImage();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _ = UpdateParametro("NombreEmpresa", txtNombre.Text);
            TextUpdateRequested?.Invoke(this, EventArgs.Empty);
        }

        private async Task UploadImage()
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog1.Title = "Seleccione un archivo de imágen";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string targetFolder = Path.Combine(System.Windows.Forms.Application.StartupPath, "assets");
                        if (!Directory.Exists(targetFolder))
                        {
                            Directory.CreateDirectory(targetFolder);
                        }

                        string fileName = Path.GetFileName(openFileDialog1.FileName);
                        string destinationPath = Path.Combine(targetFolder, fileName);
                        File.Copy(openFileDialog1.FileName, destinationPath, true);

                        await UpdateParametro("Logo", fileName);

                        PictureChanged?.Invoke(this, Image.FromFile(destinationPath));

                        MessageBox.Show("Imagen actualizada. Debe reiniciar la aplicación para confirmar los cambios", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error uploading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public async Task GetParametroNombre()
        {
            string nombreEmpresa = "PuntoDeVenta";
            try
            {
                var response = await _parametroService.GetByClave("NombreEmpresa");
                if (response != null && response!.success)
                {
                    nombreEmpresa = response!.response!.Valor;
                }
            }
            catch (Exception ex)
            {
                nombreEmpresa = "PuntoDeVenta";
            }

            txtNombre.Text = nombreEmpresa;
        }

        public async Task UpdateParametro(string clave, string valor)
        {
            try
            {
                var response = await _parametroService.GetByClave(clave);

                if (response != null && response.success)
                {
                    var parametroActualizar = new ParametroRequest() { Id = response!.response!.Id, Clave = response!.response!.Clave, Valor = valor };
                    _ = _parametroService.Update(parametroActualizar);
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
