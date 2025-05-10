using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IUnidadRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Unidad>> GetAll();
        Task<Unidad> Create(Unidad pEntity);
        Task Delete(Unidad pEntity);
        Task<Unidad> GetById(int pId);
    }
}
