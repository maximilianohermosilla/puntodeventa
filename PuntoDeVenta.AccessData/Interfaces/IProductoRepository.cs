using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IProductoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Producto>> GetAll(bool? habilitados);
        Task<Producto> Create(Producto pEntity);
        Task Delete(Producto pEntity);
        Task<Producto> GetById(int pId);
        Task<Producto> GetByCodigo(string pCodigo);
    }
}
