using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;


namespace PuntoDeVenta.UserControls
{
    public partial class ConfiguracionControl : UserControl
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IParametroService _parametroService;

        public ConfiguracionControl()
        {
            _parametroService = new ParametroService(_context);
            InitializeComponent();
        }

        private void btnMostrarOpciones_Click(object sender, EventArgs e)
        {
            _ = UploadImage();
        }

        private async Task UploadImage()
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog1.Title = "Select an Image File";

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

                        var response = await _parametroService.GetByClave("Logo");

                        if (response != null && response.success)
                        {
                            var parametroActualizar = new ParametroRequest() { Id = response!.response!.Id, Clave = response!.response!.Clave, Valor = fileName };
                            _ = _parametroService.Update(parametroActualizar);
                        }

                        MessageBox.Show("Imagen actualizada. Debe reiniciar la aplicación para confirmar los cambios", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error uploading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
