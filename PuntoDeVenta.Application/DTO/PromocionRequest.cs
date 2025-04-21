namespace PuntoDeVenta.Application.DTO
{
    public partial class PromocionRequest
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int Cuotas { get; set; }
        public int Descuento { get; set; }
        public int CantidadInicio { get; set; }
        public int CantidadFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
