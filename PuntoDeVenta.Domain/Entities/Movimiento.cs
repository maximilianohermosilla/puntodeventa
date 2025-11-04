namespace PuntoDeVenta.Domain.Entities
{
    public partial class Movimiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion{ get; set; }
        public float Valor { get; set; }
        public bool? Cancelado { get; set; } = false;
        public int IdTipoMovimiento { get; set; }
        public bool Entrada { get; set; } = false;
        public bool Salida { get; set; } = false;
        public int IdUsuario { get; set; }
        public int? IdFormaPago { get; set; } = null;
        public int? IdTurno { get; set; } = null;

        public required TipoMovimiento TipoMovimiento { get; set; }
        public required Usuario Usuario { get; set; }
        public virtual Turno? Turno { get; set; }
        public virtual FormaPago? FormaPago { get; set; }
    }
}
