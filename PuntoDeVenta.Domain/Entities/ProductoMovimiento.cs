namespace PuntoDeVenta.Domain.Entities
{
    public partial class ProductoMovimiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion{ get; set; }
        public int Cantidad { get; set; }
        public int? CantidadInicio { get; set; }
        public int? CantidadFin { get; set; }
        public float Valor { get; set; }
        public int IdTipoMovimiento { get; set; }
        public int IdUsuario { get; set; }
        public int? IdProducto { get; set; } = null;
        public int? IdFormaPago { get; set; } = null;

        public required TipoMovimiento TipoMovimiento { get; set; }
        public required Usuario Usuario { get; set; }
        public virtual Producto? Producto { get; set; } = null;
        public virtual FormaPago? FormaPago { get; set; } = null;
    }
}
