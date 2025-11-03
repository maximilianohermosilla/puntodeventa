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

        private readonly ISubCategoriaProductoService _subCategoriaProductoService;
        public List<SubCategoriaProductoResponse> _subCategoriaProductos;
        public List<SubCategoriaProductoResponse> _subCategoriaProductosFiltradas = new List<SubCategoriaProductoResponse>();
        public SubCategoriaProductoResponse selectedSubCategoria = new SubCategoriaProductoResponse();

        public CategoriaProductoControl(List<CategoriaProductoResponse> categoriaProductos)
        {
            _categoriaProductoService = new CategoriaProductoService(_context);
            _subCategoriaProductoService = new SubCategoriaProductoService(_context);
            _categoriaProductos = categoriaProductos;
            _subCategoriaProductos = new List<SubCategoriaProductoResponse>();
            InitializeComponent();
        }

        public void SetearCategorias(List<CategoriaProductoResponse> categoriaProductos)
        {
            if (_categoriaProductos != null && _categoriaProductos.Count() == 0)
            {
                _categoriaProductos = categoriaProductos;
            }

            comboCategoria.DataSource = categoriaProductos;
            comboCategoria.DisplayMember = "Descripcion";
            comboCategoria.ValueMember = "Id";

            _categoriaProductosFiltradas = categoriaProductos;
            listCategorias.DataSource = null;
            listCategorias.DataSource = _categoriaProductosFiltradas;
            listCategorias.DisplayMember = "Descripcion";
            listCategorias.ValueMember = "Id";
            listCategorias.Refresh();
            listCategorias.Invalidate();
        }

        public void SetearSubCategorias(List<SubCategoriaProductoResponse> subCategoriaProductos)
        {
            _subCategoriaProductos = subCategoriaProductos;
            _subCategoriaProductosFiltradas = subCategoriaProductos;
            listSubCategorias.DataSource = null;
            listSubCategorias.DataSource = _subCategoriaProductosFiltradas;
            listSubCategorias.DisplayMember = "Descripcion";
            listSubCategorias.ValueMember = "Id";
            listSubCategorias.Refresh();
            listSubCategorias.Invalidate();
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
                    MessageBox.Show("Debe ingresar un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ToastForm toast = new ToastForm(toastTipo, response.message!, this.FindForm()!);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NuevaCategoria()
        {
            listCategorias!.SelectedIndex = 0;
            SetCategoriaSelected(new CategoriaProductoResponse() { Habilitado = true });
            labelCategoria.Text = "Nueva Categoría";
        }

        public void SetCategoriaSelected(CategoriaProductoResponse categoria)
        {
            selectedCategoria = categoria;
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
                ToastForm toast = new ToastForm(toastTipo, response.message!, this.FindForm()!);
                toast.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    btnEliminarCategoria.Enabled = true;
                    comboCategoria.SelectedIndex = listCategorias!.SelectedIndex;
                    //selectedCategoria.SubCategoriaProductos.Insert(0, new SubCategoriaProductoResponse 
                    //    { Id = 0, Descripcion = "-- Seleccionar SubCategoría --", IdCategoriaProducto = selectedCategoria.Id, Habilitado = true }
                    //);
                    SetearSubCategorias((List<SubCategoriaProductoResponse>)(selectedCategoria.SubCategoriaProductos));
                }
                else
                {
                    btnEliminarCategoria.Enabled = false;
                    NuevaCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            NuevaCategoria();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                _ = DeleteCategoria(selectedCategoria.Id);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            _categoriaProductosFiltradas = _categoriaProductos.Where(c => c.Id == 0 ||
                                            (c.Descripcion.ToLower().Contains(txtBuscar.Text.ToLower()) || txtBuscar.Text == "")).ToList();
            SetearCategorias(_categoriaProductosFiltradas);
        }

        private void btnGuardarSubCategoria_Click(object sender, EventArgs e)
        {
            _ = GuardarSubCategoriaProducto();
        }

        private void listSubCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listSubCategorias != null && listSubCategorias!.SelectedIndex >= 0)
                {
                    selectedSubCategoria = (SubCategoriaProductoResponse)listSubCategorias!.SelectedItem!;
                    SetSubCategoriaSelected(selectedSubCategoria);
                    labelSubCategoria.Text = "Editar SubCategoría";
                    btnEliminarSubCategoria.Enabled = true;
                }
                else
                {
                    btnEliminarSubCategoria.Enabled = false;
                    NuevaSubCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevaSubCategoria_Click(object sender, EventArgs e)
        {
            NuevaSubCategoria();
        }

        private void btnEliminarSubCategoria_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro de que desea eliminar esta subcategoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                _ = DeleteSubCategoria(selectedSubCategoria.Id);
            }
        }

        public async Task GuardarSubCategoriaProducto()
        {
            try
            {
                if (txtDescripcionSubCategoria.Text == "" || comboCategoria.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe ingresar un nombre y categoría válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ResponseModel<SubCategoriaProductoResponse> response = new ResponseModel<SubCategoriaProductoResponse>();

                    SubCategoriaProductoRequest subCategoriaProductoRequest = new SubCategoriaProductoRequest()
                    {
                        Id = selectedSubCategoria.Id,
                        Descripcion = txtDescripcionSubCategoria.Text,
                        Habilitado = checkHabilitadoSubCategoria.Checked,
                        IdCategoriaProducto = comboCategoria.SelectedIndex
                    };

                    if (selectedSubCategoria.Id > 0)
                    {
                        var subCategoria = _subCategoriaProductos.Where(x => x.Id == selectedSubCategoria.Id).FirstOrDefault();
                        subCategoria!.Id = selectedSubCategoria.Id;
                        subCategoria!.Descripcion = txtDescripcionSubCategoria.Text;
                        subCategoria!.Habilitado = checkHabilitadoSubCategoria.Checked;

                        response = await _subCategoriaProductoService.Update(subCategoriaProductoRequest);
                    }
                    else
                    {
                        response = await _subCategoriaProductoService.Insert(subCategoriaProductoRequest);
                        _subCategoriaProductos.Add(response.response!);
                    }

                    string toastTipo = response.success ? "SUCCESS" : "ERROR";
                    ToastForm toast = new ToastForm(toastTipo, response.message!, this.FindForm()!);
                    toast.Show();
                    NuevaSubCategoria();

                    if (response != null && response.success)
                    {
                        SetearSubCategorias(_subCategoriaProductos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NuevaSubCategoria()
        {
            if (listSubCategorias != null && listSubCategorias.Items.Count > 0)
            {
                selectedSubCategoria = null;
                listSubCategorias!.SelectedIndex = -1;
                SetSubCategoriaSelected(new SubCategoriaProductoResponse() { Habilitado = true });
                labelSubCategoria.Text = "Nueva SubCategoría";
            }
        }

        public void SetSubCategoriaSelected(SubCategoriaProductoResponse subCategoria)
        {
            selectedSubCategoria = subCategoria;
            txtDescripcionSubCategoria.Text = selectedSubCategoria!.Descripcion;
            checkHabilitadoSubCategoria.Checked = selectedSubCategoria!.Habilitado;
        }

        private async Task DeleteSubCategoria(int id)
        {
            try
            {
                var response = await _subCategoriaProductoService.Delete(id);

                if (response.success)
                {
                    SetearSubCategorias(_subCategoriaProductos.Where(x => x.Id != id)!.ToList());
                }

                string toastTipo = response.success ? "SUCCESS" : "ERROR";
                ToastForm toast = new ToastForm(toastTipo, response.message!, this.FindForm()!);
                toast.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
