using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Repository
{
    public class ProductoMovimientoRepository : IProductoMovimientoRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public ProductoMovimientoRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<ProductoMovimiento> Create(ProductoMovimiento pEntity)
        {
            try
            {
                vGblContext.Add(pEntity);
                await vGblContext.SaveChangesAsync();

                return pEntity;
            }
            catch (Exception ex)
            {
                vGblContext.ChangeTracker.Clear();
                throw ex;
            }    
        }

        public async Task<List<ProductoMovimiento>> CreateRange(IList<ProductoMovimiento> pEntities)
        {
            try
            {
                vGblContext.AddRange(pEntities);
                await vGblContext.SaveChangesAsync();

                return pEntities.ToList();
            }
            catch (Exception ex)
            {
                vGblContext.ChangeTracker.Clear();
                throw ex;
            }
        }

        public async Task Delete(ProductoMovimiento pEntity)
        {
            try
            {
                vGblContext.Remove(pEntity);
                await vGblContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                vGblContext.ChangeTracker.Clear();
                throw ex;
            }
        }

        public async Task<List<ProductoMovimiento>> GetAllByFechaAndTipoMovimiento(DateTime pFechaDesde, DateTime pFechahasta, int pIdTipoMovimiento)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.ProductoMovimiento.Where(x => x.Fecha >= pFechaDesde && x.Fecha <= pFechahasta && (pIdTipoMovimiento == 0 || x.IdTipoMovimiento == pIdTipoMovimiento))
                .Include(p => p.TipoMovimiento).Include(p => p.Usuario).Include(p => p.FormaPago).Include(p => p.Producto).ThenInclude(p => p.CategoriaProducto)
                .ToListAsync();
        }

        public async Task<ProductoMovimiento?> GetById(int pId)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.ProductoMovimiento.Include(p => p.TipoMovimiento).Include(p => p.Usuario).Include(p => p.FormaPago).Include(p => p.Producto).ThenInclude(p => p.CategoriaProducto)
                .Where(p => p.Id == pId).FirstOrDefaultAsync()!;
        }

        public bool SaveChanges()
        {
            try
            {
                return vGblContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                vGblContext.ChangeTracker.Clear();
                throw ex;
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                return await vGblContext.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                vGblContext.ChangeTracker.Clear();
                throw ex;
            }
        }
    }
}
