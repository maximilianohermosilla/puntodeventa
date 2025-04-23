using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ITurnoService
    {
        Task<ResponseModel<List<TurnoResponse>>> GetAll();
        Task<ResponseModel<TurnoResponse>> GetById(int id);
        Task<ResponseModel<TurnoResponse>> Insert(TurnoRequest entity);
        Task<ResponseModel<TurnoResponse>> Update(TurnoRequest entity);
        Task<ResponseModel<TurnoResponse>> Delete(int id);
    }
}
