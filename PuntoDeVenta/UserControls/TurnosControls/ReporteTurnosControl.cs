using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Enum;
using PuntoDeVenta.Helpers;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PuntoDeVenta.UserControls.TurnosControls
{
    public partial class ReporteTurnosControl : UserControl
    {
        private static PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly ITurnoService _turnoService;
        private UserControl _parent = null;

        private List<TurnoResponse> _turnos = new List<TurnoResponse>();

        public ReporteTurnosControl(UserControl parent)
        {
            _parent = parent;
            _turnoService = new TurnoService(_context);
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _ = GetAllTurnos();
        }

        public async Task GetAllTurnos()
        {
            try
            {
                var desde = new DateTime(dateDesde.Value.Year, dateDesde.Value.Month, dateDesde.Value.Day, 0, 0, 0);
                var hasta = new DateTime(dateHasta.Value.Year, dateHasta.Value.Month, dateHasta.Value.Day, 23, 59, 0);
                var response = await _turnoService.GetAllByFecha(desde, hasta);

                if (response != null && response.success)
                {
                    _turnos = response.response!;
                    SetearTurnos(_turnos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetearTurnos(List<TurnoResponse> turnos)
        {
            if (turnos != null && turnos.Any())
            {
                var listaTurnos = turnos.Select(x => new
                {
                    Codigo = x.Id,
                    Usuario = x.Usuario.User ?? "",
                    x.FechaInicio,
                    FechaFin = x.Finalizado == true ? x.FechaFin.ToString() : "",
                    x.CantidadInicio,
                    x.CantidadFin,
                    x.ValorEfectivo,
                    x.ValorTransferencia,
                    x.ValorTotal
                })!.ToList();

                dvTurnos.DataSource = null;
                dvTurnos.DataSource = listaTurnos;
                dvTurnos.Refresh();
                dvTurnos.Invalidate();

                dvTurnos.Visible = true;
                labelSinResultados.Visible = false;
                labelTotal.Text = $"TOTAL: ${turnos.Sum(p => p.ValorTotal)}";
                labelTotal.Visible = true;
            }
            else
            {
                dvTurnos.Visible = false;
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

                foreach (DataGridViewColumn column in dvTurnos.Columns)
                {
                    dt.Columns.Add(column.HeaderText, typeof(object));
                }

                // Add rows to the DataTable based on DataGridView rows
                foreach (DataGridViewRow row in dvTurnos.Rows)
                {
                    if (row.IsNewRow) continue;

                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < dvTurnos.Columns.Count; i++)
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
            _ = GetAllTurnos();
        }

        private void linkLabelSemana_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dateDesde.Value = DateTime.Now.AddDays(-7);
            dateHasta.Value = DateTime.Now;
            _ = GetAllTurnos();
        }

        private void linkLabelMes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dateDesde.Value = new DateTime(dateDesde.Value.Year, dateDesde.Value.Month, 1, 0, 0, 0);
            dateHasta.Value = DateTime.Now;
            _ = GetAllTurnos();
        }

        private void dvTurnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idTurno = dvTurnos.Rows[e.RowIndex].Cells[0].Value.ToString();
                VerTurno(Convert.ToInt32(idTurno));
            }
            catch (Exception ex)
            {

            }
        }

        public void VerTurno(int idTurno)
        {
            _ = ((UserControls.TurnosControl)_parent).GetTurnoById(idTurno);
        }
    }
}
