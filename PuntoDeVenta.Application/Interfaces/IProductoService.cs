using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IProductoService
    {
        Task<ResponseModel<List<ProductoResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<ProductoResponse>> GetById(int id);
        Task<ResponseModel<ProductoResponse>> Insert(ProductoRequest entity);
        Task<ResponseModel<ProductoResponse>> Update(ProductoRequest entity);
        Task<ResponseModel<ProductoResponse>> Delete(int id);
    }
}
