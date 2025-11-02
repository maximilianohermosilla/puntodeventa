namespace PuntoDeVenta.Domain.Entities
{
    public partial class Turno
    {
        public int Id { get; set; }
        public int CantidadInicio { get; set; }
        public int? CantidadFin { get; set; }
        public float? ValorTotal { get; set; }
        public float? ValorGanancia { get; set; }
        public bool Finalizado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int IdUsuario { get; set; }

        public required Usuario Usuario { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
