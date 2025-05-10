namespace PuntoDeVenta.Application.DTO
{
    public partial class UnidadRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }
    }
}
