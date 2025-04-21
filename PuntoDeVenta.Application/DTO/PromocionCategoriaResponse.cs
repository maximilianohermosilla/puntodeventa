namespace PuntoDeVenta.Application.DTO
{
    public partial class PromocionCategoriaResponse
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool Habilitado { get; set; }
        public int IdCategoriaProducto { get; set; }
        public int IdPromocion { get; set; }

        public CategoriaProductoResponse CategoriaProducto { get; set; }
        public PromocionResponse Promocion { get; set; }
    }
}
