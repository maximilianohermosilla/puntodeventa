using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ITicketDetalleService
    {
        Task<ResponseModel<List<TicketDetalleResponse>>> GetAll();
        Task<ResponseModel<TicketDetalleResponse>> GetById(int id);
        Task<ResponseModel<TicketDetalleResponse>> Insert(TicketDetalleRequest entity);
        Task<ResponseModel<TicketDetalleResponse>> Update(TicketDetalleRequest entity);
        Task<ResponseModel<TicketDetalleResponse>> Delete(int id);
    }
}
