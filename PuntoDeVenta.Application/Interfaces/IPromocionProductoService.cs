using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IPromocionProductoService
    {
        Task<ResponseModel<List<PromocionProductoResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<PromocionProductoResponse>> GetById(int id);
        Task<ResponseModel<PromocionProductoResponse>> Insert(PromocionProductoRequest entity);
        Task<ResponseModel<PromocionProductoResponse>> Update(PromocionProductoRequest entity);
        Task<ResponseModel<PromocionProductoResponse>> Delete(int id);
    }
}
