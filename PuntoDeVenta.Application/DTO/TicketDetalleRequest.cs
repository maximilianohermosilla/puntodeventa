namespace PuntoDeVenta.Application.DTO
{
    public partial class TicketDetalleRequest
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Descuento { get; set; }
        public float PrecioFinal { get; set; }
        public bool PorMayor { get; set; }
        public int IdProducto { get; set; }
        public int IdTicket { get; set; }
    }
}