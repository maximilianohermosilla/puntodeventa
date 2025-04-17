namespace PuntoDeVenta.Application.DTO
{
    public partial class ProductoRequest
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public float PrecioCosto { get; set; }
        public float PrecioPorMayor { get; set; }
        public float PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public int CantidadMinima { get; set; }
        public int CantidadMaxima { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public bool Habilitado { get; set; } = true;
        public int? IdCategoriaProducto { get; set; } = null;

    }
}
