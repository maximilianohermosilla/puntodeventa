namespace PuntoDeVenta.Domain.Entities
{
    public partial class Permiso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public bool Habilitado { get; set; }
        public int IdTipoPermiso { get; set; }

        public required TipoPermiso TipoPermiso { get; set; }
        public virtual ICollection<PermisoUsuario> PermisoUsuarios { get; } = new List<PermisoUsuario>();
        public virtual ICollection<PermisoPerfil> PermisoPerfils { get; } = new List<PermisoPerfil>();
    }
}
