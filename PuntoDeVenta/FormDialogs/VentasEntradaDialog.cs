using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;

namespace PuntoDeVenta.FormDialogs
{
    public partial class VentasEntradaDialog : Form
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IProductoService _productoService;
        public string selectedProducto = string.Empty;

        public VentasEntradaDialog()
        {
            _productoService = new ProductoService(_context);

            InitializeComponent();
            txtDescripcion.TabIndex = 0;
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
