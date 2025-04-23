using AutoMapper;
using Microsoft.Extensions.Logging;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Domain.Entities;
using PuntoDeVenta.AccessData.Repository;
using PuntoDeVenta.AccessData;
using PuntoDeVenta.Application.Profiles;

namespace PuntoDeVenta.Application.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public TicketService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _ticketRepository = new TicketRepository(context);
            _mapper = config.CreateMapper();
        }

        public TicketService(ITicketRepository ticketRepository, IMapper mapper, ILogger<TicketService> logger)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TicketResponse>> Delete(int id)
        {
            ResponseModel<TicketResponse> response = new ResponseModel<TicketResponse>();
            TicketResponse ticketResponse = new TicketResponse();
            try
            {
                var ticket = await _ticketRepository.GetById(id);

                if (ticket == null)
                {
                    response.statusCode = 404;
                    response.message = "El ticket seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _ticketRepository.Delete(ticket);
                ticketResponse = _mapper.Map<TicketResponse>(ticket);
            }
            catch (Exception ex)
            {
                response.success = false;
                response.statusCode = 400;
                response.message = ex.Message;
                response.response = null;
                return response;
            }

            response.statusCode = 200;
            response.message = "Ticket eliminado exitosamente";
            response.response = ticketResponse;
            return response;
        }

        public async Task<ResponseModel<List<TicketResponse>>> GetAll()
        {
            ResponseModel<List<TicketResponse>> response = new ResponseModel<List<TicketResponse>>();

            try
            {
                List<Ticket> lista = await _ticketRepository.GetAll();
                List<TicketResponse> listaDTO = _mapper.Map<List<TicketResponse>>(lista);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = listaDTO;
            }
            catch (Exception ex)
            {
                response.success = false;
                response.statusCode = 400;
                response.message = ex.Message;
                response.response = null;
            }

            return response;
        }


        public async Task<ResponseModel<TicketResponse>> GetById(int IdTicket)
        {
            ResponseModel<TicketResponse> response = new ResponseModel<TicketResponse>();

            try
            {
                Ticket ticket = await _ticketRepository.GetById(IdTicket);

                if (ticket == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El ticket seleccionado no existe";
                    response.response = null;
                    return response;
                }

                TicketResponse TicketResponse = _mapper.Map<TicketResponse>(ticket);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = TicketResponse;
            }
            catch (Exception ex)
            {
                response.success = false;
                response.statusCode = 400;
                response.message = ex.Message;
                response.response = null;
            }

            return response;
        }

        public async Task<ResponseModel<TicketResponse>> Insert(TicketRequest entity)
        {
            ResponseModel<TicketResponse> response = new ResponseModel<TicketResponse>();
            TicketResponse ticketResponse = new TicketResponse();
            try
            {
                Ticket ticket = _mapper.Map<Ticket>(entity);
                ticket = await _ticketRepository.Create(ticket);
                ticketResponse = _mapper.Map<TicketResponse>(ticket);
            }
            catch (Exception ex)
            {
                response.success = false;
                response.statusCode = 400;
                response.message = ex.Message + ": " + (ex.InnerException != null ? ex.InnerException!.Message : "");
                response.response = null;
                return response;
            }

            response.success = true;
            response.statusCode = 201;
            response.message = "Ticket insertado exitosamente";
            response.response = ticketResponse;
            return response;
        }


        public async Task<ResponseModel<TicketResponse>> Update(TicketRequest entity)
        {
            ResponseModel<TicketResponse> response = new ResponseModel<TicketResponse>();
            TicketResponse ticketResponse = new TicketResponse();
            try
            {
                var ticket = await _ticketRepository.GetById(entity.Id);

                if (ticket == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El ticket seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                ticket = _mapper.Map<TicketRequest, Ticket>(entity, ticket);

                await _ticketRepository.SaveChangesAsync();
                ticketResponse = _mapper.Map<TicketResponse>(ticket);
            }
            catch (Exception ex)
            {
                response.success = false;
                response.statusCode = 400;
                response.message = ex.Message + ": " + (ex.InnerException != null ? ex.InnerException!.Message : "");
                response.response = null;
                return response;
            }

            response.statusCode = 200;
            response.message = "Ticket actualizado exitosamente";
            response.response = ticketResponse;
            return response;
        }
    }
}
