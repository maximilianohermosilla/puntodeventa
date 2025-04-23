using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Repository
{
    public class TipoMovimientoRepository : ITipoMovimientoRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public TipoMovimientoRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<TipoMovimiento> Create(TipoMovimiento pEntity)
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

        public async Task Delete(TipoMovimiento pEntity)
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

        public async Task<List<TipoMovimiento>> GetAll()
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.TipoMovimiento.ToListAsync();
        }

        public async Task<TipoMovimiento> GetById(int pId)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.TipoMovimiento.Where(p => p.Id == pId).FirstOrDefaultAsync()!;
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
