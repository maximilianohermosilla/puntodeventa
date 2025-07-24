using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Domain.Entities;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PuntoDeVenta.UserControls
{
    public partial class VentasControl : UserControl
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly IProductoService _productoService;
        private readonly ITicketService _ticketService;
        private int IdTurno = 0;

        public VentasControl()
        {
            _productoService = new ProductoService(_context);
            _ticketService = new TicketService(_context);
            InitializeComponent();
            AgregarTicket();
        }

        public VentasControl(int idTurno)
        {
            IdTurno = idTurno;
            _productoService = new ProductoService(_context);
            _ticketService = new TicketService(_context);
            InitializeComponent();
            AgregarTicket();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            _ = AgregarProducto(1);
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            _ = EliminarProducto(txtCodigo.Text);
        }

        protected void txtCodigo_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ = AgregarProducto(1);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            _ = CobrarTicket();
        }

        private void dataGridViewVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                var dataGridView = GetDataGridView();
                string codigoProducto = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                _ = EliminarProducto(codigoProducto!);
            }
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            AgregarTicket();
        }

        public DataTable NewDataTable()
        {

            DataTable productosDataTable = new DataTable();
            productosDataTable.Columns.Add("Id");
            productosDataTable.Columns.Add("Código");
            productosDataTable.Columns.Add("Nombre");
            productosDataTable.Columns.Add("Precio");
            productosDataTable.Columns.Add("Cantidad");
            productosDataTable.Columns.Add("Importe");

            return productosDataTable;
        }

        public void AgregarTicket()
        {
            int cantidadTickets = tabControlTickets.TabCount;
            TabPage newTabPage = new TabPage($@"Ticket {cantidadTickets + 1}");
            newTabPage.BackColor = Color.Transparent;
            newTabPage.ForeColor = SystemColors.ControlText;
            newTabPage.Location = new Point(4, 24);
            newTabPage.Padding = new Padding(3);
            newTabPage.Size = new Size(1437, 363);

            tabControlTickets.TabPages.Add(newTabPage);

            DataGridView newDataGridView = new DataGridView();
            newDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            newDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            newDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            newDataGridView.Dock = DockStyle.Fill;
            newDataGridView.Location = new Point(3, 3);
            newDataGridView.Name = $@"dvTicket{cantidadTickets + 1}";
            newDataGridView.ReadOnly = true;
            newDataGridView.ShowEditingIcon = false;
            newDataGridView.Size = new Size(1431, 357);
            newDataGridView.TabIndex = 0;
            newDataGridView.CellDoubleClick += dataGridViewVentas_CellDoubleClick!;

            newTabPage.Controls.Add(newDataGridView);
        }


        public async Task AgregarProducto(int cantidad)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    var producto = await GetProductoByCodigo(txtCodigo.Text);
                    int cantidadActual = 1;

                    if (producto != null)
                    {
                        var dataGridView = GetDataGridView();
                        var dataTable = (DataTable)(dataGridView!.DataSource! ?? NewDataTable());

                        DataRow[] foundRows = dataTable.Select($@"Código = '{txtCodigo.Text}'");
                        DataRow productoExistente = foundRows.FirstOrDefault()!;

                        if (productoExistente != null)
                        {
                            Int32.TryParse(productoExistente["Cantidad"].ToString(), out cantidadActual);
                            cantidadActual += cantidad;
                            productoExistente["Cantidad"] = cantidadActual;
                            productoExistente["Importe"] = cantidadActual * Convert.ToInt32(productoExistente["Precio"].ToString());
                            productoExistente.AcceptChanges();
                        }
                        else
                        {
                            dataTable.Rows.Add(producto.Id, producto.Codigo, producto.Descripcion, producto.PrecioVenta, 1, producto.PrecioVenta);
                        }

                        dataGridView.DataSource = dataTable;
                        txtCodigo.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un código válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task EliminarProducto(string txtCodigo)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigo))
                {
                    var producto = await GetProductoByCodigo(txtCodigo);

                    if (producto != null)
                    {
                        var dataGridView = GetDataGridView();
                        var dataTable = (DataTable)(dataGridView!.DataSource! ?? NewDataTable());

                        DataRow[] foundRows = dataTable.Select($@"Código = '{txtCodigo}'");
                        DataRow productoExistente = foundRows.FirstOrDefault()!;

                        if (productoExistente != null)
                        {
                            dataTable.Rows.Remove(productoExistente);
                            dataTable.AcceptChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un código válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public async Task<ProductoResponse?> GetProductoByCodigo(string codigo)
        {
            try
            {
                var response = await _productoService.GetByCodigo(codigo);

                if (response != null && response.success)
                {
                    return response.response;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task CobrarTicket()
        {
            try
            {
                List<TicketDetalleRequest> productos = new List<TicketDetalleRequest>();

                var dataGridView = GetDataGridView();
                var dataTable = (DataTable)(dataGridView!.DataSource ?? NewDataTable());

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    DataRow rowHeader = dataTable.NewRow();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string vId = row["Id"].ToString()!;
                        string vCodigo = row["Código"].ToString()!;
                        string vNombre = row["Nombre"].ToString()!;
                        string vPrecio = row["Precio"].ToString()!;
                        string vCantidad = row["Cantidad"].ToString()!;
                        string vImporte = row["Importe"].ToString()!;

                        TicketDetalleRequest producto = new TicketDetalleRequest();
                        producto.Cantidad = Convert.ToInt32(vCantidad);
                        producto.Precio = Convert.ToInt32(vPrecio);
                        producto.Descuento = 0;
                        producto.PrecioFinal = Convert.ToInt32(vImporte);
                        producto.PorMayor = false;
                        producto.IdProducto = Convert.ToInt32(vId);
                        producto.IdTicket = 0;
                        producto.ProductoComun = "";

                        productos.Add(producto);
                    }

                    //TicketEstadoRequest ticketEstado = new TicketEstadoRequest()
                    //{                        
                    //    Fecha = DateTime.Now,
                    //    IdTicket = 0,
                    //    IdEstado = 2
                    //};

                    TicketRequest ticketRequest = new TicketRequest()
                    {
                        Nombre = $@"{IdTurno}_{tabControlTickets!.SelectedTab!.Name}_{DateTime.Now.ToString()}",
                        FechaCreacion = DateTime.Now,
                        FechaFinalizacion = DateTime.Now,
                        PrecioTotal = productos.Sum(x => x.PrecioFinal),
                        IdEstado = 2,
                        IdFormaPago = 1,
                        IdTurno = IdTurno,
                        IdCliente = null,
                        TicketDetalles = productos,
                        TicketEstados = new List<TicketEstadoRequest>() { new TicketEstadoRequest() { Fecha = DateTime.Now, IdTicket = 0, IdEstado = 2 } }
                    };

                    var response = await _ticketService.Insert(ticketRequest);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public DataGridView GetDataGridView()
        {
            try
            {
                var currentTabPage = tabControlTickets.SelectedTab;

                DataGridView selectedDataGridView = null;
                if (currentTabPage != null)
                {
                    foreach (Control control in currentTabPage.Controls)
                    {
                        if (control is DataGridView)
                        {
                            return selectedDataGridView = (DataGridView)control;
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public DataTable GetDataTable(DataGridView selectedDataGridView)
        {
            try
            {
                if (selectedDataGridView != null)
                {
                    return (DataTable)(selectedDataGridView!.DataSource);
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

    }
}
