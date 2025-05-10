﻿namespace PuntoDeVenta.Domain.Entities
{
    public partial class Unidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool Habilitado { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
