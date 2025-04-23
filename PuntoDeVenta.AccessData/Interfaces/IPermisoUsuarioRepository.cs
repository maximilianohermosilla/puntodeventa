using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IPermisoUsuarioRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<PermisoUsuario>> GetAll(bool? habilitados);
        Task<PermisoUsuario> Create(PermisoUsuario pEntity);
        Task Delete(PermisoUsuario pEntity);
        Task<PermisoUsuario> GetById(int pId);
    }
}
