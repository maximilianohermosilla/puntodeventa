using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;

namespace PuntoDeVenta.UserControls
{
    public partial class ProductosControl : UserControl
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly IProductoService _productoService;
        private readonly ICategoriaProductoService _categoriaProductoService;
        public List<CategoriaProductoResponse> categoriaProductos = new List<CategoriaProductoResponse>();

        public ProductosControl()
        {
            _productoService = new ProductoService(_context);
            _categoriaProductoService = new CategoriaProductoService(_context);
            InitializeComponent();
            _ = GetAllCategorias();
            SetActivePanel(nuevoProducto1);
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            SetActivePanel(nuevoProducto1);
            _ = GetAllCategorias();
            _ = nuevoProducto1.GetUnidades();
            nuevoProducto1.SetProducto(new ProductoResponse());
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            //SetActivePanel(null);
            ProductoEtiquetaDialog etiquetaDialog = new ProductoEtiquetaDialog();
            etiquetaDialog.labelProducto.Text = "Modificar Producto";

            try
            {
                if (etiquetaDialog.ShowDialog(this) == DialogResult.OK)
                {
                    _ = ProcessEtiqueta(etiquetaDialog.txtEtiqueta.Text, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            etiquetaDialog.Dispose();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //SetActivePanel(null);
            ProductoEtiquetaDialog etiquetaDialog = new ProductoEtiquetaDialog();
            etiquetaDialog.labelProducto.Text = "Eliminar Producto";

            try
            {
                if (etiquetaDialog.ShowDialog(this) == DialogResult.OK)
                {
                    _ = ProcessEtiqueta(etiquetaDialog.txtEtiqueta.Text, true);                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
            etiquetaDialog.Dispose();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            _ = GetAllCategorias();
            SetActivePanel(categoriaProducto1);
        }

        private void btnVentasPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            SetActivePanel(catalogoProductos1);
            _ = catalogoProductos1.GetAllProductos();

        }

        public void SetActivePanel(UserControl? control)
        {
            nuevoProducto1.Visible = false;
            categoriaProducto1.Visible = false;
            catalogoProductos1.Visible = false;


            if (control != null)
            {
                control.Visible = true;
            }
        }


        public async Task GetAllCategorias()
        {
            try
            {
                var response = await _categoriaProductoService.GetAll(null);

                if (response != null && response.success)
                {
                    categoriaProductos = (List<CategoriaProductoResponse>)response.response!;
                    nuevoProducto1.SetearCategorias(categoriaProductos);
                    categoriaProducto1.SetearCategorias(categoriaProductos);
                    catalogoProductos1.SetearCategorias(categoriaProductos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<ProductoResponse?> GetProductoById(int id)
        {
            try
            {
                var response = await _productoService.GetById(id);

                if (response != null && response.success)
                {
                    return response.response;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<ProductoResponse?> GetProductoByCodigo(string codigo)
        {
            try
            {
                var response = await _productoService.GetByCodigo(codigo);

                if (response != null && response.success)
                {
                    return response.response;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task ProcessEtiqueta(string codigo, bool eliminar)
        {
            try
            {
                if (!string.IsNullOrEmpty(codigo))
                {
                    var producto = await GetProductoByCodigo(codigo);

                    if (producto != null)
                    {
                        if (eliminar)
                        {
                            var response = await _productoService.Delete(producto.Id);
                            nuevoProducto1.SetProducto(new ProductoResponse());

                            string toastTipo = response.success ? "SUCCESS" : "ERROR";
                            ToastForm toast = new ToastForm(toastTipo, response.message!, this.FindForm()!);
                            toast.Show();
                        }
                        else
                        {
                            await GetAllCategorias();
                            nuevoProducto1.SetProducto(producto);
                            SetActivePanel(nuevoProducto1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //SetActivePanel(nuevoProducto1);
                }
                else
                {
                    MessageBox.Show("Debe ingresar un código válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
