using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IPromocionCategoriaService
    {
        Task<ResponseModel<List<PromocionCategoriaResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<PromocionCategoriaResponse>> GetById(int id);
        Task<ResponseModel<PromocionCategoriaResponse>> Insert(PromocionCategoriaRequest entity);
        Task<ResponseModel<PromocionCategoriaResponse>> Update(PromocionCategoriaRequest entity);
        Task<ResponseModel<PromocionCategoriaResponse>> Delete(int id);
    }
}
