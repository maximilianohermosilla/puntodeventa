using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace PuntoDeVenta.UserControls.ReportesControls
{
    public partial class ReporteVentasControl : UserControl
    {
        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IProductoMovimientoService _productoMovimientoService;

        private List<ProductoMovimientoResponse> _productoMovimientos = new List<ProductoMovimientoResponse>();

        public ReporteVentasControl()
        {
            _productoMovimientoService = new ProductoMovimientoService(_context);
            InitializeComponent();
            _ = GetAllMovimientos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _ = GetAllMovimientos();
        }

        public async Task GetAllMovimientos()
        {
            try
            {
                var desde = new DateTime(dateDesde.Value.Year, dateDesde.Value.Month, dateDesde.Value.Day, 0, 0, 0);
                var hasta = new DateTime(dateHasta.Value.Year, dateHasta.Value.Month, dateHasta.Value.Day, 23, 59, 0);
                var response = await _productoMovimientoService.GetAllByFechaAndTipoMovimiento(desde, hasta, 1);

                if (response != null && response.success)
                {
                    _productoMovimientos = response.response!;
                    SetearMovimientos(_productoMovimientos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetearMovimientos(List<ProductoMovimientoResponse> movimientos)
        {
            if (movimientos != null && movimientos.Any())
            {
                var listaMovimientos = movimientos.Select(x => new
                {
                    x.Producto.Codigo,
                    Producto = x.Producto.Descripcion ?? "",
                    Categoria = x.Producto?.CategoriaProducto?.Descripcion ?? "",
                    x.Cantidad,
                    x.Valor,
                    TipoMovimiento = x.TipoMovimiento.Descripcion ?? "",
                    Usuario = x.Usuario.User ?? "",
                    x.Fecha
                })!.ToList();
                dvMovimientos.DataSource = listaMovimientos;
                dvMovimientos.Refresh();
                dvMovimientos.Invalidate();
                dvMovimientos.Visible = true;
                chart1.Visible = true;
                labelSinResultados.Visible = false;

                LoadChartData(movimientos);
            }
            else
            {
                dvMovimientos.Visible = false;
                chart1.Visible = false;
                labelSinResultados.Visible = true;
            }
        }
        private void LoadChartData(List<ProductoMovimientoResponse> movimientos)
        {
            var movimientosAgrupados = movimientos.GroupBy(mov => mov.Producto.Descripcion)
                .Select(m => new { Nombre = m.Key, Cantidad = m.Sum(item => item.Cantidad) }).ToList();

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            ChartArea chartArea1 = new ChartArea("Productos");
            chart1.ChartAreas.Add(chartArea1);

            int index = 0;
            foreach (var item in movimientosAgrupados)
            {
                Series series = new Series(item.Nombre);
                series.ChartType = SeriesChartType.Column;
                series.ChartArea = "Productos";
                series.Points.AddXY(item.Nombre, item.Cantidad);
                series.IsVisibleInLegend = true;
                chart1.Series.Add(series); 
                chart1.Legends.Add(new Legend(item.Nombre));
                chart1.Legends[item.Nombre].Docking = Docking.Bottom;

            }
            chart1.ChartAreas["Productos"].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas["Productos"].AxisX.Title = "Productos";
            chart1.ChartAreas["Productos"].AxisY.Title = "Cantidad";
            chart1.ChartAreas["Productos"].AxisX.Interval = 1;
            chart1.ChartAreas["Productos"].AxisX.MajorGrid.Enabled = true;
            chart1.ChartAreas["Productos"].AxisX.MajorTickMark.Enabled = true;

            chart1.Titles.Clear();
            chart1.Titles.Add("Productos");
        }
    }
}
