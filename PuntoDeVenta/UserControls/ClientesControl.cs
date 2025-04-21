using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.UserControls
{
    public partial class ClientesControl : UserControl
    {
        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IClienteService _clienteService;
        public List<ClienteResponse> _clientes = new List<ClienteResponse>();
        public List<ClienteResponse> _clientesFiltrados = new List<ClienteResponse>();
        public ClienteResponse selectedCliente = new ClienteResponse();

        public ClientesControl()
        {
            _clienteService = new ClienteService(_context);
            InitializeComponent();
            _ = GetAllClientes();
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            _clientesFiltrados = _clientes.Where(c => c.Id == 0 ||
                                            (c.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()) || c.Apellido!.ToLower().Contains(txtBuscar.Text.ToLower()) || txtBuscar.Text == "")).ToList();
            SetearClientes(_clientesFiltrados);
        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listClientes != null && listClientes!.SelectedIndex > 0)
                {
                    selectedCliente = (ClienteResponse)listClientes!.SelectedItem!;
                    SetClienteSelected(selectedCliente);
                    labelTitleCliente.Text = "Editar Cliente";
                }
                else
                {
                    NuevoCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            _ = DeleteCliente(selectedCliente.Id);
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            _ = GuardarCliente();
        }

        public async Task GetAllClientes()
        {
            try
            {
                var response = await _clienteService.GetAll(null);

                if (response != null && response.success)
                {
                    _clientes = (response.response!);
                    _clientes.Insert(0, new ClienteResponse { Id = 0, Nombre = "-- Seleccionar Categoría --", Habilitado = true });
                    SetearClientes(response.response!);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetearClientes(List<ClienteResponse> clientes)
        {
            if (_clientes != null && _clientes.Count() == 0)
            {
                clientes.Insert(0, new ClienteResponse { Id = 0, Nombre = "-- Seleccionar Categoría --", Habilitado = true });
                _clientes = clientes;
            }

            _clientesFiltrados = clientes;
            listClientes.DataSource = null;
            listClientes.DataSource = _clientesFiltrados;
            listClientes.DisplayMember = "NombreApellido";
            listClientes.ValueMember = "Id";
            listClientes.Refresh();
            listClientes.Invalidate();
        }

        public void SetClienteSelected(ClienteResponse cliente)
        {
            selectedCliente = cliente;
            txtNombre.Text = selectedCliente!.Nombre;
            txtApellido.Text = selectedCliente!.Apellido;
            txtEmail.Text = selectedCliente!.Email;
            txtTelefono.Text = selectedCliente!.Telefono;
            checkHabilitado.Checked = selectedCliente!.Habilitado;
        }

        private async Task DeleteCliente(int id)
        {
            try
            {
                var response = await _clienteService.Delete(id);

                if (response.success)
                {
                    SetearClientes(_clientes.Where(x => x.Id != id)!.ToList());
                }

                string toastTipo = response.success ? "SUCCESS" : "ERROR";
                ToastForm toast = new ToastForm(toastTipo, response.message, this.FindForm());
                toast.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task GuardarCliente()
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ResponseModel<ClienteResponse> response = new ResponseModel<ClienteResponse>();

                    ClienteRequest clienteRequest = new ClienteRequest()
                    {
                        Id = selectedCliente.Id,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Email = txtEmail.Text,
                        Telefono = txtTelefono.Text,
                        Habilitado = checkHabilitado.Checked
                    };

                    if (selectedCliente.Id > 0)
                    {
                        var cliente = _clientes.Where(x => x.Id == selectedCliente.Id).FirstOrDefault();
                        cliente!.Id = selectedCliente.Id;
                        cliente!.Nombre = txtNombre.Text;
                        cliente!.Apellido = txtApellido.Text;
                        cliente!.Email = txtEmail.Text;
                        cliente!.Telefono = txtTelefono.Text;
                        cliente!.Habilitado = checkHabilitado.Checked;

                        response = await _clienteService.Update(clienteRequest);
                    }
                    else
                    {
                        response = await _clienteService.Insert(clienteRequest);
                        _clientes.Add(response.response!);
                    }

                    string toastTipo = response.success ? "SUCCESS" : "ERROR";
                    ToastForm toast = new ToastForm(toastTipo, response.message, this.FindForm());
                    toast.Show();
                    NuevoCliente();

                    if (response != null && response.success)
                    {
                        SetearClientes(_clientes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NuevoCliente()
        {
            listClientes!.SelectedIndex = 0;
            SetClienteSelected(new ClienteResponse() { Habilitado = true });
            labelTitleCliente.Text = "Nuevo Cliente";
        }
    }
}
