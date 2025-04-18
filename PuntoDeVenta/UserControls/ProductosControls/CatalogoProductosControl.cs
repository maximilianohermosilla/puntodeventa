using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Domain.Entities;
using System.ComponentModel;

namespace PuntoDeVenta.UserControls.ProductosControls
{
    public partial class CatalogoProductosControl : UserControl
    {

        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly IProductoService _productoService;
        private List<CategoriaProductoResponse> _categoriaProductos;
        private List<ProductoResponse> _productos;

        public CatalogoProductosControl(List<CategoriaProductoResponse> categoriaProductos)
        {
            _productoService = new ProductoService(_context);
            _categoriaProductos = categoriaProductos;
            InitializeComponent();
            SetearCategorias();
            GetAllProductos();
        }

        public void SetearCategorias()
        {
            comboCategoria.DataSource = _categoriaProductos;
            comboCategoria.DisplayMember = "Descripcion";
            comboCategoria.ValueMember = "Id";
        }

        public void SetearCategorias(List<CategoriaProductoResponse> categoriaProductos)
        {
            comboCategoria.DataSource = categoriaProductos;
            comboCategoria.DisplayMember = "Descripcion";
            comboCategoria.ValueMember = "Id";
        }

        public void SetearProductos(List<ProductoResponse> productos)
        {
            var listaProductos = productos.Select(x => new { x.Id, x.Codigo, x.Descripcion, x.PrecioCosto, x.PrecioPorMayor,
                x.Cantidad, x.CantidadMinima, x.FechaCreacion, x.Habilitado, 
                Categoria = x.CategoriaProducto != null ? x.CategoriaProducto!.Descripcion : "" })!.ToList();
            dvCatalogo.DataSource = listaProductos;
            dvCatalogo.Refresh();
            dvCatalogo.Invalidate();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            _ = GuardarProducto();
        }

        public async Task GetAllProductos()
        {
            try
            {
                var response = await _productoService.GetAll();

                if (response != null && response.success)
                {
                    _productos = (List<ProductoResponse>)response.response!;
                    SetearProductos(_productos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async Task GuardarProducto()
        {
            try
            {
                if (txtDescripcion.Text == "" || txtCodigo.Text == "")
                {
                    MessageBox.Show("Debe ingresar un código y nombre válido");
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

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
