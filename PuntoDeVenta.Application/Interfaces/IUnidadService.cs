using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IUnidadService
    {
        Task<ResponseModel<List<UnidadResponse>>> GetAll();
        Task<ResponseModel<UnidadResponse>> GetById(int id);
        Task<ResponseModel<UnidadResponse>> Insert(UnidadRequest entity);
        Task<ResponseModel<UnidadResponse>> Update(UnidadRequest entity);
        Task<ResponseModel<UnidadResponse>> Delete(int id);
    }
}
