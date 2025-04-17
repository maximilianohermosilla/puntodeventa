using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface ICategoriaProductoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<CategoriaProducto>> GetAll();
        Task<CategoriaProducto> Create(CategoriaProducto pEntity);
        Task Delete(CategoriaProducto pEntity);
        Task<CategoriaProducto> GetById(int pId);
    }
}
