using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ITicketService
    {
        Task<ResponseModel<List<TicketResponse>>> GetAll();
        Task<ResponseModel<List<TicketResponse>>> GetAllByIdTurno(int idTurno);
        Task<ResponseModel<TicketResponse>> GetById(int id);
        Task<ResponseModel<TicketResponse>> Insert(TicketRequest entity);
        Task<ResponseModel<TicketResponse>> Update(TicketRequest entity);
        Task<ResponseModel<TicketResponse>> Delete(int id);
    }
}
