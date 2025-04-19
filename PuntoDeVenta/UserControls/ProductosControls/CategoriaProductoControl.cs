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
        public List<CategoriaProductoResponse> _categoriaProductosFiltradas = new List<CategoriaProductoResponse>();
        public CategoriaProductoResponse selectedCategoria = new CategoriaProductoResponse();

        public CategoriaProductoControl(List<CategoriaProductoResponse> categoriaProductos)
        {
            _categoriaProductoService = new CategoriaProductoService(_context);
            _categoriaProductos = categoriaProductos;
            InitializeComponent();
        }

        public void SetearCategorias(List<CategoriaProductoResponse> categoriaProductos)
        {
            if(_categoriaProductos != null && _categoriaProductos.Count() == 0)
            {
                _categoriaProductos = categoriaProductos;
            }

            _categoriaProductosFiltradas = categoriaProductos;  
            listCategorias.DataSource = null;
            listCategorias.DataSource = _categoriaProductosFiltradas;
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
                    ResponseModel<CategoriaProductoResponse> response = new ResponseModel<CategoriaProductoResponse>();

                    CategoriaProductoRequest productoRequest = new CategoriaProductoRequest()
                    {
                        Id = selectedCategoria.Id,
                        Descripcion = txtDescripcion.Text,
                        Habilitado = checkHabilitado.Checked
                    };

                    if (selectedCategoria.Id > 0)
                    {
                        var producto = _categoriaProductos.Where(x => x.Id == selectedCategoria.Id).FirstOrDefault();
                        producto!.Id = selectedCategoria.Id;
                        producto!.Descripcion = txtDescripcion.Text;
                        producto!.Habilitado = checkHabilitado.Checked;

                        response = await _categoriaProductoService.Update(productoRequest);
                    }
                    else
                    {
                        response = await _categoriaProductoService.Insert(productoRequest);
                        _categoriaProductos.Add(response.response!);
                    }

                    string toastTipo = response.success ? "SUCCESS" : "ERROR";
                    ToastForm toast = new ToastForm(toastTipo, response.message);
                    toast.Show();
                    NuevaCategoria();

                    if (response != null && response.success)
                    {
                        SetearCategorias(_categoriaProductos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void NuevaCategoria()
        {
            listCategorias!.SelectedIndex = 0;
            SetCategoriaSelected(new CategoriaProductoResponse() { Habilitado = true });
            labelCategoria.Text = "Nueva Categoría";
        }

        public void SetCategoriaSelected(CategoriaProductoResponse productoRequest)
        {
            selectedCategoria = productoRequest;
            txtDescripcion.Text = selectedCategoria!.Descripcion;
            checkHabilitado.Checked = selectedCategoria!.Habilitado;
        }
        private async Task DeleteCategoria(int id)
        {
            try
            {
                var response = await _categoriaProductoService.Delete(id);

                if (response.success)
                {
                    SetearCategorias(_categoriaProductos.Where(x => x.Id != id)!.ToList());
                }

                string toastTipo = response.success ? "SUCCESS" : "ERROR";
                ToastForm toast = new ToastForm(toastTipo, response.message);
                toast.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void listCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listCategorias != null && listCategorias!.SelectedIndex > 0)
                {
                    selectedCategoria = (CategoriaProductoResponse)listCategorias!.SelectedItem!;
                    SetCategoriaSelected(selectedCategoria);
                    labelCategoria.Text = "Editar Categoría";
                }
                else
                {
                    NuevaCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            NuevaCategoria();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            DeleteCategoria(selectedCategoria.Id);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            _categoriaProductosFiltradas = _categoriaProductos.Where(c => c.Id == 0 ||
                                            (c.Descripcion.ToLower().Contains(txtBuscar.Text.ToLower()) || txtBuscar.Text == "")).ToList();
            SetearCategorias(_categoriaProductosFiltradas);
        }
    }
}
