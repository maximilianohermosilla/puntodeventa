namespace PuntoDeVenta.Domain.Entities
{
    public partial class Estado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;

        public virtual ICollection<TicketEstado> TicketEstados { get; set; } = new List<TicketEstado>();
        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
