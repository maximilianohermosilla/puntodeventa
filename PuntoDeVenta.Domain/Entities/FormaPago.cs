namespace PuntoDeVenta.Domain.Entities
{
    public partial class FormaPago
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
