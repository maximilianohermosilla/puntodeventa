namespace PuntoDeVenta.Domain.Entities
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public float PrecioTotal { get; set; }
        public int IdEstado { get; set; }
        public int IdFormaPago { get; set; }
        public int IdTurno { get; set; }
        public int? IdCliente { get; set; }
        
        public virtual Estado Estado { get; set; }
        public virtual FormaPago FormaPago { get; set; }
        public virtual Turno Turno { get; set; }
        public virtual Cliente? Cliente{ get; set; }

        public virtual ICollection<TicketDetalle> TicketDetalles { get; set; }
        public virtual ICollection<TicketEstado> TicketEstados { get; set; }
    }
}
