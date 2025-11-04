namespace PuntoDeVenta.Application.DTO
{
    public partial class ProductoMovimientoResponse
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion{ get; set; }
        public int Cantidad { get; set; }
        public int? CantidadInicio { get; set; }
        public int? CantidadFin { get; set; }
        public float Valor { get; set; }
        public int IdTipoMovimiento { get; set; }
        public int IdUsuario { get; set; }
        public int? IdProducto { get; set; } = null;
        public int? IdFormaPago { get; set; } = null;
        public int? IdTurno { get; set; } = null;

        public virtual TipoMovimientoResponse TipoMovimiento { get; set; }
        public virtual UsuarioResponse Usuario { get; set; }
        public virtual ProductoResponse? Producto { get; set; } = null;
        public virtual FormaPagoResponse? FormaPago { get; set; } = null;
        public virtual TurnoResponse? Turno { get; set; } = null;
    }
}
