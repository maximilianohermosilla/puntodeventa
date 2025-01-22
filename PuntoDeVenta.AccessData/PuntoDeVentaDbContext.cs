using Microsoft.EntityFrameworkCore;

namespace PuntoDeVenta.AccessData
{
    public class PuntoDeVentaDbContext: DbContext
    {
        public PuntoDeVentaDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
