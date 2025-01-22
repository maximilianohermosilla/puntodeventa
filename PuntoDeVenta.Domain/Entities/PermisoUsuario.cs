namespace PuntoDeVenta.Domain.Entities
{
    public partial class PermisoUsuario
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdPermiso { get; set; }
        public bool Habilitado { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Permiso Permiso { get; set; }
    }
}
