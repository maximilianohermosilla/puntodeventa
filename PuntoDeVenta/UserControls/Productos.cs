using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;

namespace PuntoDeVenta.UserControls
{
    public partial class Productos : UserControl
    {
        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly ICategoriaProductoService _categoriaProductoService;
        public List<CategoriaProductoResponse> categoriaProductos = new List<CategoriaProductoResponse>();

        public Productos()
        {
            _categoriaProductoService = new CategoriaProductoService(_context);
            InitializeComponent();
            _ = GetAllCategorias();
            SetActivePanel(nuevoProducto1);
        }

        public async Task GetAllCategorias()
        {
            try
            {
                var response = await _categoriaProductoService.GetAll();

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
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            SetActivePanel(nuevoProducto1);
            _ = GetAllCategorias();
            //nuevoProducto1.SetearCategorias(categoriaProductos);
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            SetActivePanel(null);
            EtiquetaDialog etiquetaDialog = new EtiquetaDialog();
            etiquetaDialog.labelProducto.Text = "Modificar Producto";

            if (etiquetaDialog.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show(etiquetaDialog.txtEtiqueta.Text);
            }
            etiquetaDialog.Dispose();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            SetActivePanel(null);
            EtiquetaDialog etiquetaDialog = new EtiquetaDialog();
            etiquetaDialog.labelProducto.Text = "Eliminar Producto";
            if (etiquetaDialog.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show(etiquetaDialog.txtEtiqueta.Text);
            }
            etiquetaDialog.Dispose();

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            _ = GetAllCategorias();
            SetActivePanel(categoriaProducto1);
            //categoriaProducto1 = new CategoriaProducto(categoriaProductos);
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
            _ = GetAllCategorias();

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
    }
}
