namespace PuntoDeVenta.Domain.Entities
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string? Codigo { get; set; } = null;
        public string Descripcion { get; set; } = string.Empty;
        public float? PrecioCosto { get; set; } = null;
        public float? PrecioPorMayor { get; set; } = null;
        public float? PrecioVenta { get; set; } = null;
        public int? Cantidad { get; set; } = null;
        public int? CantidadMinima { get; set; } = null;
        public int? CantidadMaxima { get; set; } = null;
        public DateTime FechaCreacion { get; set; } = DateTime.Today;
        public bool Habilitado { get; set; } = true;
        public int? IdCategoriaProducto { get; set; } = null;
        public int? IdSubCategoriaProducto { get; set; } = null;
        public int? IdUnidad { get; set; } = null;

        public virtual CategoriaProducto? CategoriaProducto { get; set; }
        public virtual SubCategoriaProducto? SubCategoriaProducto { get; set; }
        public virtual Unidad? Unidad { get; set; }
        public virtual IList<PromocionProducto> PromocionProductos { get; set; } = new List<PromocionProducto>();
        public virtual IList<TicketDetalle> TicketDetalles { get; set; } = new List<TicketDetalle>();
        public virtual ICollection<ProductoMovimiento> ProductoMovimientos { get; set; } = new List<ProductoMovimiento>();
    }
}
