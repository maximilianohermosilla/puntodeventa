using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ICategoriaProductoService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> Insert(CategoriaProductoRequest entity);
        Task<ResponseModel> Update(CategoriaProductoRequest entity);
        Task<ResponseModel> Delete(int id);
    }
}
