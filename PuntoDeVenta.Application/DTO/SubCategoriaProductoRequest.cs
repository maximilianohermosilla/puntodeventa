namespace PuntoDeVenta.Application.DTO
{
    public partial class SubCategoriaProductoRequest
    {        
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }
        public int IdCategoriaProducto { get; set; }
    }
}
