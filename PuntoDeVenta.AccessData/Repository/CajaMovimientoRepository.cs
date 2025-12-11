using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Repository
{
    public class CajaMovimientoRepository : ICajaMovimientoRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public CajaMovimientoRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<CajaMovimiento> Create(CajaMovimiento pEntity)
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

        public async Task Delete(CajaMovimiento pEntity)
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

        public async Task<List<CajaMovimiento>> GetAll()
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.CajaMovimiento.ToListAsync();
        }

        public async Task<List<CajaMovimiento>> GetAllByIdTurno(int pIdTurno)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.CajaMovimiento.Where(p => p.IdTurno == pIdTurno).ToListAsync();
        }

        public async Task<List<CajaMovimiento>> GetAllByFechaAndTipoMovimientoFormaPago(DateTime pFechaDesde, DateTime pFechahasta, int pIdTipoCajaMovimiento, int pIdFormaPago)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.CajaMovimiento.Where(x => x.Fecha >= pFechaDesde && x.Fecha <= pFechahasta 
                    && (pIdTipoCajaMovimiento == 0 || x.IdTipoMovimiento == pIdTipoCajaMovimiento)
                    && (pIdFormaPago == 0 || x.IdFormaPago == pIdFormaPago))
                .Include(p => p.TipoMovimiento).Include(p => p.Usuario).Include(p => p.FormaPago)
                .ToListAsync();
        }

        public async Task<CajaMovimiento> GetById(int pId)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.CajaMovimiento.Where(p => p.Id == pId).FirstOrDefaultAsync()!;
        }

        public async Task<CajaMovimiento> GetLast()
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.CajaMovimiento!.OrderByDescending(t => t.Id)!.FirstOrDefaultAsync()!;
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
