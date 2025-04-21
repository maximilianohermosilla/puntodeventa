namespace PuntoDeVenta.Application.DTO
{
    public partial class EstadoTicketResponse
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTicket { get; set; }
        public int IdEstado { get; set; }

        public EstadoResponse Estado { get; set; }
        public TicketResponse Ticket { get; set; }
    }
}
