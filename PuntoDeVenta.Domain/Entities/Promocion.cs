namespace PuntoDeVenta.Domain.Entities
{
    public partial class Promocion
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int Cuotas { get; set; }
        public int Descuento { get; set; }
        public int CantidadInicio { get; set; }
        public int CantidadFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public virtual IList<PromocionCategoria> PromocionCategorias { get; set; } = new List<PromocionCategoria>();
        public virtual IList<PromocionProducto> PromocionProductos { get; set; } = new List<PromocionProducto>();
    }
}
