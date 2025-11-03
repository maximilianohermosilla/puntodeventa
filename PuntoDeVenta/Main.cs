using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.FormDialogs;
using PuntoDeVenta.UserControls;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Main : Form
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly ITurnoService _turnoService;
        private readonly ITicketService _ticketService;
        private readonly IParametroService _parametroService;

        public int IdUsuario;
        public TurnoResponse turnoActual;

        public Main()
        {
            InitializeMain();
        }

        public Main(int idUsuario)
        {
            _turnoService = new TurnoService(_context);
            _ticketService = new TicketService(_context);
            _parametroService = new ParametroService(_context);
            IdUsuario = idUsuario;
            InitializeMain();
        }

        public void InitializeMain()
        {
            InitializeComponent();
            _ = GetUltimoTurno();
            _ = InitializeUserControlsMain();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            configuracion1.PictureChanged += configuracion1_PictureChanged;
            configuracion1.TextUpdateRequested += configuracion1_TextUpdateRequested;

            //SetAllControlsFont(this.Controls, new Font("Verdana", 8F, FontStyle.Regular));
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {            
            SetActivePanel(ventas1);
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            SetActivePanel(creditos1);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            SetActivePanel(productos1);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            SetActivePanel(inventario1);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SetActivePanel(clientes1);
            _ = clientes1.GetAllClientes();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            SetActivePanel(compras1);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            SetActivePanel(configuracion1);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            SetActivePanel(facturas1);
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            SetActivePanel(corte1);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SetActivePanel(reportes1);
            reportes1.InitializeControls();   
            reportes1.GetAllMovimientos();
        }

        public void SetActivePanel(UserControl control)
        {
            ventas1.Visible = false;
            reportes1.Visible = false;
            productos1.Visible = false;
            inventario1.Visible = false;
            facturas1.Visible = false;
            creditos1.Visible = false;
            corte1.Visible = false;
            configuracion1.Visible = false;
            compras1.Visible = false;
            clientes1.Visible = false;

            control.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDatetime.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private async Task InitializeUserControlsMain()
        {
            int idTurno = turnoActual != null ? turnoActual!.Id : 0;
            ventas1 = new VentasControl(idTurno);
            clientes1 = new ClientesControl();
            productos1 = new ProductosControl();
            inventario1 = new InventarioControl();
            reportes1 = new ReportesControl();
            facturas1 = new FacturasControl();
            creditos1 = new CreditosControl();
            corte1 = new CorteControl();
            configuracion1 = new ConfiguracionControl();
            compras1 = new ComprasControl();

            panelMain.Controls.Add(ventas1);
            panelMain.Controls.Add(clientes1);
            panelMain.Controls.Add(productos1);
            panelMain.Controls.Add(inventario1);
            panelMain.Controls.Add(reportes1);
            panelMain.Controls.Add(facturas1);
            panelMain.Controls.Add(creditos1);
            panelMain.Controls.Add(corte1);
            panelMain.Controls.Add(configuracion1);
            panelMain.Controls.Add(compras1);

            ventas1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ventas1.BackColor = Color.FromArgb(49, 66, 82);
            ventas1.BorderStyle = BorderStyle.FixedSingle;
            ventas1.Dock = DockStyle.Fill;
            ventas1.ForeColor = SystemColors.ButtonHighlight;
            ventas1.Location = new Point(0, 0);
            ventas1.Name = "ventas1";
            ventas1.Size = new Size(1295, 771);
            ventas1.TabIndex = 9;
       
            reportes1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reportes1.BackColor = Color.FromArgb(49, 66, 82);
            reportes1.BorderStyle = BorderStyle.FixedSingle;
            reportes1.Dock = DockStyle.Fill;
            reportes1.ForeColor = SystemColors.ButtonHighlight;
            reportes1.Location = new Point(0, 0);
            reportes1.Name = "reportes1";
            reportes1.Size = new Size(1295, 771);
            reportes1.TabIndex = 8;
      
            inventario1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            inventario1.BorderStyle = BorderStyle.FixedSingle;
            inventario1.Dock = DockStyle.Fill;
            inventario1.Location = new Point(0, 0);
            inventario1.Name = "inventario1";
            inventario1.Size = new Size(1295, 771);
            inventario1.TabIndex = 6;
     
            facturas1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            facturas1.BackColor = Color.FromArgb(49, 66, 82);
            facturas1.BorderStyle = BorderStyle.FixedSingle;
            facturas1.Dock = DockStyle.Fill;
            facturas1.ForeColor = SystemColors.ButtonHighlight;
            facturas1.Location = new Point(0, 0);
            facturas1.Name = "facturas1";
            facturas1.Size = new Size(1295, 771);
            facturas1.TabIndex = 5;
     
            creditos1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            creditos1.BackColor = Color.FromArgb(49, 66, 82);
            creditos1.BorderStyle = BorderStyle.FixedSingle;
            creditos1.Dock = DockStyle.Fill;
            creditos1.ForeColor = SystemColors.ButtonHighlight;
            creditos1.Location = new Point(0, 0);
            creditos1.Name = "creditos1";
            creditos1.Size = new Size(1295, 771);
            creditos1.TabIndex = 4;
  
            corte1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            corte1.BackColor = Color.FromArgb(49, 66, 82);
            corte1.BorderStyle = BorderStyle.FixedSingle;
            corte1.Dock = DockStyle.Fill;
            corte1.ForeColor = SystemColors.ButtonHighlight;
            corte1.Location = new Point(0, 0);
            corte1.Name = "corte1";
            corte1.Size = new Size(1295, 771);
            corte1.TabIndex = 3;
   
            configuracion1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            configuracion1.BackColor = Color.FromArgb(49, 66, 82);
            configuracion1.BorderStyle = BorderStyle.FixedSingle;
            configuracion1.Dock = DockStyle.Fill;
            configuracion1.ForeColor = SystemColors.ButtonHighlight;
            configuracion1.Location = new Point(0, 0);
            configuracion1.Name = "configuracion1";
            configuracion1.Size = new Size(1295, 771);
            configuracion1.TabIndex = 2;
         
            compras1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            compras1.BackColor = Color.FromArgb(49, 66, 82);
            compras1.Dock = DockStyle.Fill;
            compras1.ForeColor = SystemColors.ButtonHighlight;
            compras1.Location = new Point(0, 0);
            compras1.Name = "compras1";
            compras1.Size = new Size(1295, 771);
            compras1.TabIndex = 1;

            clientes1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clientes1.BackColor = Color.FromArgb(49, 66, 82);
            clientes1.Dock = DockStyle.Fill;
            clientes1.Location = new Point(0, 0);
            clientes1.Name = "clientes1";
            clientes1.Size = new Size(1295, 727);
            clientes1.TabIndex = 0;

            productos1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            productos1.BackColor = Color.FromArgb(49, 66, 82);
            productos1.Dock = DockStyle.Fill;
            productos1.Location = new Point(0, 0);
            productos1.Name = "productos1";
            productos1.Size = new Size(1295, 727);
            productos1.TabIndex = 9;

            pictureBoxLogo.ImageLocation = await GetParametroLogo();
            Text = await GetParametroNombre();
        }

        private void configuracion1_PictureChanged(object sender, Image newImage)
        {
            pictureBoxLogo.Image = newImage;
        }
        private void configuracion1_TextUpdateRequested(object sender, EventArgs e)
        {
            ConfiguracionControl userControl = sender as ConfiguracionControl;
            if (userControl != null)
            {
                Text = userControl.txtNombre.Text;
            }
        }

        public async Task<string> GetParametroLogo()
        {
            string path = Path.Combine(System.Windows.Forms.Application.StartupPath, "assets");
            string nombreLogo = "logo.png";
            try
            {
                var response = await _parametroService.GetByClave("Logo");
                if (response != null && response!.success)
                {
                    nombreLogo = response!.response!.Valor;
                }
            }
            catch (Exception ex)
            {
                nombreLogo = "logo.png";
            }

            return Path.Combine(path, nombreLogo);
        }

        public async Task<string> GetParametroNombre()
        {
            string nombreEmpresa = "PuntoDeVenta";
            try
            {
                var response = await _parametroService.GetByClave("NombreEmpresa");
                if (response != null && response!.success)
                {
                    nombreEmpresa = response!.response!.Valor;
                }
            }
            catch (Exception ex)
            {
                nombreEmpresa = "logo.png";
            }

            return nombreEmpresa;
        }

        private void SetAllControlsFont(Control.ControlCollection controls, Font newFont)
        {
            foreach (Control control in controls)
            {
                control.Font = newFont;

                if (control.HasChildren)
                {
                    SetAllControlsFont(control.Controls, newFont);
                }
            }
        }

        private async Task GetUltimoTurno()
        {
            try
            {
                var ultimoTurno = await _turnoService.GetByIdUsuario(IdUsuario, false);

                if(ultimoTurno != null && ultimoTurno.success)
                {
                    if (DialogResult.Yes == MessageBox.Show(@$"¿Desea reanudar el turno iniciado {ultimoTurno!.response!.FechaInicio.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    {
                        turnoActual = ultimoTurno!.response!;
                    }
                    else
                    {
                        turnoActual = ultimoTurno!.response!;
                        await FinalizarTurno();
                        await IniciarTurno();
                    }
                }
                else
                {
                    await IniciarTurno();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task IniciarTurno()
        {
            turnoActual = null;

            if (DialogResult.Yes == MessageBox.Show("¿Desea iniciar un nuevo turno?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                int cantidad = ObtenerCantidad();

                TurnoRequest turnoRequest = new TurnoRequest()
                {
                    CantidadInicio = cantidad,
                    CantidadFin = 0,
                    ValorTotal = 0,
                    ValorEfectivo = 0,
                    ValorTransferencia = 0,
                    ValorGanancia = 0,
                    Finalizado = false,
                    FechaInicio = DateTime.Now,
                    FechaFin = null,
                    IdUsuario = IdUsuario
                };

                var response = await _turnoService.Insert(turnoRequest);
                if (response != null && response.success)
                {
                    turnoActual = response!.response!;
                }
            }
        }

        private async Task FinalizarTurno()
        {
            try
            {
                int cantidad = ObtenerCantidad();
                var valorTotalTickets = await _ticketService.GetAllByIdTurno(turnoActual.Id);

                TurnoRequest turnoRequest = new TurnoRequest()
                {
                    Id = turnoActual.Id,
                    CantidadInicio = turnoActual.CantidadInicio,
                    CantidadFin = cantidad,
                    ValorTotal = valorTotalTickets != null && valorTotalTickets!.response != null 
                        ? valorTotalTickets!.response!.Select(t => t.PrecioTotal).Sum() : 0,
                    ValorEfectivo = valorTotalTickets != null && valorTotalTickets!.response != null 
                        ? valorTotalTickets!.response!.Where(t => t.IdFormaPago == 1).Select(t => t.PrecioTotal).Sum() : 0,
                    ValorTransferencia = valorTotalTickets != null && valorTotalTickets!.response != null 
                        ? valorTotalTickets!.response!.Where(t => t.IdFormaPago != 1).Select(t => t.PrecioTotal).Sum() : 0,
                    ValorGanancia = turnoActual.ValorGanancia,
                    Finalizado = true,
                    FechaInicio = turnoActual.FechaInicio,
                    FechaFin = DateTime.Now,
                    IdUsuario = IdUsuario
                };

                var response = await _turnoService.Update(turnoRequest);
                if (response != null && response.success)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerCantidad()
        {
            NumberDialog numberDialog = new NumberDialog();
            int cantidad = 1;

            try
            {
                if (numberDialog.ShowDialog(this) == DialogResult.OK)
                {
                    cantidad = (int)numberDialog.txtNumber.Value;
                    //int.TryParse(txtCantidad, out cantidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            numberDialog.Close();
            return cantidad;
        }
    }
}
