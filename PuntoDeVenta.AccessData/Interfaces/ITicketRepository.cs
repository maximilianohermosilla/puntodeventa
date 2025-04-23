using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface ITicketRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Ticket>> GetAll();
        Task<Ticket> Create(Ticket pEntity);
        Task Delete(Ticket pEntity);
        Task<Ticket> GetById(int pId);
    }
}
