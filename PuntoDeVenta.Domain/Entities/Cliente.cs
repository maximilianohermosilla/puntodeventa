namespace PuntoDeVenta.Domain.Entities
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Imagen { get; set; }
        public bool Habilitado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual IList<Ticket> Tickets { get; set; }
    }
}
