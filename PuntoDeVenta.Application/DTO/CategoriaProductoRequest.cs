﻿namespace PuntoDeVenta.Application.DTO
{
    public partial class CategoriaProductoRequest
    {        
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }
    }
}
