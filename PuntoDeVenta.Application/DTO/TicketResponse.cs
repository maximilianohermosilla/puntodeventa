namespace PuntoDeVenta.Application.DTO
{
    public partial class TicketResponse
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
        
        public virtual EstadoResponse Estado { get; set; }
        public virtual FormaPagoResponse FormaPago { get; set; }
        public virtual TurnoResponse Turno { get; set; }
        public virtual ClienteResponse? Cliente{ get; set; }
    }
}
