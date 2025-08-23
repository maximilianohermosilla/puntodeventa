using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.FormDialogs
{
    public partial class ProductoVerificadorDialog : Form
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IProductoService _productoService;

        public ProductoVerificadorDialog()
        {
            _productoService = new ProductoService(_context);

            InitializeComponent();
            txtEtiqueta.TabIndex = 0;
            btnCancelar.TabIndex = 1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected void txtEtiqueta_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                labelNombreProducto.Text = string.Empty;
                labelPrecioProducto.Text = string.Empty;
                _ = GetProductoByCodigo(txtEtiqueta.Text);
            }
        }

        public async Task GetProductoByCodigo(string codigo)
        {
            try
            {
                var response = await _productoService.GetByCodigo(codigo);

                if (response != null && response.success)
                {
                    labelNombreProducto.Text = response.response.Descripcion;
                    labelPrecioProducto.Text = $"$ {response.response.PrecioVenta}";
                }
                else
                {
                    labelNombreProducto.Text += $"Producto inexistente";
                    labelPrecioProducto.Text = "X";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            labelNombreProducto.Text = string.Empty;
            labelPrecioProducto.Text = string.Empty;
            _ = GetProductoByCodigo(txtEtiqueta.Text);
        }
    }
}
