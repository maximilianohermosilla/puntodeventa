using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ITurnoService
    {
        Task<ResponseModel<List<TurnoResponse>>> GetAll();
        Task<ResponseModel<List<TurnoResponse>>> GetAllByFecha(DateTime pFechaDesde, DateTime pFechaHasta);
        Task<ResponseModel<List<TurnoResponse>>> GetAllByFechaUsuario(DateOnly fecha, int? idUsuario);
        Task<ResponseModel<TurnoResponse>> GetById(int id);
        Task<ResponseModel<TurnoResponse>> GetByIdUsuario(int idUsuario, bool? finalizado);
        Task<ResponseModel<TurnoResponse>> Insert(TurnoRequest entity);
        Task<ResponseModel<TurnoResponse>> Update(TurnoRequest entity);
        Task<ResponseModel<TurnoResponse>> Delete(int id);
    }
}
