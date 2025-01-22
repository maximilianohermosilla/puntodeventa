namespace PuntoDeVenta.Domain.Entities
{
    public partial class Movimiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion{ get; set; }
        public float Valor { get; set; }
        public bool Cancelado { get; set; }
        public int IdTipoMovimiento { get; set; }
        public int IdUsuario { get; set; }
        
        public virtual TipoMovimiento TipoMovimiento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
