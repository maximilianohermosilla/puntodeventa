using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IPermisoPerfilRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<PermisoPerfil>> GetAll(bool? habilitados);
        Task<PermisoPerfil> Create(PermisoPerfil pEntity);
        Task Delete(PermisoPerfil pEntity);
        Task<PermisoPerfil> GetById(int pId);
    }
}
