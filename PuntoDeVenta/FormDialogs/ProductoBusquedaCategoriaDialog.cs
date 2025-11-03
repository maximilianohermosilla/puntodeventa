using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;

namespace PuntoDeVenta.FormDialogs
{
    public partial class ProductoBusquedaCategoriaDialog : Form
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IProductoService _productoService;
        public string selectedProducto = string.Empty;

        public ProductoBusquedaCategoriaDialog()
        {
            _productoService = new ProductoService(_context);

            InitializeComponent();
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

        public void SetearCategorias(List<CategoriaProductoResponse> categoriaProductos)
        {
            comboCategoria.DisplayMember = "Descripcion";
            comboCategoria.ValueMember = "Id";
            comboCategoria.DataSource = categoriaProductos;
        }

        public async Task GetProductosByCategoria()
        {
            try
            {
                var response = await _productoService.GetAllByCategoria((int)comboCategoria!.SelectedValue!, null, true);

                if (response != null && response.success && response!.response!.Any())
                {
                    labelNotFound.Visible = false;
                    dvBusqueda.Visible = true;
                    SetearProductos((List<ProductoResponse>)response.response!);
                }
                else
                {
                    labelNotFound.Visible = true;
                    dvBusqueda.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SetearProductos(List<ProductoResponse> productos)
        {
            var listaProductos = productos.Select(x => new
            {
                x.Codigo,
                x.Descripcion,
                x.PrecioVenta,
                x.Cantidad,
                Unidad = x.Unidad != null ? x.Unidad!.Descripcion : "",
                Categoria = x.CategoriaProducto != null ? x.CategoriaProducto!.Descripcion : "",
                SubCategoria = x.SubCategoriaProducto != null ? x.SubCategoriaProducto!.Descripcion : "",
            })!.ToList();
            dvBusqueda.DataSource = listaProductos;
            dvBusqueda.Refresh();
            dvBusqueda.Invalidate();
        }

        private void dvBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProducto = dvBusqueda.Rows[e.RowIndex].Cells[0].Value.ToString()!;
            this.DialogResult = DialogResult.OK;
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = GetProductosByCategoria();
        }
    }
}
