using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface ITipoPermisoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<TipoPermiso>> GetAll();
        Task<TipoPermiso> Create(TipoPermiso pEntity);
        Task Delete(TipoPermiso pEntity);
        Task<TipoPermiso> GetById(int pId);
    }
}
