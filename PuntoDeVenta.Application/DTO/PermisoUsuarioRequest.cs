namespace PuntoDeVenta.Application.DTO
{
    public partial class PermisoUsuarioRequest
    {
        public int Id { get; set; }
        public int IdUsuario{ get; set; }
        public int IdPermiso { get; set; }
        public bool Habilitado { get; set; } = true;
    }
}
