namespace PuntoDeVenta.Domain.Entities
{
    public partial class FormaPago
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public bool Habilitado { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
        public virtual ICollection<ProductoMovimiento> ProductoMovimientos { get; set; } = new List<ProductoMovimiento>();
        public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
        public virtual ICollection<CajaMovimiento> CajaMovimientos { get; set; } = new List<CajaMovimiento>();
    }
}
