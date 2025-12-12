using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Helpers;
using System.Data;

namespace PuntoDeVenta.UserControls.ComprasControls
{
    public partial class ComprasFormControl : UserControl
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();
        private readonly ICajaMovimientoService _cajaMovimientoService;
        private readonly ITipoMovimientoService _tipoMovimientoService;
        private readonly IFormaPagoService _formaPagoService;

        private List<CajaMovimientoResponse> _movimientos = new List<CajaMovimientoResponse>();
        public List<TipoMovimientoResponse> _tipoMovimientos;
        public List<FormaPagoResponse> _formaPagos;

        public CajaMovimientoResponse ultimoMovimiento;

        public ComprasFormControl()
        {
            _cajaMovimientoService = new CajaMovimientoService(_context);
            _tipoMovimientoService = new TipoMovimientoService(_context);
            _formaPagoService = new FormaPagoService(_context);
            InitializeComponent();
            _ = GetUltimoMovimiento();
            _ = GetAllTipoMovimientos();
            _ = GetAllFormaPago();
        }

        public async Task GetUltimoMovimiento()
        {
            var responseMovimiento = await _cajaMovimientoService.GetLast();

            if (responseMovimiento != null && responseMovimiento.response != null)
            {
                ultimoMovimiento = (CajaMovimientoResponse)responseMovimiento.response;
                labelTotal.Text = $@"{responseMovimiento.response.ValorFin!.ToString("C2")}";
            }
        }

        public async Task GetAllTipoMovimientos()
        {
            try
            {
                var response = await _tipoMovimientoService.GetAll();

                if (response != null && response.success)
                {
                    _tipoMovimientos = (List<TipoMovimientoResponse>)response.response!;                    
                    comboTipoMovimiento.DisplayMember = "Descripcion";
                    comboTipoMovimiento.ValueMember = "Id";
                    comboTipoMovimiento.DataSource = _tipoMovimientos.Where(t => t.Id <3).ToList();
                    comboTipoMovimiento.Refresh();
                    comboTipoMovimiento.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task GetAllFormaPago()
        {
            try
            {
                var response = await _formaPagoService.GetAll(true);

                if (response != null && response.success)
                {
                    _formaPagos = (List<FormaPagoResponse>)response.response!;
                    comboFormaPago.DisplayMember = "Descripcion";
                    comboFormaPago.ValueMember = "Id";
                    comboFormaPago.DataSource = _formaPagos.ToList();
                    comboFormaPago.Refresh();
                    comboFormaPago.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _ = GetAllMovimientos();
            _ = GetUltimoMovimiento();
        }

        public async Task GetAllMovimientos()
        {
            try
            {
                var desde = new DateTime(dateDesde.Value.Year, dateDesde.Value.Month, dateDesde.Value.Day, 0, 0, 0);
                var hasta = new DateTime(dateHasta.Value.Year, dateHasta.Value.Month, dateHasta.Value.Day, 23, 59, 0);
                var response = await _cajaMovimientoService.GetAllByFechaAndTipoMovimientoFormaPago(desde, hasta, 0, 0);

                if (response != null && response.success)
                {
                    _movimientos = response.response!;
                    SetearMovimientos(_movimientos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SetearMovimientos(List<CajaMovimientoResponse> movimientos)
        {
            if (movimientos != null && movimientos.Any())
            {
                var listaMovimientos = movimientos.Select(x => new
                {
                    Codigo = x.Id,
                    Usuario = x.Usuario.User ?? "",
                    x.Fecha,
                    x.ValorInicio,
                    x.Valor,
                    x.ValorFin,
                    TipoMovimiento = x.TipoMovimiento!.Descripcion,
                    FormaPago = x.FormaPago!.Descripcion
                })!.ToList();

                dvMovimientos.DataSource = null;
                dvMovimientos.DataSource = listaMovimientos;
                dvMovimientos.Refresh();
                dvMovimientos.Invalidate();

                dvMovimientos.Visible = true;
                labelSinResultados.Visible = false;
            }
            else
            {
                dvMovimientos.Visible = false;
                labelSinResultados.Visible = true;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _ = GuardarMovimiento();
        }

        public async Task GuardarMovimiento()
        {
            try
            {
                ResponseModel<CajaMovimientoResponse> response = new ResponseModel<CajaMovimientoResponse>();
                if (txtDescripcion.Text == "" || txtValor.Text == "0")
                {
                    MessageBox.Show("Debe ingresar una descripción válida y un valor mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var ultimoValor = ultimoMovimiento != null ? ultimoMovimiento!.ValorFin : 0;
                    CajaMovimientoRequest movimiento = new CajaMovimientoRequest()
                    {
                        Id = 0,
                        Fecha = DateTime.Now,
                        Descripcion = txtDescripcion.Text,
                        Valor = Convert.ToInt32(txtValor.Value),
                        ValorInicio = ultimoValor,
                        ValorFin = Convert.ToInt32(comboTipoMovimiento!.SelectedValue) == 1 
                                    ? ultimoValor + Convert.ToInt32(txtValor.Value)
                                    : ultimoValor - Convert.ToInt32(txtValor.Value),
                        Entrada = Convert.ToInt32(comboTipoMovimiento!.SelectedValue) == 1,
                        Salida = Convert.ToInt32(comboTipoMovimiento!.SelectedValue) == 2,
                        IdTipoMovimiento = Convert.ToInt32(comboTipoMovimiento.SelectedValue),
                        IdUsuario = SessionHelper.IdUsuario,
                        IdFormaPago = Convert.ToInt32(comboFormaPago.SelectedValue),
                        IdTurno = SessionHelper.IdTurno
                    };


                    response = await _cajaMovimientoService.Insert(movimiento);

                    if (response.success == true)
                    {
                        _ = GetUltimoMovimiento();
                        _ = GetAllMovimientos();
                        txtDescripcion.Text = "";
                        txtValor.Value = 0;
                    }

                    string toastTipo = response.success ? "SUCCESS" : "ERROR";
                    ToastForm toast = new ToastForm(toastTipo, response.message, this.FindForm());
                    toast.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
