using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Enum;
using PuntoDeVenta.Helpers;
using System.Globalization;

namespace PuntoDeVenta.UserControls
{
    public partial class CorteControl : UserControl
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly ITurnoService _turnoService;
        private readonly ITicketService _ticketService;
        private readonly IMovimientoService _movimientoService;

        public CorteControl()
        {
            _turnoService = new TurnoService(_context);
            _ticketService = new TicketService(_context);
            _movimientoService = new MovimientoService(_context);
            InitializeComponent();
            _ = GetTurno();
        }

        public async Task GetTurno()
        {
            var ultimoTurno = await _turnoService.GetByIdUsuario(SessionHelper.IdUsuario, false);

            if (ultimoTurno != null && ultimoTurno.response != null)
            {
                _ = SetearTurno(ultimoTurno.response);
            }
        }

        public async Task SetearTurno(TurnoResponse turno)
        {
            try
            {
                var valorTotalTickets = await _ticketService.GetAllByIdTurno(turno.Id);
                var valorTotalMovimientos = await _movimientoService.GetAllByIdTurno(turno.Id);

                //EFECTIVO
                float valorVentasEfectivo = (valorTotalTickets != null && valorTotalTickets!.response != null
                        ? valorTotalTickets!.response!.Where(t => t.IdFormaPago == (int)FormaPagoEnum.Efectivo).Select(t => t.PrecioTotal).Sum() : 0);

                float valorEntradaEfectivo = (valorTotalMovimientos != null && valorTotalMovimientos!.response != null
                        ? valorTotalMovimientos!.response!.Where(t => t.IdTipoMovimiento == (int)TipoMovimientoEnum.Entrada && t.IdFormaPago == (int)FormaPagoEnum.Efectivo)
                        .Select(t => t.Valor).Sum() : 0);

                float valorSalidaEfectivo = (valorTotalMovimientos != null && valorTotalMovimientos!.response != null
                        ? valorTotalMovimientos!.response!.Where(t => t.IdTipoMovimiento == (int)TipoMovimientoEnum.Salida && t.IdFormaPago == (int)FormaPagoEnum.Efectivo)
                        .Select(t => t.Valor).Sum() : 0);

                //TRANSFERENCIA
                float valorVentasTransferencia = (valorTotalTickets != null && valorTotalTickets!.response != null
                        ? valorTotalTickets!.response!.Where(t => t.IdFormaPago != (int)FormaPagoEnum.Efectivo).Select(t => t.PrecioTotal).Sum() : 0);

                float valorEntradasTransferencia = (valorTotalMovimientos != null && valorTotalMovimientos!.response != null
                        ? valorTotalMovimientos!.response!.Where(t => t.IdTipoMovimiento == (int)TipoMovimientoEnum.Entrada && t.IdFormaPago != (int)FormaPagoEnum.Efectivo)
                        .Select(t => t.Valor).Sum() : 0);

                float valorSalidasTransferencia = (valorTotalMovimientos != null && valorTotalMovimientos!.response != null
                        ? valorTotalMovimientos!.response!.Where(t => t.IdTipoMovimiento == (int)TipoMovimientoEnum.Salida && t.IdFormaPago != (int)FormaPagoEnum.Efectivo)
                        .Select(t => t.Valor).Sum() : 0);

                //TOTAL
                float valorTotalEfectivo = valorVentasEfectivo + valorEntradaEfectivo - valorSalidaEfectivo;
                float valorTotalTransferencia = valorVentasTransferencia + valorEntradasTransferencia - valorSalidasTransferencia;

                //SETEO CAMPOS
                txtTurnoInicio.Text = turno.FechaInicio.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.CurrentCulture);

                txtVentasEfectivo.Text = "$ " + valorVentasEfectivo.ToString();
                txtVentasTransferencia.Text = "$ " + valorVentasTransferencia.ToString();
                txtVentasTotal.Text = "$ " + (valorVentasEfectivo + valorVentasTransferencia).ToString();

                txtEntradasEfectivo.Text = "$ " + valorEntradaEfectivo.ToString();
                txtEntradasTransferencia.Text = "$ " + valorEntradasTransferencia.ToString();
                txtEntradasTotal.Text = "$ " + (valorEntradaEfectivo + valorEntradasTransferencia).ToString();

                txtSalidasEfectivo.Text = "$ " + valorSalidaEfectivo.ToString();
                txtSalidasTransferencia.Text = "$ " + valorSalidasTransferencia.ToString();
                txtSalidasTotal.Text = "$ " + (valorSalidaEfectivo + valorSalidasTransferencia).ToString();

                txtTotalEfectivo.Text = "$ " + valorTotalEfectivo.ToString();
                txtTotalTransferencia.Text = "$ " + valorTotalTransferencia.ToString();
                txtTotalFinal.Text = "$ " + (valorTotalEfectivo + valorTotalTransferencia).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCorteCajero_Click(object sender, EventArgs e)
        {

        }
    }
}
