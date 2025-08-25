namespace PuntoDeVenta.Application.DTO
{
    public partial class ProductoMovimientoRequest
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion{ get; set; }
        public int Cantidad { get; set; }
        public int? CantidadInicio { get; set; }
        public int? CantidadFin { get; set; }
        public float Valor { get; set; }
        public int IdTipoMovimiento { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
    }
}
