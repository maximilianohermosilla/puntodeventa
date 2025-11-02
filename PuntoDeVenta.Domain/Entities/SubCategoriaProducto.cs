namespace PuntoDeVenta.Domain.Entities
{
    public partial class SubCategoriaProducto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public bool Habilitado { get; set; }
        public int IdCategoriaProducto { get; set; }

        public required CategoriaProducto CategoriaProducto { get; set; }
        public virtual IList<Producto> Productos { get; set; } = new List<Producto>();

    }
}
