using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Domain.Entities;
using System.Windows.Forms;

namespace PuntoDeVenta.UserControls.ProductosControls
{
    public partial class CatalogoProductosControl : UserControl
    {

        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly IProductoService _productoService;
        private List<ProductoResponse> _productos = new List<ProductoResponse>();
        private UserControl _parent = null;
        private string _selectedId = "";
        public ProductoResponse selectedProducto = new ProductoResponse();

        public CatalogoProductosControl(List<CategoriaProductoResponse> categoriaProductos, UserControl parent)
        {
            _parent = parent;
            _productoService = new ProductoService(_context);
            InitializeComponent();
            _ = GetAllProductos();
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategoriaId = comboCategoria != null && comboCategoria.SelectedItem != null ? ((CategoriaProductoResponse)(comboCategoria.SelectedItem)).Id : 0;
            var productosFiltrados = _productos.Where(c => c.IdCategoriaProducto == selectedCategoriaId || selectedCategoriaId == 0).ToList();
            SetearProductos(productosFiltrados);
        }

        private void dvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectedId = dvCatalogo.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void dvCatalogo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idCliente = dvCatalogo.Rows[e.RowIndex].Cells[0].Value.ToString();
                ModificarProducto(_selectedId);
            }
            catch (Exception ex)
            {

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarProducto(_selectedId);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        public void ModificarProducto(string idCliente)
        {
            _ = ((UserControls.ProductosControl)_parent).ProcessEtiqueta(idCliente, false);
        }

        public void EliminarProducto()
        {
            if(DialogResult.Yes == MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                _ = ((UserControls.ProductosControl)_parent).ProcessEtiqueta(_selectedId, true);
                SetearProductos(_productos.Where(x => x.Id != Convert.ToInt32(_selectedId))!.ToList());
            }            
        }


        public void SetearCategorias(List<CategoriaProductoResponse> categoriaProductos)
        {
            comboCategoria.DataSource = categoriaProductos;
            comboCategoria.DisplayMember = "Descripcion";
            comboCategoria.ValueMember = "Id";
        }

        public void SetearProductos(List<ProductoResponse> productos)
        {
            var listaProductos = productos.Select(x => new
            {
                x.Id,
                x.Codigo,
                x.Descripcion,
                x.PrecioCosto,
                x.PrecioPorMayor,
                x.Cantidad,
                x.CantidadMinima,
                x.FechaCreacion,
                x.Habilitado,
                Categoria = x.CategoriaProducto != null ? x.CategoriaProducto!.Descripcion : ""
            })!.ToList();
            dvCatalogo.DataSource = listaProductos;
            dvCatalogo.Refresh();
            dvCatalogo.Invalidate();
        }

        public async Task GetAllProductos()
        {
            try
            {
                var response = await _productoService.GetAll(null);

                if (response != null && response.success)
                {
                    _productos = response.response!;
                    SetearProductos(_productos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task GuardarProducto()
        {
            try
            {
                if (txtDescripcion.Text == "" || txtCodigo.Text == "")
                {
                    MessageBox.Show("Debe ingresar un código y nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    MessageBox.Show(response.message, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
