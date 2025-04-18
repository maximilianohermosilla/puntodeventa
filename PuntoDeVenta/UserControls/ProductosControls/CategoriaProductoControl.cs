using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.UserControls.ProductosControls
{
    public partial class CategoriaProductoControl : UserControl
    {
        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly ICategoriaProductoService _categoriaProductoService;
        public List<CategoriaProductoResponse> _categoriaProductos;

        public CategoriaProductoControl(List<CategoriaProductoResponse> categoriaProductos)
        {
            _categoriaProductoService = new CategoriaProductoService(_context);
            _categoriaProductos = categoriaProductos;
            InitializeComponent();
            SetearCategorias();
        }

        public void SetearCategorias()
        {
            listCategorias.DataSource = _categoriaProductos;
            listCategorias.DisplayMember = "Descripcion";
            listCategorias.ValueMember = "Id";
        }

        public void SetearCategorias(List<CategoriaProductoResponse>  categoriaProductos)
        {
            _categoriaProductos = categoriaProductos;
            listCategorias.DataSource = null;
            listCategorias.DataSource = _categoriaProductos;
            listCategorias.DisplayMember = "Descripcion";
            listCategorias.ValueMember = "Id";
            listCategorias.Refresh();
            listCategorias.Invalidate();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            _ = GuardarCategoriaProducto();            
        }

        public async Task GuardarCategoriaProducto()
        {
            try
            {
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre válido");
                }
                else
                {
                    CategoriaProductoRequest productoRequest = new CategoriaProductoRequest()
                    {
                        Descripcion = txtDescripcion.Text,
                        Habilitado = checkHabilitado.Checked
                    };

                    var response = await _categoriaProductoService.Insert(productoRequest);

                    //MessageBox.Show(response.message);
                    string toastTipo = response.success ? "SUCCESS" : "ERROR";
                    ToastForm toast = new ToastForm(toastTipo, response.message);
                    toast.Show();

                    if (response != null && response.success)
                    {
                        _categoriaProductos.Add((CategoriaProductoResponse)response.response!);
                        SetearCategorias(_categoriaProductos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
