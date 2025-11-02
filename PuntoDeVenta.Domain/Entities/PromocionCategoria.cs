namespace PuntoDeVenta.Domain.Entities
{
    public partial class PromocionCategoria
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool Habilitado { get; set; }
        public int IdCategoriaProducto { get; set; }
        public int IdPromocion { get; set; }

        public required CategoriaProducto CategoriaProducto { get; set; }
        public required Promocion Promocion { get; set; }
    }
}
