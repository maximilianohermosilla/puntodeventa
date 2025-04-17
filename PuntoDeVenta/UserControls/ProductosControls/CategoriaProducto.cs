using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using System.ComponentModel;

namespace PuntoDeVenta.UserControls.ProductosControls
{
    public partial class CategoriaProducto : UserControl
    {
        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly ICategoriaProductoService _categoriaProductoService;
        public List<CategoriaProductoResponse> categoriaProductos = new List<CategoriaProductoResponse>();

        public CategoriaProducto()
        {
            //_categoriaProductoService = new CategoriaProductoService(_context);
            InitializeComponent();
            //_ = GetAllCategorias();
        }

        public async Task GetAllCategorias()
        {
            try
            {
                var response = await _categoriaProductoService.GetAll();

                if (response != null && response.success)
                {
                    categoriaProductos = (List<CategoriaProductoResponse>)response.response!;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    CategoriaProductoRequest productoRequest = new CategoriaProductoRequest()
                    {
                        Descripcion = txtDescripcion.Text,
                        Habilitado = checkHabilitado.Checked
                    };

                    var response = await _categoriaProductoService.Insert(productoRequest);

                    MessageBox.Show(response.message);

                    if (response != null && response.success)
                    {
                        categoriaProductos.Add((CategoriaProductoResponse)response.response!);
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
