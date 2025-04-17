namespace PuntoDeVenta.Application.DTO
{
    public class ResponseModel
    {
        public bool success { get; set; } = true;
        public int? statusCode { get; set; }
        public string? message { get; set; }
        public Object? response { get; set; }
    }
}
