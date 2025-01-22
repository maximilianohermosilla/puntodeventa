namespace PuntoDeVenta.Domain.Entities
{
    public partial class TipoPermiso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Permiso> Permisos { get; set; }
    }
}
