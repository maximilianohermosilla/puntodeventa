using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Repository
{
    public class TicketDetalleRepository : ITicketDetalleRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public TicketDetalleRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<TicketDetalle> Create(TicketDetalle pEntity)
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

        public async Task Delete(TicketDetalle pEntity)
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

        public async Task<List<TicketDetalle>> GetAll()
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.TicketDetalle.ToListAsync();
        }

        public async Task<TicketDetalle> GetById(int pId)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.TicketDetalle.Where(p => p.Id == pId).FirstOrDefaultAsync()!;
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
