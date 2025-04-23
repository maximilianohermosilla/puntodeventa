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
    public class TicketDetalleService : ITicketDetalleService
    {
        private readonly ITicketDetalleRepository _ticketDetalleRepository;
        private readonly IMapper _mapper;

        public TicketDetalleService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _ticketDetalleRepository = new TicketDetalleRepository(context);
            _mapper = config.CreateMapper();
        }

        public TicketDetalleService(ITicketDetalleRepository ticketDetalleRepository, IMapper mapper, ILogger<TicketDetalleService> logger)
        {
            _ticketDetalleRepository = ticketDetalleRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TicketDetalleResponse>> Delete(int id)
        {
            ResponseModel<TicketDetalleResponse> response = new ResponseModel<TicketDetalleResponse>();
            TicketDetalleResponse ticketDetalleResponse = new TicketDetalleResponse();
            try
            {
                var ticketDetalle = await _ticketDetalleRepository.GetById(id);

                if (ticketDetalle == null)
                {
                    response.statusCode = 404;
                    response.message = "El ticketDetalle seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _ticketDetalleRepository.Delete(ticketDetalle);
                ticketDetalleResponse = _mapper.Map<TicketDetalleResponse>(ticketDetalle);
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
            response.message = "TicketDetalle eliminado exitosamente";
            response.response = ticketDetalleResponse;
            return response;
        }

        public async Task<ResponseModel<List<TicketDetalleResponse>>> GetAll()
        {
            ResponseModel<List<TicketDetalleResponse>> response = new ResponseModel<List<TicketDetalleResponse>>();

            try
            {
                List<TicketDetalle> lista = await _ticketDetalleRepository.GetAll();
                List<TicketDetalleResponse> listaDTO = _mapper.Map<List<TicketDetalleResponse>>(lista);

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


        public async Task<ResponseModel<TicketDetalleResponse>> GetById(int IdTicketDetalle)
        {
            ResponseModel<TicketDetalleResponse> response = new ResponseModel<TicketDetalleResponse>();

            try
            {
                TicketDetalle ticketDetalle = await _ticketDetalleRepository.GetById(IdTicketDetalle);

                if (ticketDetalle == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El ticketDetalle seleccionado no existe";
                    response.response = null;
                    return response;
                }

                TicketDetalleResponse TicketDetalleResponse = _mapper.Map<TicketDetalleResponse>(ticketDetalle);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = TicketDetalleResponse;
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

        public async Task<ResponseModel<TicketDetalleResponse>> Insert(TicketDetalleRequest entity)
        {
            ResponseModel<TicketDetalleResponse> response = new ResponseModel<TicketDetalleResponse>();
            TicketDetalleResponse ticketDetalleResponse = new TicketDetalleResponse();
            try
            {
                TicketDetalle ticketDetalle = _mapper.Map<TicketDetalle>(entity);
                ticketDetalle = await _ticketDetalleRepository.Create(ticketDetalle);
                ticketDetalleResponse = _mapper.Map<TicketDetalleResponse>(ticketDetalle);
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
            response.message = "TicketDetalle insertado exitosamente";
            response.response = ticketDetalleResponse;
            return response;
        }


        public async Task<ResponseModel<TicketDetalleResponse>> Update(TicketDetalleRequest entity)
        {
            ResponseModel<TicketDetalleResponse> response = new ResponseModel<TicketDetalleResponse>();
            TicketDetalleResponse ticketDetalleResponse = new TicketDetalleResponse();
            try
            {
                var ticketDetalle = await _ticketDetalleRepository.GetById(entity.Id);

                if (ticketDetalle == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El ticketDetalle seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                ticketDetalle = _mapper.Map<TicketDetalleRequest, TicketDetalle>(entity, ticketDetalle);

                await _ticketDetalleRepository.SaveChangesAsync();
                ticketDetalleResponse = _mapper.Map<TicketDetalleResponse>(ticketDetalle);
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
            response.message = "TicketDetalle actualizado exitosamente";
            response.response = ticketDetalleResponse;
            return response;
        }
    }
}
