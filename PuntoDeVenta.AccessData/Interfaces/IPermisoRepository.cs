using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IPermisoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Permiso>> GetAll(bool? habilitados);
        Task<Permiso> Create(Permiso pEntity);
        Task Delete(Permiso pEntity);
        Task<Permiso> GetById(int pId);
    }
}
