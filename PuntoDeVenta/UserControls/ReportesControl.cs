namespace PuntoDeVenta.UserControls
{
    public partial class ReportesControl : UserControl
    {
        public ReportesControl()
        {
            InitializeComponent();
        }

        public void InitializeControls()
        {
            reporteVentasControl1 = new ReportesControls.ReporteVentasControl();

            panelMain.Controls.Add(reporteVentasControl1);
            
            reporteVentasControl1.BackColor = SystemColors.ControlLight;
            reporteVentasControl1.Dock = DockStyle.Fill;
            reporteVentasControl1.Location = new Point(0, 0);
            reporteVentasControl1.Name = "reporteVentasControl1";
            reporteVentasControl1.Size = new Size(1458, 532);
            reporteVentasControl1.TabIndex = 18;

            SetActivePanel(reporteVentasControl1);
            _ = reporteVentasControl1.GetAllMovimientos();
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

        private void btnReporteDeVentas_Click(object sender, EventArgs e)
        {
            SetActivePanel(reporteVentasControl1);
            GetAllMovimientos();
        }

        public void GetAllMovimientos()
        {
            _ = reporteVentasControl1.GetAllMovimientos();
        }
    }
}
