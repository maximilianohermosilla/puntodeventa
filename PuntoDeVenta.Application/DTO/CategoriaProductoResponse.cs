namespace PuntoDeVenta.Application.DTO
{
    public partial class CategoriaProductoResponse
    {        
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string CodigoDescripcion { get; set; }
        public bool Habilitado { get; set; }

        public virtual IList<SubCategoriaProductoResponse> SubCategoriaProductos { get; set; } = new List<SubCategoriaProductoResponse>();
    }
}
