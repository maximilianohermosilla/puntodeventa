﻿namespace PuntoDeVenta.Application.DTO
{
    public partial class PromocionProductoRequest
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool Habilitado { get; set; }
        public int IdProducto { get; set; }
        public int IdPromocion { get; set; }
    }
}
