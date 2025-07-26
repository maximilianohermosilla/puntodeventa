using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Domain.Entities;
using PuntoDeVenta.FormDialogs;
using System.Data;
using System.Windows.Forms;

namespace PuntoDeVenta.UserControls
{
    public partial class VentasControl : UserControl
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly IProductoService _productoService;
        private readonly ITicketService _ticketService;
        private int IdTurno = 0;
        private int? IdCliente = null;
        private string? NombreCliente = null;

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
            _ = AgregarProducto(txtCodigo.Text, 1);
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            _ = EliminarProducto(txtCodigo.Text);
        }

        protected void txtCodigo_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ = AgregarProducto(txtCodigo.Text, 1);
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

                bool esProductoComun = codigoProducto == "0";
                if (esProductoComun)
                {
                    codigoProducto = dataGridView.Rows[e.RowIndex].Cells["Nombre"].Value.ToString()!;
                }
                _ = EliminarProducto(codigoProducto!, esProductoComun);
            }
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            AgregarTicket();
        }


        private void btnVarios_Click(object sender, EventArgs e)
        {
            //SetActivePanel(null);
            ProductoEtiquetaDialog etiquetaDialog = new ProductoEtiquetaDialog();
            etiquetaDialog.Text = "Varios Productos";
            etiquetaDialog.labelCantidad.Visible = true;
            etiquetaDialog.txtCantidad.Visible = true;

            try
            {
                if (etiquetaDialog.ShowDialog(this) == DialogResult.OK)
                {
                    int cantidad = (int)etiquetaDialog.txtCantidad.Value;
                    //int.TryParse(etiquetaDialog.txtCantidad.Text, out cantidad);
                    _ = AgregarProducto(etiquetaDialog.txtEtiqueta.Text, cantidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            etiquetaDialog.Dispose();

        }

        private void btnComun_Click(object sender, EventArgs e)
        {
            ProductoComunDialog productoComunDialog = new ProductoComunDialog();

            try
            {
                if (productoComunDialog.ShowDialog(this) == DialogResult.OK)
                {
                    int precio = (int)productoComunDialog.txtPrecio.Value;
                    int cantidad = (int)productoComunDialog.txtCantidad.Value;
                    //int.TryParse(productoComunDialog.txtPrecio.Text, out precio);
                    //int.TryParse(productoComunDialog.txtCantidad.Text, out cantidad);
                    _ = AgregarProductoComun(productoComunDialog.txtDescripcion.Text, precio, cantidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            productoComunDialog.Dispose();
        }

        private void btnEliminarTicket_Click(object sender, EventArgs e)
        {
            if (tabControlTickets.SelectedTab != null)
            {
                tabControlTickets.TabPages.Remove(tabControlTickets.SelectedTab);
            }
        }

        private void tabControlTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAsignarCliente_Click(object sender, EventArgs e)
        {

        }





        #region Funciones

        public DataTable NewDataTable()
        {

            DataTable productosDataTable = new DataTable();
            productosDataTable.Columns.Add("Id");
            productosDataTable.Columns.Add("Código");
            productosDataTable.Columns.Add("Nombre");
            productosDataTable.Columns.Add("Precio");
            productosDataTable.Columns.Add("Cantidad");
            productosDataTable.Columns.Add("Stock");
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
            newTabPage.BackColor = Color.FromArgb(26, 32, 40);

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
            newDataGridView.BackColor = Color.FromArgb(26, 32, 40);

            newTabPage.Controls.Add(newDataGridView);
        }


        public async Task AgregarProducto(string codigo, int cantidad)
        {
            try
            {
                if (!string.IsNullOrEmpty(codigo))
                {
                    var producto = await GetProductoByCodigo(codigo);
                    int cantidadActual = 1;
                    int stock = 0;

                    if (producto != null)
                    {
                        var dataGridView = GetDataGridView();
                        var dataTable = (DataTable)(dataGridView!.DataSource! ?? NewDataTable());

                        DataRow[] foundRows = dataTable.Select($@"Código = '{codigo}'");
                        DataRow productoExistente = foundRows.FirstOrDefault()!;

                        if (productoExistente != null)
                        {
                            Int32.TryParse(productoExistente["Cantidad"].ToString(), out cantidadActual);
                            cantidadActual += cantidad;
                            stock = producto.Cantidad > 0 ? producto.Cantidad - cantidadActual : 0;

                            if (stock < 0)
                            {
                                MessageBox.Show($@"No se puede completar la solicitud. Stock insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            productoExistente["Cantidad"] = cantidadActual;
                            productoExistente["Stock"] = stock;
                            productoExistente["Importe"] = cantidadActual * Convert.ToInt32(productoExistente["Precio"].ToString());
                            productoExistente.AcceptChanges();
                        }
                        else
                        {
                            stock = producto.Cantidad > 0 ? producto.Cantidad - cantidad : 0;

                            if (stock < 0)
                            {
                                MessageBox.Show($@"No se puede completar la solicitud. Stock insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            dataTable.Rows.Add(producto.Id, producto.Codigo, producto.Descripcion, producto.PrecioVenta, cantidad, stock, cantidad * producto.PrecioVenta);
                        }

                        dataGridView.DataSource = dataTable;
                        dataGridView.Columns["Id"].Visible = false;
                        txtCodigo.Text = "";

                        CalcularTotal();
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

        public async Task AgregarProductoComun(string descripcion, int precio, int cantidad)
        {
            try
            {
                if (!string.IsNullOrEmpty(descripcion))
                {
                    var dataGridView = GetDataGridView();
                    var dataTable = (DataTable)(dataGridView!.DataSource! ?? NewDataTable());

                    dataTable.Rows.Add(0, 0, descripcion, precio, cantidad, 0, precio * cantidad);

                    dataGridView.DataSource = dataTable;
                    txtCodigo.Text = "";

                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show("Debe ingresar una descripción para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task EliminarProducto(string txtCodigo, bool? esProductoComun = false)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigo))
                {
                    var dataGridView = GetDataGridView();
                    var dataTable = (DataTable)(dataGridView!.DataSource! ?? NewDataTable());

                    var filtro = esProductoComun == true ? $@"Nombre = '{txtCodigo}'" : $@"Id = '{txtCodigo}'";
                    DataRow[] foundRows = dataTable.Select(filtro);
                    DataRow productoExistente = foundRows.FirstOrDefault()!;

                    if (productoExistente != null)
                    {
                        dataTable.Rows.Remove(productoExistente);
                        dataTable.AcceptChanges();
                    }

                    CalcularTotal();

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

                    TicketRequest ticketRequest = new TicketRequest()
                    {
                        Nombre = $@"{IdTurno}_{tabControlTickets!.SelectedTab!.Name}_{DateTime.Now.ToString()}",
                        FechaCreacion = DateTime.Now,
                        FechaFinalizacion = DateTime.Now,
                        PrecioTotal = productos.Sum(x => x.PrecioFinal),
                        IdEstado = 2,
                        IdFormaPago = 1,
                        IdTurno = IdTurno,
                        IdCliente = IdCliente,
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

        public void CalcularTotal()
        {
            try
            {
                int total = 0;
                var dataGridView = GetDataGridView();
                var dataTable = (DataTable)(dataGridView!.DataSource ?? NewDataTable());

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    DataRow rowHeader = dataTable.NewRow();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string vImporte = row["Importe"].ToString()!;
                        total += Convert.ToInt32(vImporte);
                    }
                }

                labelTotal.Text = $@"$ {total.ToString()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        #endregion
    }
}
