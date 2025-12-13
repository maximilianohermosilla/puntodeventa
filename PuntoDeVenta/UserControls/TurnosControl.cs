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

        public TurnosControl()
        {
            _turnoService = new TurnoService(_context);
            InitializeComponent();
            InitializeControls();
        }

        public void InitializeControls()
        {
            turnoControl1 = new TurnosControls.TurnoControl();
            reporteTurnosControl1 = new TurnosControls.ReporteTurnosControl(this);

            panelMain.Controls.Add(turnoControl1);
            panelMain.Controls.Add(reporteTurnosControl1);

            turnoControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //turnoControl1.Dock = DockStyle.Fill;
            turnoControl1.Location = new Point(0, 0);
            turnoControl1.Name = "turnoControl1";
            turnoControl1.Size = new Size(319, 529);
            turnoControl1.TabIndex = 18;

            reporteTurnosControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reporteTurnosControl1.Dock = DockStyle.Fill;
            reporteTurnosControl1.Location = new Point(0, 0);
            reporteTurnosControl1.Size = new Size(1449, 508);
            reporteTurnosControl1.Name = "reporteTurnosControl1";
            reporteTurnosControl1.TabIndex = 19;

            turnoControl1.Visible = false;
            reporteTurnosControl1.Visible = false;

            _ = GetTurno();
        }

        public void SetActivePanel(UserControl? control)
        {
            turnoControl1.Visible = false;
            reporteTurnosControl1.Visible = false;

            if (control != null)
            {
                control.Visible = true;
            }

            //panelMain.Refresh();
            //this.Refresh();
        }

        public async Task GetTurno()
        {
            var ultimoTurno = await _turnoService.GetByIdUsuario(SessionHelper.IdUsuario, false);

            if (ultimoTurno != null && ultimoTurno.response != null)
            {
                _ = turnoControl1.SetearTurno(ultimoTurno.response);
            }
        }

        public async Task GetTurnoById(int idTurno)
        {
            var turno = await _turnoService.GetById(idTurno);

            if (turno != null && turno.response != null)
            {
                _ = turnoControl1.SetearTurno(turno.response);
                SetActivePanel(turnoControl1);
            }
        }

        private void btnTurnoActualCajero_Click(object sender, EventArgs e)
        {
            SetActivePanel(turnoControl1);
            _ = GetTurno();
        }

        private void btnReporteTurnos_Click(object sender, EventArgs e)
        {
            SetActivePanel(reporteTurnosControl1);
        }
    }
}
