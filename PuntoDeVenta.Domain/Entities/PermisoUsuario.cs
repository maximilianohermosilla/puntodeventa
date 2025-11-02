namespace PuntoDeVenta.Domain.Entities
{
    public partial class PermisoUsuario
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdPermiso { get; set; }
        public bool Habilitado { get; set; }

        public required Usuario Usuario { get; set; }
        public required Permiso Permiso { get; set; }
    }
}
