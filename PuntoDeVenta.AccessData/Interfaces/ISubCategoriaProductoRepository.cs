using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface ISubCategoriaProductoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<SubCategoriaProducto>> GetAllByCategoria(int pIdCategoriaProducto, bool? habilitados);
        Task<SubCategoriaProducto> Create(SubCategoriaProducto pEntity);
        Task Delete(SubCategoriaProducto pEntity);
        Task<SubCategoriaProducto> GetById(int pId);
    }
}
