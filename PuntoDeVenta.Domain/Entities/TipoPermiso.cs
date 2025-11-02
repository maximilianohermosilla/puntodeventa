namespace PuntoDeVenta.Domain.Entities
{
    public partial class TipoPermiso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;

        public virtual ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();
    }
}
