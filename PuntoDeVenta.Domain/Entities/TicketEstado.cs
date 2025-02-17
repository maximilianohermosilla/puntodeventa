namespace PuntoDeVenta.Domain.Entities
{
    public partial class TicketEstado
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTicket { get; set; }
        public int IdEstado { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
