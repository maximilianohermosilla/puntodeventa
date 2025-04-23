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
    public class TicketEstadoService : ITicketEstadoService
    {
        private readonly ITicketEstadoRepository _ticketEstadoRepository;
        private readonly IMapper _mapper;

        public TicketEstadoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _ticketEstadoRepository = new TicketEstadoRepository(context);
            _mapper = config.CreateMapper();
        }

        public TicketEstadoService(ITicketEstadoRepository ticketEstadoRepository, IMapper mapper, ILogger<TicketEstadoService> logger)
        {
            _ticketEstadoRepository = ticketEstadoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TicketEstadoResponse>> Delete(int id)
        {
            ResponseModel<TicketEstadoResponse> response = new ResponseModel<TicketEstadoResponse>();
            TicketEstadoResponse ticketEstadoResponse = new TicketEstadoResponse();
            try
            {
                var ticketEstado = await _ticketEstadoRepository.GetById(id);

                if (ticketEstado == null)
                {
                    response.statusCode = 404;
                    response.message = "El ticketEstado seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _ticketEstadoRepository.Delete(ticketEstado);
                ticketEstadoResponse = _mapper.Map<TicketEstadoResponse>(ticketEstado);
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
            response.message = "TicketEstado eliminado exitosamente";
            response.response = ticketEstadoResponse;
            return response;
        }

        public async Task<ResponseModel<List<TicketEstadoResponse>>> GetAll()
        {
            ResponseModel<List<TicketEstadoResponse>> response = new ResponseModel<List<TicketEstadoResponse>>();

            try
            {
                List<TicketEstado> lista = await _ticketEstadoRepository.GetAll();
                List<TicketEstadoResponse> listaDTO = _mapper.Map<List<TicketEstadoResponse>>(lista);

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


        public async Task<ResponseModel<TicketEstadoResponse>> GetById(int IdTicketEstado)
        {
            ResponseModel<TicketEstadoResponse> response = new ResponseModel<TicketEstadoResponse>();

            try
            {
                TicketEstado ticketEstado = await _ticketEstadoRepository.GetById(IdTicketEstado);

                if (ticketEstado == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El ticketEstado seleccionado no existe";
                    response.response = null;
                    return response;
                }

                TicketEstadoResponse TicketEstadoResponse = _mapper.Map<TicketEstadoResponse>(ticketEstado);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = TicketEstadoResponse;
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

        public async Task<ResponseModel<TicketEstadoResponse>> Insert(TicketEstadoRequest entity)
        {
            ResponseModel<TicketEstadoResponse> response = new ResponseModel<TicketEstadoResponse>();
            TicketEstadoResponse ticketEstadoResponse = new TicketEstadoResponse();
            try
            {
                TicketEstado ticketEstado = _mapper.Map<TicketEstado>(entity);
                ticketEstado = await _ticketEstadoRepository.Create(ticketEstado);
                ticketEstadoResponse = _mapper.Map<TicketEstadoResponse>(ticketEstado);
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
            response.message = "TicketEstado insertado exitosamente";
            response.response = ticketEstadoResponse;
            return response;
        }


        public async Task<ResponseModel<TicketEstadoResponse>> Update(TicketEstadoRequest entity)
        {
            ResponseModel<TicketEstadoResponse> response = new ResponseModel<TicketEstadoResponse>();
            TicketEstadoResponse ticketEstadoResponse = new TicketEstadoResponse();
            try
            {
                var ticketEstado = await _ticketEstadoRepository.GetById(entity.Id);

                if (ticketEstado == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El ticketEstado seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                ticketEstado = _mapper.Map<TicketEstadoRequest, TicketEstado>(entity, ticketEstado);

                await _ticketEstadoRepository.SaveChangesAsync();
                ticketEstadoResponse = _mapper.Map<TicketEstadoResponse>(ticketEstado);
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
            response.message = "TicketEstado actualizado exitosamente";
            response.response = ticketEstadoResponse;
            return response;
        }
    }
}
