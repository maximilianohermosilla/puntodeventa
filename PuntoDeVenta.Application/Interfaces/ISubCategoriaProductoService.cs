using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ISubCategoriaProductoService
    {
        Task<ResponseModel<List<SubCategoriaProductoResponse>>> GetAllByCategoria(int pIdCategoriaProducto, bool? habilitados);
        Task<ResponseModel<SubCategoriaProductoResponse>> GetById(int id);
        Task<ResponseModel<SubCategoriaProductoResponse>> Insert(SubCategoriaProductoRequest entity);
        Task<ResponseModel<SubCategoriaProductoResponse>> Update(SubCategoriaProductoRequest entity);
        Task<ResponseModel<SubCategoriaProductoResponse>> Delete(int id);
    }
}
