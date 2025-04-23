using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Repository
{
    public class TipoPermisoRepository : ITipoPermisoRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public TipoPermisoRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<TipoPermiso> Create(TipoPermiso pEntity)
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

        public async Task Delete(TipoPermiso pEntity)
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

        public async Task<List<TipoPermiso>> GetAll()
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.TipoPermiso.ToListAsync();
        }

        public async Task<TipoPermiso> GetById(int pId)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.TipoPermiso.Where(p => p.Id == pId).FirstOrDefaultAsync()!;
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
