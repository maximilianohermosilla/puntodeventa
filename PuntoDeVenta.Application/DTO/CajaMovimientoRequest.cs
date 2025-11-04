namespace PuntoDeVenta.Application.DTO
{
    public partial class CajaMovimientoRequest
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
    }
}
