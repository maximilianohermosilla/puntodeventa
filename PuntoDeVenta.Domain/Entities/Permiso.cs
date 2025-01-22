namespace PuntoDeVenta.Domain.Entities
{
    public partial class Permiso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }
        public int IdTipoPermiso { get; set; }

        public virtual TipoPermiso TipoPermiso { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
    }
}
