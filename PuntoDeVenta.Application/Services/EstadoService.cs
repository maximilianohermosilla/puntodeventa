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
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoRepository _clienteRepository;
        private readonly IMapper _mapper;

        public EstadoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _clienteRepository = new EstadoRepository(context);
            _mapper = config.CreateMapper();
        }

        public EstadoService(IEstadoRepository clienteRepository, IMapper mapper, ILogger<EstadoService> logger)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<EstadoResponse>> Delete(int id)
        {
            ResponseModel<EstadoResponse> response = new ResponseModel<EstadoResponse>();
            EstadoResponse clienteResponse = new EstadoResponse();
            try
            {
                var cliente = await _clienteRepository.GetById(id);

                if (cliente == null)
                {
                    response.statusCode = 404;
                    response.message = "El cliente seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _clienteRepository.Delete(cliente);
                clienteResponse = _mapper.Map<EstadoResponse>(cliente);
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
            response.message = "Estado eliminado exitosamente";
            response.response = clienteResponse;
            return response;
        }

        public async Task<ResponseModel<List<EstadoResponse>>> GetAll()
        {
            ResponseModel<List<EstadoResponse>> response = new ResponseModel<List<EstadoResponse>>();

            try
            {
                List<Estado> lista = await _clienteRepository.GetAll();
                List<EstadoResponse> listaDTO = _mapper.Map<List<EstadoResponse>>(lista);

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


        public async Task<ResponseModel<EstadoResponse>> GetById(int IdEstado)
        {
            ResponseModel<EstadoResponse> response = new ResponseModel<EstadoResponse>();

            try
            {
                Estado cliente = await _clienteRepository.GetById(IdEstado);

                if (cliente == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El cliente seleccionado no existe";
                    response.response = null;
                    return response;
                }

                EstadoResponse EstadoResponse = _mapper.Map<EstadoResponse>(cliente);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = EstadoResponse;
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

        public async Task<ResponseModel<EstadoResponse>> Insert(EstadoRequest entity)
        {
            ResponseModel<EstadoResponse> response = new ResponseModel<EstadoResponse>();
            EstadoResponse clienteResponse = new EstadoResponse();
            try
            {
                Estado cliente = _mapper.Map<Estado>(entity);
                cliente = await _clienteRepository.Create(cliente);
                clienteResponse = _mapper.Map<EstadoResponse>(cliente);
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
            response.message = "Estado insertado exitosamente";
            response.response = clienteResponse;
            return response;
        }


        public async Task<ResponseModel<EstadoResponse>> Update(EstadoRequest entity)
        {
            ResponseModel<EstadoResponse> response = new ResponseModel<EstadoResponse>();
            EstadoResponse clienteResponse = new EstadoResponse();
            try
            {
                var cliente = await _clienteRepository.GetById(entity.Id);

                if (cliente == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El cliente seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                cliente = _mapper.Map<EstadoRequest, Estado>(entity, cliente);

                await _clienteRepository.SaveChangesAsync();
                clienteResponse = _mapper.Map<EstadoResponse>(cliente);
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
            response.message = "Estado actualizado exitosamente";
            response.response = clienteResponse;
            return response;
        }
    }
}
