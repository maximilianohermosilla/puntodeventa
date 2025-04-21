namespace PuntoDeVenta.Application.DTO
{
    public partial class TicketEstadoResponse
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTicket { get; set; }
        public int IdEstado { get; set; }

        public virtual TicketResponse Ticket { get; set; }
        public virtual EstadoResponse Estado { get; set; }
    }
}
