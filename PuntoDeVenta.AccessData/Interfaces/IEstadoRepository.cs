using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IEstadoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Estado>> GetAll();
        Task<Estado> Create(Estado pEntity);
        Task Delete(Estado pEntity);
        Task<Estado> GetById(int pId);
    }
}
