using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ResponseModel<List<ClienteResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<ClienteResponse>> GetById(int id);
        Task<ResponseModel<ClienteResponse>> Insert(ClienteRequest entity);
        Task<ResponseModel<ClienteResponse>> Update(ClienteRequest entity);
        Task<ResponseModel<ClienteResponse>> Delete(int id);
    }
}
