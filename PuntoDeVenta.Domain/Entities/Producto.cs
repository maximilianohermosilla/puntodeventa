﻿namespace PuntoDeVenta.Domain.Entities
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public float PrecioCosto { get; set; }
        public float PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public int CantidadMinima { get; set; }
        public int CantidadMaxima { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Habilitado { get; set; }
        public int IdCategoriaProducto { get; set; }

        public virtual CategoriaProducto CategoriaProducto { get; set; }
        public virtual IList<PromocionProducto> PromocionProductos { get; set; }
    }
}
