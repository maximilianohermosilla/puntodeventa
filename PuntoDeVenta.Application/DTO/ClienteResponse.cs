﻿namespace PuntoDeVenta.Application.DTO
{
    public partial class ClienteResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NombreApellido => $"{Nombre} {Apellido}";
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Imagen { get; set; }
        public bool Habilitado { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

    }
}
