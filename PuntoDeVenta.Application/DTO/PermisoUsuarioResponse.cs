namespace PuntoDeVenta.Application.DTO
{
    public partial class PermisoUsuarioResponse
    {
        public int Id { get; set; }
        public int IdUsuario{ get; set; }
        public int IdPermiso { get; set; }
        public bool Habilitado { get; set; } = true;

        public UsuarioResponse Usuario { get; set; }
        public PermisoResponse Permiso { get; set; }
    }
}
