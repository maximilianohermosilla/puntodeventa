using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ITipoMovimientoService
    {
        Task<ResponseModel<List<TipoMovimientoResponse>>> GetAll();
        Task<ResponseModel<TipoMovimientoResponse>> GetById(int id);
        Task<ResponseModel<TipoMovimientoResponse>> Insert(TipoMovimientoRequest entity);
        Task<ResponseModel<TipoMovimientoResponse>> Update(TipoMovimientoRequest entity);
        Task<ResponseModel<TipoMovimientoResponse>> Delete(int id);
    }
}
