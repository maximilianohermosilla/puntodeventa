using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.FormDialogs
{
    public partial class ClientesDialog : Form
    {
        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IClienteService _clienteService;
        public List<ClienteResponse> _clientes = new List<ClienteResponse>();
        public List<ClienteResponse> _clientesFiltrados = new List<ClienteResponse>();
        public ClienteResponse selectedCliente = new ClienteResponse();

        public ClientesDialog()
        {
            _clienteService = new ClienteService(_context);
            InitializeComponent();
            _ = GetAllClientes();
        }



        private void btnNuevoCliente_Click_1(object sender, EventArgs e)
        {
            if (selectedCliente != null)
            {
                selectedCliente.Id = 0;
            }
            panelMain.Visible = false;
            panelNewClient.Visible = true;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            SetClienteSelected(null);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelNewClient.Visible = false;
            panelMain.Visible = true;
        }

        private void btnGuardarCliente_Click_1(object sender, EventArgs e)
        {
            _ = GuardarCliente();
            panelNewClient.Visible = false;
            panelMain.Visible = true;
            this.DialogResult = DialogResult.OK;
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public async Task GetAllClientes()
        {
            try
            {
                var response = await _clienteService.GetAll(null);

                if (response != null && response.success)
                {
                    _clientes = (response.response!);
                    SetearClientes(response.response!);
                    SetClienteSelected(response!.response!.FirstOrDefault()!);
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
                        Id = 0,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Email = txtEmail.Text,
                        Telefono = txtTelefono.Text,
                        Habilitado = checkHabilitado.Checked
                    };

                    if (selectedCliente != null && selectedCliente.Id > 0)
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

                    //string toastTipo = response.success ? "SUCCESS" : "ERROR";
                    //ToastForm toast = new ToastForm(toastTipo, response.message!, this.FindForm()!);
                    //toast.Show();
                    //NuevoCliente();

                    if (response != null && response.success)
                    {
                        SetearClientes(_clientes);
                        SetClienteSelected(response.response!);
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
            //listClientes!.SelectedIndex = 0;
            SetClienteSelected(new ClienteResponse() { Habilitado = true });
        }
    }
}
