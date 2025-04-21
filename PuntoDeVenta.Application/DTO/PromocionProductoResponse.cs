namespace PuntoDeVenta.Application.DTO
{
    public partial class PromocionProductoResponse
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool Habilitado { get; set; }
        public int IdProducto { get; set; }
        public int IdPromocion { get; set; }

        public virtual ProductoResponse Producto { get; set; }
        public virtual PromocionResponse Promocion { get; set; }
    }
}
