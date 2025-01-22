﻿namespace PuntoDeVenta.Domain.Entities
{
    public partial class TipoMovimiento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}
