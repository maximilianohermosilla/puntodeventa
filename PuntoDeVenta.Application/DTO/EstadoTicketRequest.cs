namespace PuntoDeVenta.Application.DTO
{
    public partial class EstadoTicketRequest
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTicket { get; set; }
        public int IdEstado { get; set; }
    }
}
