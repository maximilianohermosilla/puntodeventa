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
    public class ClienteService: IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _clienteRepository = new ClienteRepository(context);
            _mapper = config.CreateMapper();
        }

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper, ILogger<ClienteService> logger)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ClienteResponse>> Delete(int id)
        {
            ResponseModel<ClienteResponse> response = new ResponseModel<ClienteResponse>();
            ClienteResponse clienteResponse = new ClienteResponse();
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
                clienteResponse = _mapper.Map<ClienteResponse>(cliente);
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
            response.message = "Cliente eliminado exitosamente";
            response.response = clienteResponse;
            return response;
        }

        public async Task<ResponseModel<List<ClienteResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<ClienteResponse>> response = new ResponseModel<List<ClienteResponse>>();

            try
            {
                List<Cliente> lista = await _clienteRepository.GetAll(habilitados);
                List<ClienteResponse> listaDTO = _mapper.Map<List<ClienteResponse>>(lista);

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


        public async Task<ResponseModel<ClienteResponse>> GetById(int IdCliente)
        {
            ResponseModel<ClienteResponse> response = new ResponseModel<ClienteResponse>();

            try
            {
                Cliente cliente = await _clienteRepository.GetById(IdCliente);

                if (cliente == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El cliente seleccionado no existe";
                    response.response = null;
                    return response;
                }

                ClienteResponse ClienteResponse = _mapper.Map<ClienteResponse>(cliente);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = ClienteResponse;
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

        public async Task<ResponseModel<ClienteResponse>> Insert(ClienteRequest entity)
        {
            ResponseModel<ClienteResponse> response = new ResponseModel<ClienteResponse>();
            ClienteResponse clienteResponse = new ClienteResponse();
            try
            {
                Cliente cliente = _mapper.Map<Cliente>(entity);
                cliente = await _clienteRepository.Create(cliente);
                clienteResponse = _mapper.Map<ClienteResponse>(cliente);
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
            response.message = "Cliente insertado exitosamente";
            response.response = clienteResponse;
            return response;
        }


        public async Task<ResponseModel<ClienteResponse>> Update(ClienteRequest entity)
        {
            ResponseModel<ClienteResponse> response = new ResponseModel<ClienteResponse>();
            ClienteResponse clienteResponse = new ClienteResponse();
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
                                
                cliente = _mapper.Map<ClienteRequest, Cliente>(entity, cliente);

                await _clienteRepository.SaveChangesAsync();
                clienteResponse = _mapper.Map<ClienteResponse>(cliente);
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
            response.message = "Cliente actualizado exitosamente";
            response.response = clienteResponse;
            return response;
        }
    }
}
