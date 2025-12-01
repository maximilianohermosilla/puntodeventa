using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;
using System.Security.Cryptography;

namespace PuntoDeVenta.AccessData.Repository
{
    public class MovimientoRepository : IMovimientoRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public MovimientoRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<Movimiento> Create(Movimiento pEntity)
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

        public async Task Delete(Movimiento pEntity)
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

        public async Task<List<Movimiento>> GetAll()
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Movimiento.ToListAsync();
        }

        public async Task<List<Movimiento>> GetAllByIdTurno(int pIdTurno)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Movimiento.Where(p => p.IdTurno == pIdTurno).ToListAsync();
        }

        public async Task<List<Movimiento>> GetAllByFechaAndTipoMovimiento(DateTime pFechaDesde, DateTime pFechahasta, int pIdTipoMovimiento)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Movimiento.Where(x => x.Fecha >= pFechaDesde && x.Fecha <= pFechahasta && (pIdTipoMovimiento == 0 || x.IdTipoMovimiento == pIdTipoMovimiento))
                .Include(p => p.TipoMovimiento).Include(p => p.Usuario).Include(p => p.FormaPago)
                .ToListAsync();
        }

        public async Task<Movimiento> GetById(int pId)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Movimiento.Where(p => p.Id == pId).FirstOrDefaultAsync()!;
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
