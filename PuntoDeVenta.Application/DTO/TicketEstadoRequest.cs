namespace PuntoDeVenta.Application.DTO
{
    public partial class TicketEstadoRequest
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int IdTicket { get; set; }
        public int IdEstado { get; set; }
    }
}
