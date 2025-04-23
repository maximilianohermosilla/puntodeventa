using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface ITicketEstadoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<TicketEstado>> GetAll();
        Task<TicketEstado> Create(TicketEstado pEntity);
        Task Delete(TicketEstado pEntity);
        Task<TicketEstado> GetById(int pId);
    }
}
