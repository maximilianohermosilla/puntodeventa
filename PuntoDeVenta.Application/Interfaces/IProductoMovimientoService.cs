using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IProductoMovimientoService
    {
        Task<ResponseModel<List<ProductoMovimientoResponse>>> GetAllByFechaAndTipoMovimiento(DateTime pFechaDesde, DateTime pFechaHasta, int pIdTipoMovimiento);
        Task<ResponseModel<ProductoMovimientoResponse>> GetById(int id);
        Task<ResponseModel<ProductoMovimientoResponse>> Insert(ProductoMovimientoRequest entity);
        Task<ResponseModel<ProductoMovimientoResponse>> Update(ProductoMovimientoRequest entity);
        Task<ResponseModel<ProductoMovimientoResponse>> Delete(int id);
    }
}
