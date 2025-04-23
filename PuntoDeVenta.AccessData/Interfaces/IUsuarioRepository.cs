using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IUsuarioRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Usuario>> GetAll(bool? habilitados);
        Task<Usuario> Create(Usuario pEntity);
        Task Delete(Usuario pEntity);
        Task<Usuario> GetById(int pId);
    }
}
