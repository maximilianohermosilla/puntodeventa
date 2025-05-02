using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using System.Data;

namespace PuntoDeVenta.UserControls.CommonControls
{
    public partial class NuevoClienteControl1 : UserControl
    {
        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IClienteService _clienteService;
        public ClienteResponse selectedCliente = new ClienteResponse();

        public NuevoClienteControl1()
        {
            _clienteService = new ClienteService(_context);
            InitializeComponent();
        }


        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            _ = GuardarCliente();
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
                        selectedCliente!.Id = selectedCliente.Id;
                        selectedCliente!.Nombre = txtNombre.Text;
                        selectedCliente!.Apellido = txtApellido.Text;
                        selectedCliente!.Email = txtEmail.Text;
                        selectedCliente!.Telefono = txtTelefono.Text;
                        selectedCliente!.Habilitado = checkHabilitado.Checked;

                        response = await _clienteService.Update(clienteRequest);
                    }
                    else
                    {
                        response = await _clienteService.Insert(clienteRequest);
                    }

                    string toastTipo = response.success ? "SUCCESS" : "ERROR";
                    ToastForm toast = new ToastForm(toastTipo, response.message, this.FindForm());
                    toast.Show();
                    NuevoCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NuevoCliente()
        {
            labelTitleCliente.Text = "Nuevo Cliente";
        }
    }
}
