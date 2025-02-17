namespace PuntoDeVenta.Domain.Entities
{
    public partial class Estado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TicketEstado> TicketEstados { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
