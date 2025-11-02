namespace PuntoDeVenta.Domain.Entities
{
    public partial class Perfil
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public bool Habilitado { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
        public virtual ICollection<PermisoPerfil> PermisoPerfils { get; } = new List<PermisoPerfil>();
    }
}
