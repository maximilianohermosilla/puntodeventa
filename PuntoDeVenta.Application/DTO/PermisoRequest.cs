namespace PuntoDeVenta.Application.DTO
{
    public partial class PermisoRequest
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; } = true;
        public int IdTipoPermiso { get; set; }
    }
}
