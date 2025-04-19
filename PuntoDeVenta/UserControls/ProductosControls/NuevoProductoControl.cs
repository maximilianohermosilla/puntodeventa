using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.UserControls.ProductosControls
{
    public partial class NuevoProductoControl : UserControl
    {

        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly IProductoService _productoService;
        public List<CategoriaProductoResponse> _categoriaProductos;
        public ProductoResponse selectedProducto = new ProductoResponse();

        public NuevoProductoControl(List<CategoriaProductoResponse> categoriaProductos)
        {
            _productoService = new ProductoService(_context);
            _categoriaProductos = categoriaProductos;
            InitializeComponent();
        }

        public void SetearCategorias(List<CategoriaProductoResponse> categoriaProductos)
        {
            _categoriaProductos = categoriaProductos;
            categoriaProductos.Insert(0, new CategoriaProductoResponse { Id = 0, Descripcion = "-- Seleccionar Categoría --", Habilitado = true });
            comboCategoria.DataSource = categoriaProductos.Where(x => x.Habilitado).ToList();
            comboCategoria.DisplayMember = "Descripcion";
            comboCategoria.ValueMember = "Id";
            comboCategoria.Refresh();
            comboCategoria.Invalidate();
        }

        public void SetProducto(ProductoResponse producto)
        {
            selectedProducto = producto;
            txtCodigo.Text = selectedProducto.Codigo;
            txtDescripcion.Text = selectedProducto.Descripcion;
            comboCategoria.SelectedValue = producto.IdCategoriaProducto > 0 ? producto!.IdCategoriaProducto : 0;
            txtPrecioMayor.Value = (decimal)selectedProducto.PrecioPorMayor;
            txtPrecioVenta.Value = (decimal)selectedProducto.PrecioVenta;
            txtPrecioCosto.Value = (decimal)selectedProducto.PrecioCosto;
            txtCantidadMinima.Value = selectedProducto.CantidadMinima;
            txtCantidadActual.Value = selectedProducto.Cantidad;

            labelTitle.Text = producto.Id > 0 ? "MODIFICAR PRODUCTO" : "NUEVO PRODUCTO";
            checkInventario.Checked = producto.CantidadMinima > 0 || producto.Cantidad > 0;

            comboCategoria.Refresh();
            comboCategoria.Invalidate();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            _ = GuardarProducto();
        }

        public async Task GuardarProducto()
        {
            try
            {
                ResponseModel<ProductoResponse> response = new ResponseModel<ProductoResponse>();
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre válido");
                }
                else
                {
                    ProductoRequest producto = new ProductoRequest()
                    {
                        Id = selectedProducto.Id > 0 ? selectedProducto.Id : 0,
                        Codigo = txtCodigo.Text,
                        Descripcion = txtDescripcion.Text,
                        IdCategoriaProducto = Convert.ToInt32(comboCategoria.SelectedValue) > 0 ? Convert.ToInt32(comboCategoria.SelectedValue) : null,
                        PrecioPorMayor = Convert.ToInt32(txtPrecioMayor.Value),
                        PrecioVenta = Convert.ToInt32(txtPrecioVenta.Value),
                        PrecioCosto = Convert.ToInt32(txtPrecioCosto.Value),
                        CantidadMinima = checkInventario.Checked ? Convert.ToInt32(txtCantidadMinima.Value) : 0,
                        Cantidad = checkInventario.Checked ? Convert.ToInt32(txtCantidadActual.Value) : 0,
                    };

                    if(selectedProducto.Id > 0)
                    {
                        response = await _productoService.Update(producto);
                    }
                    else
                    {
                        response = await _productoService.Insert(producto);
                    }

                    if (response.success == true) 
                    {
                        SetProducto(new ProductoResponse());
                    }

                    string toastTipo = response.success ? "SUCCESS" : "ERROR";
                    ToastForm toast = new ToastForm(toastTipo, response.message);
                    toast.Show();
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
