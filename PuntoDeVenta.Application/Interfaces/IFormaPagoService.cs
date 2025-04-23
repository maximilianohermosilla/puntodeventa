using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IFormaPagoService
    {
        Task<ResponseModel<List<FormaPagoResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<FormaPagoResponse>> GetById(int id);
        Task<ResponseModel<FormaPagoResponse>> Insert(FormaPagoRequest entity);
        Task<ResponseModel<FormaPagoResponse>> Update(FormaPagoRequest entity);
        Task<ResponseModel<FormaPagoResponse>> Delete(int id);
    }
}
