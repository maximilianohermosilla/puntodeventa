using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Repository
{
    public class TicketEstadoRepository : ITicketEstadoRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public TicketEstadoRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<TicketEstado> Create(TicketEstado pEntity)
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

        public async Task Delete(TicketEstado pEntity)
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

        public async Task<List<TicketEstado>> GetAll()
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.TicketEstado.ToListAsync();
        }

        public async Task<TicketEstado> GetById(int pId)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.TicketEstado.Where(p => p.Id == pId).FirstOrDefaultAsync()!;
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
