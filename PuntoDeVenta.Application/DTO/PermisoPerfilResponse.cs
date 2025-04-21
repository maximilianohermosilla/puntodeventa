namespace PuntoDeVenta.Application.DTO
{
    public partial class PermisoPerfilResponse
    {
        public int Id { get; set; }
        public int IdPerfil { get; set; }
        public int IdPermiso { get; set; }
        public bool Habilitado { get; set; } = true;

        public PerfilResponse Perfil { get; set; }
        public PermisoResponse Permiso { get; set; }
    }
}
