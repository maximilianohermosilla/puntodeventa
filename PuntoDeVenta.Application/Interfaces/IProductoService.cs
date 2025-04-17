using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IProductoService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> Insert(ProductoRequest entity);
        Task<ResponseModel> Update(ProductoRequest entity);
        Task<ResponseModel> Delete(int id);
    }
}
