using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IPromocionService
    {
        Task<ResponseModel<List<PromocionResponse>>> GetAll();
        Task<ResponseModel<PromocionResponse>> GetById(int id);
        Task<ResponseModel<PromocionResponse>> Insert(PromocionRequest entity);
        Task<ResponseModel<PromocionResponse>> Update(PromocionRequest entity);
        Task<ResponseModel<PromocionResponse>> Delete(int id);
    }
}
