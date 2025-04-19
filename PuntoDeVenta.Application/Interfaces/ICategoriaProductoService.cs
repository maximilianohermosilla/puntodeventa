using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ICategoriaProductoService
    {
        Task<ResponseModel<List<CategoriaProductoResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<CategoriaProductoResponse>> GetById(int id);
        Task<ResponseModel<CategoriaProductoResponse>> Insert(CategoriaProductoRequest entity);
        Task<ResponseModel<CategoriaProductoResponse>> Update(CategoriaProductoRequest entity);
        Task<ResponseModel<CategoriaProductoResponse>> Delete(int id);
    }
}
