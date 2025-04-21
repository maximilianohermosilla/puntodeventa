namespace PuntoDeVenta.Application.DTO
{
    public partial class TicketRequest
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaFinalizacion { get; set; } = DateTime.Now;
        public float PrecioTotal { get; set; }
        public int IdEstado { get; set; }
        public int IdFormaPago { get; set; }
        public int IdTurno { get; set; }
        public int? IdCliente { get; set; }
    }
}
