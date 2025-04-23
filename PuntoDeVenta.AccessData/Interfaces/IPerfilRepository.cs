using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IPerfilRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Perfil>> GetAll(bool? habilitados);
        Task<Perfil> Create(Perfil pEntity);
        Task Delete(Perfil pEntity);
        Task<Perfil> GetById(int pId);
    }
}
