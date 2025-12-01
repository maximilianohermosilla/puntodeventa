using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Enum;
using PuntoDeVenta.Helpers;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace PuntoDeVenta.UserControls.TurnosControls
{
    public partial class ReporteTurnosControl : UserControl
    {
        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly IProductoMovimientoService _productoMovimientoService;

        private List<ProductoMovimientoResponse> _productoMovimientos = new List<ProductoMovimientoResponse>();

        public ReporteTurnosControl()
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
                labelSinResultados.Visible = false;
                labelTotal.Text = $"TOTAL: ${movimientos.Sum(p => p.Valor)}";
                labelTotal.Visible = true;
            }
            else
            {
                dvMovimientos.Visible = false;
                labelSinResultados.Visible = true;
                labelTotal.Visible = false;
            }
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
