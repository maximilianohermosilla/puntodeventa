using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ICajaMovimientoService
    {
        Task<ResponseModel<List<CajaMovimientoResponse>>> GetAll();
        Task<ResponseModel<CajaMovimientoResponse>> GetById(int id);
        Task<ResponseModel<CajaMovimientoResponse>> GetLast();
        Task<ResponseModel<List<CajaMovimientoResponse>>> GetAllByIdTurno(int idTurno);
        Task<ResponseModel<List<CajaMovimientoResponse>>> GetAllByFechaAndTipoMovimientoFormaPago(DateTime pFechaDesde, DateTime pFechaHasta, int pIdTipoMovimiento, int pIdFormaPago);
        Task<ResponseModel<CajaMovimientoResponse>> Insert(CajaMovimientoRequest entity);
        Task<ResponseModel<CajaMovimientoResponse>> Update(CajaMovimientoRequest entity);
        Task<ResponseModel<CajaMovimientoResponse>> Delete(int id);
    }
}
