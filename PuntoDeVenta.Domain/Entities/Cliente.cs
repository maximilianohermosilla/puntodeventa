namespace PuntoDeVenta.Domain.Entities
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Imagen { get; set; }
        public bool Habilitado { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public virtual IList<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
