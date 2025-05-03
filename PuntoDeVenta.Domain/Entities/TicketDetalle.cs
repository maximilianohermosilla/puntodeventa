namespace PuntoDeVenta.Domain.Entities
{
    public partial class TicketDetalle
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Descuento { get; set; }
        public float PrecioFinal { get; set; }
        public bool PorMayor { get; set; }
        public int? IdProducto { get; set; }
        public int IdTicket { get; set; }
        public string? ProductoComun { get; set; } = null;

        public virtual Producto? Producto { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
