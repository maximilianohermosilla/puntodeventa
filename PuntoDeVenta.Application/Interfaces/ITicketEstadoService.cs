using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ITicketEstadoService
    {
        Task<ResponseModel<List<TicketEstadoResponse>>> GetAll();
        Task<ResponseModel<TicketEstadoResponse>> GetById(int id);
        Task<ResponseModel<TicketEstadoResponse>> Insert(TicketEstadoRequest entity);
        Task<ResponseModel<TicketEstadoResponse>> Update(TicketEstadoRequest entity);
        Task<ResponseModel<TicketEstadoResponse>> Delete(int id);
    }
}
