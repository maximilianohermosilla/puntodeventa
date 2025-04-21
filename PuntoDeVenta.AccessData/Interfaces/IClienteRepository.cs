using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IClienteRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Cliente>> GetAll(bool? habilitados);
        Task<Cliente> Create(Cliente pEntity);
        Task Delete(Cliente pEntity);
        Task<Cliente> GetById(int pId);
    }
}
