using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface ITicketDetalleRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<TicketDetalle>> GetAll();
        Task<TicketDetalle> Create(TicketDetalle pEntity);
        Task Delete(TicketDetalle pEntity);
        Task<TicketDetalle> GetById(int pId);
    }
}
