namespace PuntoDeVenta.Application.DTO
{
    public partial class FormaPagoResponse
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public bool Habilitado { get; set; } = true;
    }
}
