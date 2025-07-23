using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Services;
using System.Data;

namespace PuntoDeVenta.UserControls
{
    public partial class VentasControl : UserControl
    {
        private PuntoDeVentaDbContext _context = new PuntoDeVentaDbContext();

        private readonly IProductoService _productoService;

        public List<ProductoResponse> productos = new List<ProductoResponse>(); 
        DataTable productosDataTable = new DataTable();


        public VentasControl()
        {
            _productoService = new ProductoService(_context);
            productosDataTable.Columns.Add("Código");
            productosDataTable.Columns.Add("Nombre");
            productosDataTable.Columns.Add("Precio");
            productosDataTable.Columns.Add("Cantidad");
            productosDataTable.Columns.Add("Importe");

            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            _ = AgregarProducto();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            _ = EliminarProducto(txtCodigo.Text);
        }

        protected void txtCodigo_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ = AgregarProducto();
            }
        }

        public async Task AgregarProducto()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    var producto = await GetProductoByCodigo(txtCodigo.Text);
                    int cantidad = 1;

                    if (producto != null)
                    {
                        productos.Add(producto);
                        DataRow[] foundRows = productosDataTable.Select($@"Código = '{txtCodigo.Text}'");
                        DataRow productoExistente = foundRows.FirstOrDefault()!;

                        if(productoExistente != null)
                        {
                            Int32.TryParse(productoExistente["Cantidad"].ToString(), out cantidad);
                            cantidad++;
                            productoExistente["Cantidad"] = cantidad;
                            productoExistente["Importe"] = cantidad * Convert.ToInt32(productoExistente["Precio"].ToString());
                            productoExistente.AcceptChanges();
                        }
                        else
                        {
                            productosDataTable.Rows.Add(producto.Codigo, producto.Descripcion, producto.PrecioVenta, 1, producto.PrecioVenta);
                        }

                        dataGridViewVentas.DataSource = productosDataTable;
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
                        DataRow[] foundRows = productosDataTable.Select($@"Código = '{txtCodigo}'");
                        DataRow productoExistente = foundRows.FirstOrDefault()!;

                        if (productoExistente != null)
                        {
                            productosDataTable.Rows.Remove(productoExistente);
                            productosDataTable.AcceptChanges();
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
        
        private void dataGridViewVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                string codigoProducto = dataGridViewVentas.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                _ = EliminarProducto(codigoProducto!);
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
    }
}
