namespace PuntoDeVenta.Domain.Entities
{
    public partial class Pedido
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public float PrecioTotal { get; set; }
        public int IdEstado { get; set; }
        public int IdFormaPago { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        
        public virtual Estado Estado { get; set; }
        public virtual FormaPago FormaPago { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Cliente Cliente{ get; set; }

        public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; }
        public virtual ICollection<EstadoPedido> EstadoPedidos { get; set; }
    }
}
