using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IEstadoService
    {
        Task<ResponseModel<List<EstadoResponse>>> GetAll();
        Task<ResponseModel<EstadoResponse>> GetById(int id);
        Task<ResponseModel<EstadoResponse>> Insert(EstadoRequest entity);
        Task<ResponseModel<EstadoResponse>> Update(EstadoRequest entity);
        Task<ResponseModel<EstadoResponse>> Delete(int id);
    }
}
