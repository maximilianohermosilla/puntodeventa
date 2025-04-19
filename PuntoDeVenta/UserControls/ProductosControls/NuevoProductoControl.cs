using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;

namespace PuntoDeVenta.UserControls.ProductosControls
{
    public partial class NuevoProductoControl : UserControl
    {

        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly IProductoService _productoService;
        public List<CategoriaProductoResponse> _categoriaProductos;

        public NuevoProductoControl(List<CategoriaProductoResponse> categoriaProductos)
        {
            _productoService = new ProductoService(_context);
            _categoriaProductos = categoriaProductos;
            InitializeComponent();
        }

        public void SetearCategorias(List<CategoriaProductoResponse> categoriaProductos)
        {
            categoriaProductos.Insert(0, new CategoriaProductoResponse { Id = 0, Descripcion = "-- Seleccionar Categoría --" });
            comboCategoria.DataSource = categoriaProductos.Where(x => x.Habilitado).ToList();
            comboCategoria.DisplayMember = "Descripcion";
            comboCategoria.ValueMember = "Id";
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            _ = GuardarProducto();
        }

        public async Task GuardarProducto()
        {
            try
            {
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre válido");
                }
                else
                {
                    ProductoRequest producto = new ProductoRequest()
                    {
                        Codigo = txtCodigo.Text,
                        Descripcion = txtDescripcion.Text,
                        IdCategoriaProducto = Convert.ToInt32(comboCategoria.SelectedValue) > 0 ? Convert.ToInt32(comboCategoria.SelectedValue) : null,
                        PrecioPorMayor = Convert.ToInt32(txtPrecioMayor.Value),
                        PrecioVenta = Convert.ToInt32(txtPrecioVenta.Value),
                        PrecioCosto = Convert.ToInt32(txtPrecioCosto.Value),
                        CantidadMinima = checkInventario.Checked ? Convert.ToInt32(txtCantidadMinima.Value) : 0,
                        Cantidad = checkInventario.Checked ? Convert.ToInt32(txtCantidadActual.Value) : 0,
                    };

                    var response = await _productoService.Insert(producto);

                    MessageBox.Show(response.message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void checkInventario_CheckedChanged_1(object sender, EventArgs e)
        {
            txtCantidadActual.Enabled = checkInventario.Checked == true;
            txtCantidadMinima.Enabled = checkInventario.Checked == true;

        }
    }
}
