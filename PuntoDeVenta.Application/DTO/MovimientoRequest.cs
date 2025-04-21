namespace PuntoDeVenta.Application.DTO
{
    public partial class MovimientoRequest
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion { get; set; }
        public float Valor { get; set; }
        public bool? Cancelado { get; set; } = false;
        public int IdTipoMovimiento { get; set; }
        public bool Entrada { get; set; } = false;
        public bool Salida { get; set; } = false;
        public int IdUsuario { get; set; }
    }
}
