using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IFormaPagoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<FormaPago>> GetAll(bool? habilitados);
        Task<FormaPago> Create(FormaPago pEntity);
        Task Delete(FormaPago pEntity);
        Task<FormaPago> GetById(int pId);
    }
}
