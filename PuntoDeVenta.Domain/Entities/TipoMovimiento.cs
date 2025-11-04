namespace PuntoDeVenta.Domain.Entities
{
    public partial class TipoMovimiento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;

        public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
        public virtual ICollection<ProductoMovimiento> ProductoMovimientos { get; set; } = new List<ProductoMovimiento>();
        public virtual ICollection<CajaMovimiento> CajaMovimientos { get; set; } = new List<CajaMovimiento>();
    }
}
