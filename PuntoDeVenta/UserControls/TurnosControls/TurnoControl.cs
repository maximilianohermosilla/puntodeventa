using System.Data;
using System.Globalization;
using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Enum;
using PuntoDeVenta.Helpers;

namespace PuntoDeVenta.UserControls.TurnosControls
{
    public partial class TurnoControl : UserControl
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly ITurnoService _turnoService;
        private readonly ITicketService _ticketService;
        private readonly IMovimientoService _movimientoService;
        private readonly IProductoMovimientoService _productoMovimientoService;

        public TurnoControl()
        {
            _turnoService = new TurnoService(_context);
            _ticketService = new TicketService(_context);
            _movimientoService = new MovimientoService(_context);
            _productoMovimientoService = new ProductoMovimientoService(_context);
            InitializeComponent();
        }

        public async Task GetTurno()
        {
            var ultimoTurno = await _turnoService.GetByIdUsuario(SessionHelper.IdUsuario, false);

            if (ultimoTurno != null && ultimoTurno.response != null)
            {
                _ = SetearTurno(ultimoTurno.response);
            }
        }

        //public async Task GetAllMovimientos()
        //{
        //    try
        //    {
        //        var desde = new DateTime(dateDesde.Value.Year, dateDesde.Value.Month, dateDesde.Value.Day, 0, 0, 0);
        //        var hasta = new DateTime(dateHasta.Value.Year, dateHasta.Value.Month, dateHasta.Value.Day, 23, 59, 0);
        //        var response = await _productoMovimientoService.GetAllByFechaAndTipoMovimiento(desde, hasta, (int)TipoMovimientoEnum.Salida);

        //        if (response != null && response.success)
        //        {
        //            _productoMovimientos = response.response!;
        //            SetearMovimientos(_productoMovimientos);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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

                txtVentasEfectivo.Text = valorVentasEfectivo.ToString("C2");
                txtVentasTransferencia.Text = valorVentasTransferencia.ToString("C2");
                txtVentasTotal.Text = (valorVentasEfectivo + valorVentasTransferencia).ToString("C2");

                txtEntradasEfectivo.Text = valorEntradaEfectivo.ToString("C2");
                txtEntradasTransferencia.Text = valorEntradasTransferencia.ToString("C2");
                txtEntradasTotal.Text = (valorEntradaEfectivo + valorEntradasTransferencia).ToString("C2");

                txtSalidasEfectivo.Text = valorSalidaEfectivo.ToString("C2");
                txtSalidasTransferencia.Text = valorSalidasTransferencia.ToString("C2");
                txtSalidasTotal.Text = (valorSalidaEfectivo + valorSalidasTransferencia).ToString("C2");

                txtTotalEfectivo.Text = valorTotalEfectivo.ToString("C2");
                txtTotalTransferencia.Text = valorTotalTransferencia.ToString("C2");
                txtTotalFinal.Text = (valorTotalEfectivo + valorTotalTransferencia).ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
