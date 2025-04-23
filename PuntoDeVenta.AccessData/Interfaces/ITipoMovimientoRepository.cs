using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface ITipoMovimientoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<TipoMovimiento>> GetAll();
        Task<TipoMovimiento> Create(TipoMovimiento pEntity);
        Task Delete(TipoMovimiento pEntity);
        Task<TipoMovimiento> GetById(int pId);
    }
}
