using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Helpers;

namespace PuntoDeVenta.UserControls
{
    public partial class TurnosControl : UserControl
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly ITurnoService _turnoService;
        private readonly ITicketService _ticketService;
        private readonly IMovimientoService _movimientoService;
        private readonly IProductoMovimientoService _productoMovimientoService;

        public TurnosControl()
        {
            _turnoService = new TurnoService(_context);
            _ticketService = new TicketService(_context);
            _movimientoService = new MovimientoService(_context);
            _productoMovimientoService = new ProductoMovimientoService(_context);
            InitializeComponent();
            InitializeControls();
        }

        public void InitializeControls()
        {
            turnoControl = new TurnosControls.TurnoControl();

            panelMain.Controls.Add(turnoControl);

            turnoControl.Dock = DockStyle.Fill;
            turnoControl.Location = new Point(0, 0);
            turnoControl.Name = "turnoControl";
            turnoControl.Size = new Size(319, 529);
            turnoControl.TabIndex = 18;

            SetActivePanel(turnoControl);
            _ = GetTurno();
        }

        public void SetActivePanel(UserControl? control)
        {
            //nuevoProducto1.Visible = false;
            //categoriaProducto1.Visible = false;
            //catalogoProductos1.Visible = false;

            if (control != null)
            {
                control.Visible = true;
            }
        }

        public async Task GetTurno()
        {
            var ultimoTurno = await _turnoService.GetByIdUsuario(SessionHelper.IdUsuario, false);

            if (ultimoTurno != null && ultimoTurno.response != null)
            {
                SetActivePanel(turnoControl);
                _ = turnoControl.SetearTurno(ultimoTurno.response);
            }
        }

        private void btnTurnoActualCajero_Click(object sender, EventArgs e)
        {
            _ = GetTurno();
        }

        private void btnReporteTurnos_Click(object sender, EventArgs e)
        {

        }
    }
}
