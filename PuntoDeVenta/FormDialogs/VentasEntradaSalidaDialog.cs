using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Helpers;

namespace PuntoDeVenta.FormDialogs
{
    public partial class VentasEntradaSalidaDialog : Form
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IFormaPagoService _formaPagoService;
        private readonly IMovimientoService _movimientoService;
        public List<FormaPagoResponse> formasDePago = new List<FormaPagoResponse>();
        private int _idTipoMovimiento = 0;

        public VentasEntradaSalidaDialog(string texto, int idTipoMovimiento)
        {
            InitializeComponent();
            _formaPagoService = new FormaPagoService(_context);
            _movimientoService = new MovimientoService(_context);
            _ = GetAllFormaPago();

            this.Text = texto;
            txtDescripcion.Text = texto.ToString();
            _idTipoMovimiento = idTipoMovimiento;
        }

        public async Task GetAllFormaPago()
        {
            var response = await _formaPagoService.GetAll(true);

            if (response != null && response.success)
            {
                formasDePago = response!.response!;
                comboFormaPago.DataSource = formasDePago;
                comboFormaPago.DisplayMember = "Descripcion";
                comboFormaPago.ValueMember = "Id";
            }
        }

        public async Task InsertMovimiento()
        {
            var movimiento = new MovimientoRequest {
                Id = 0,
                Descripcion = txtDescripcion.Text,
                Fecha = DateTime.Now,
                Valor = (float)txtCantidad.Value,
                Cancelado = false,
                IdTipoMovimiento = _idTipoMovimiento,
                Entrada = _idTipoMovimiento == 1,
                Salida = _idTipoMovimiento == 2,
                IdUsuario = SessionHelper.IdUsuario,
                IdFormaPago = Convert.ToInt32(comboFormaPago.SelectedValue),
                IdTurno = SessionHelper.IdTurno
            };

            var response = await _movimientoService.Insert(movimiento);

            string toastTipo = response != null && response.success ? "SUCCESS" : "ERROR";
            ToastForm toast = new ToastForm(toastTipo, response!.message! ?? "Error", this.FindForm()!);
            toast.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _ = InsertMovimiento();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
