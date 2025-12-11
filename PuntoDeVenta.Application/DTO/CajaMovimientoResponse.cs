namespace PuntoDeVenta.Application.DTO
{
    public class CajaMovimientoResponse
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion{ get; set; }
        public float Valor { get; set; }
        public float ValorInicio { get; set; }
        public float ValorFin { get; set; }
        public bool Entrada { get; set; } = false;
        public bool Salida { get; set; } = false;
        public int IdTipoMovimiento { get; set; }
        public int IdUsuario { get; set; }
        public int? IdFormaPago { get; set; } = null;
        public int? IdTurno { get; set; } = null;

        public TipoMovimientoResponse? TipoMovimiento { get; set; }
        public UsuarioResponse? Usuario { get; set; }
        public virtual TurnoResponse? Turno { get; set; }
        public virtual FormaPagoResponse? FormaPago { get; set; }
    }
}
