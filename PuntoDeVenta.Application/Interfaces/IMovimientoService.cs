using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IMovimientoService
    {
        Task<ResponseModel<List<MovimientoResponse>>> GetAll();
        Task<ResponseModel<MovimientoResponse>> GetById(int id);
        Task<ResponseModel<List<MovimientoResponse>>> GetAllByIdTurno(int idTurno);
        Task<ResponseModel<MovimientoResponse>> Insert(MovimientoRequest entity);
        Task<ResponseModel<MovimientoResponse>> Update(MovimientoRequest entity);
        Task<ResponseModel<MovimientoResponse>> Delete(int id);
    }
}
