namespace PuntoDeVenta.Application.DTO
{
    public partial class ProductoRequest
    {
        public int Id { get; set; }
        public string? Codigo { get; set; } = null;
        public string Descripcion { get; set; }
        public float? PrecioCosto { get; set; } = null;
        public float? PrecioPorMayor { get; set; } = null;
        public float? PrecioVenta { get; set; } = null;
        public int? Cantidad { get; set; } = null;
        public int? CantidadMinima { get; set; } = null;
        public int? CantidadMaxima { get; set; } = null;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public bool Habilitado { get; set; } = true;
        public int? IdCategoriaProducto { get; set; } = null;

    }
}
