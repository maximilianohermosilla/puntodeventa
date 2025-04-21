namespace PuntoDeVenta.Application.DTO
{
    public partial class PermisoPerfilRequest
    {
        public int Id { get; set; }
        public int IdPerfil { get; set; }
        public int IdPermiso { get; set; }
        public bool Habilitado { get; set; } = true;
    }
}
