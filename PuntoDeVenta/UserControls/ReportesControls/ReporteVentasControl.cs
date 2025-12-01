using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Enum;
using PuntoDeVenta.Helpers;
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
                var response = await _productoMovimientoService.GetAllByFechaAndTipoMovimiento(desde, hasta, (int)TipoMovimientoEnum.Salida);

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
                    Codigo = x.Producto != null ? x.Producto!.Codigo : "",
                    Producto = x.Descripcion ?? "",
                    Categoria = x.Producto != null && x.Producto?.CategoriaProducto != null ? x.Producto?.CategoriaProducto?.Descripcion : "Producto Común",
                    x.Cantidad,
                    x.Valor,
                    FormaPago = x.FormaPago != null ? x.FormaPago.Descripcion : "",
                    TipoMovimiento = x.TipoMovimiento.Descripcion ?? "",
                    Usuario = x.Usuario.User ?? "",
                    x.Fecha
                })!.ToList();

                dvMovimientos.DataSource = null;
                dvMovimientos.DataSource = listaMovimientos;
                dvMovimientos.Refresh();
                dvMovimientos.Invalidate();

                dvMovimientos.Visible = true;
                chartCategorias.Visible = true;
                chartProductos.Visible = true;
                chartDias.Visible = true;
                labelSinResultados.Visible = false;
                labelTotal.Text = $"TOTAL: ${movimientos.Sum(p => p.Valor)}";
                labelTotal.Visible = true;

                LoadChartDataProductos(movimientos);
                LoadChartDataCategorias(movimientos);
                LoadChartDataDias(movimientos);
            }
            else
            {
                dvMovimientos.Visible = false;
                chartCategorias.Visible = false;
                chartProductos.Visible = false;
                chartDias.Visible = false;
                labelSinResultados.Visible = true;
                labelTotal.Visible = false;
            }
        }

        private void LoadChartDataProductos(List<ProductoMovimientoResponse> movimientos)
        {
            var movimientosAgrupados = movimientos.GroupBy(mov => mov.Descripcion)
                .Select(m => new ChartResponse { Nombre = m.Key!, Cantidad = m.Sum(item => item.Cantidad) }).ToList();

            chartCategorias.Series.Clear();
            chartCategorias.ChartAreas.Clear();
            chartCategorias.Legends.Clear();

            ChartArea chartArea1 = new ChartArea("Productos");
            chartCategorias.ChartAreas.Add(chartArea1);

            foreach (var item in movimientosAgrupados)
            {
                Series series = new Series(item.Nombre);
                series.ChartType = SeriesChartType.Column;
                series.ChartArea = "Productos";
                series.Points.AddXY(item.Nombre, item.Cantidad);
                series.IsVisibleInLegend = true;
                chartCategorias.Series.Add(series);
                chartCategorias.Legends.Add(new Legend(item.Nombre));
                chartCategorias.Legends[item.Nombre].Docking = Docking.Bottom;
            }

            chartCategorias.ChartAreas["Productos"].AxisX.LabelStyle.Enabled = false;
            chartCategorias.ChartAreas["Productos"].AxisX.Title = "Productos";
            chartCategorias.ChartAreas["Productos"].AxisY.Title = "Cantidad";
            chartCategorias.ChartAreas["Productos"].AxisX.Interval = 1;
            chartCategorias.ChartAreas["Productos"].AxisX.MajorGrid.Enabled = true;
            chartCategorias.ChartAreas["Productos"].AxisX.MajorTickMark.Enabled = true;

            chartCategorias.Titles.Clear();
            chartCategorias.Titles.Add("Productos");
        }

        private void LoadChartDataCategorias(List<ProductoMovimientoResponse> movimientos)
        {
            var movimientosAgrupados = movimientos.GroupBy(mov => mov.Producto?.CategoriaProducto?.Descripcion)
                .Select(m => new ChartResponse { Nombre = m.Key ?? "Producto Común", Cantidad = m.Sum(item => item.Cantidad) }).ToList();

            chartProductos.Series.Clear();
            chartProductos.ChartAreas.Clear();
            chartProductos.Legends.Clear();

            ChartArea chartArea1 = new ChartArea("Categorías");
            chartProductos.ChartAreas.Add(chartArea1);

            foreach (var item in movimientosAgrupados)
            {
                Series series = new Series(item.Nombre);
                series.ChartType = SeriesChartType.Column;
                series.ChartArea = "Categorías";
                series.Points.AddXY(item.Nombre, item.Cantidad);
                series.IsVisibleInLegend = true;
                chartProductos.Series.Add(series);
                chartProductos.Legends.Add(new Legend(item.Nombre));
                chartProductos.Legends[item.Nombre].Docking = Docking.Bottom;
            }

            chartProductos.ChartAreas["Categorías"].AxisX.LabelStyle.Enabled = false;
            chartProductos.ChartAreas["Categorías"].AxisX.Title = "Categorías";
            chartProductos.ChartAreas["Categorías"].AxisY.Title = "Cantidad";
            chartProductos.ChartAreas["Categorías"].AxisX.Interval = 1;
            chartProductos.ChartAreas["Categorías"].AxisX.MajorGrid.Enabled = true;
            chartProductos.ChartAreas["Categorías"].AxisX.MajorTickMark.Enabled = true;

            chartProductos.Titles.Clear();
            chartProductos.Titles.Add("Categorías");
        }

        private void LoadChartDataDias(List<ProductoMovimientoResponse> movimientos)
        {
            List<ChartResponse> movimientosAgrupados = new List<ChartResponse>();
            var diasDiferencia = (dateHasta.Value - dateDesde.Value).TotalDays;

            if (diasDiferencia > 15)
            {
                movimientosAgrupados = movimientos.GroupBy(mov => $"{mov.Fecha.Month.ToString()}/{mov.Fecha.Year.ToString()}")
                    .Select(m => new ChartResponse { Nombre = m.Key, Cantidad = Convert.ToInt32(m.Sum(item => item.Valor)) }).ToList();
            }
            else
            {
                movimientosAgrupados = movimientos.GroupBy(mov => $"{mov.Fecha.Day.ToString()}/{mov.Fecha.Month.ToString()}/{mov.Fecha.Year.ToString()}")
                    .Select(m => new ChartResponse { Nombre = m.Key, Cantidad = Convert.ToInt32(m.Sum(item => item.Valor)) }).ToList();
            }

            chartDias.Series.Clear();
            chartDias.ChartAreas.Clear();
            chartDias.Legends.Clear();

            ChartArea chartArea1 = new ChartArea("Fecha");
            chartDias.ChartAreas.Add(chartArea1);

            foreach (var item in movimientosAgrupados)
            {
                Series series = new Series(item.Nombre);
                series.ChartType = SeriesChartType.Column;
                series.ChartArea = "Fecha";
                series.Points.AddXY(item.Nombre, item.Cantidad);
                series.IsVisibleInLegend = true;
                chartDias.Series.Add(series);
                chartDias.Legends.Add(new Legend(item.Nombre));
                chartDias.Legends[item.Nombre].Docking = Docking.Bottom;
            }

            chartDias.ChartAreas["Fecha"].AxisX.LabelStyle.Enabled = false;
            chartDias.ChartAreas["Fecha"].AxisX.Title = "Fecha";
            chartDias.ChartAreas["Fecha"].AxisY.Title = "Valor";
            chartDias.ChartAreas["Fecha"].AxisX.Interval = 1;
            chartDias.ChartAreas["Fecha"].AxisX.MajorGrid.Enabled = true;
            chartDias.ChartAreas["Fecha"].AxisX.MajorTickMark.Enabled = true;

            chartDias.Titles.Clear();
            chartDias.Titles.Add("Fecha");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog1.SelectedPath;
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn column in dvMovimientos.Columns)
                {
                    dt.Columns.Add(column.HeaderText, typeof(object));
                }

                // Add rows to the DataTable based on DataGridView rows
                foreach (DataGridViewRow row in dvMovimientos.Rows)
                {
                    if (row.IsNewRow) continue;

                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < dvMovimientos.Columns.Count; i++)
                    {
                        dr[i] = row.Cells[i].Value;
                    }
                    dt.Rows.Add(dr);
                }

                string fecha = dateDesde.Value.ToString("yyyy-MM-dd") == dateHasta.Value.ToString("yyyy-MM-dd") ? dateDesde.Value.ToString("yyyy-MM-dd") : $"{dateDesde.Value.ToString("yyyy-MM-dd")}-{dateHasta.Value.ToString("yyyy-MM-dd")}";
                bool exportado = ExportCsvHelper.ExportCsv(dt, $"ReporteVentas_{fecha}", selectedFolderPath);

                string toastTipo = exportado ? "SUCCESS" : "ERROR";
                ToastForm toast = new ToastForm(toastTipo, exportado ? "Exportación finalizada." : "Ocurrió un error en la exportación.", this.FindForm()!);
                toast.Show();
            }
        }

        private void linkLabelHoy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dateDesde.Value = DateTime.Now;
            dateHasta.Value = DateTime.Now;
            _ = GetAllMovimientos();
        }

        private void linkLabelSemana_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dateDesde.Value = DateTime.Now.AddDays(-7);
            dateHasta.Value = DateTime.Now;
            _ = GetAllMovimientos();
        }

        private void linkLabelMes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dateDesde.Value = new DateTime(dateDesde.Value.Year, dateDesde.Value.Month, 1, 0, 0, 0);
            dateHasta.Value = DateTime.Now;
            _ = GetAllMovimientos();
        }
    }
}
