namespace PuntoDeVenta.Domain.Entities
{
    public partial class PermisoPerfil
    {
        public int Id { get; set; }
        public int IdPerfil { get; set; }
        public int IdPermiso { get; set; }
        public bool Habilitado { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual Permiso Permiso { get; set; }
    }
}
