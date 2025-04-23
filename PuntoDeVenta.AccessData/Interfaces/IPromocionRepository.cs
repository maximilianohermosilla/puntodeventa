using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IPromocionRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Promocion>> GetAll();
        Task<Promocion> Create(Promocion pEntity);
        Task Delete(Promocion pEntity);
        Task<Promocion> GetById(int pId);
    }
}
