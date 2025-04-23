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
    public class PermisoUsuarioService : IPermisoUsuarioService
    {
        private readonly IPermisoUsuarioRepository _permisoUsuarioRepository;
        private readonly IMapper _mapper;

        public PermisoUsuarioService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _permisoUsuarioRepository = new PermisoUsuarioRepository(context);
            _mapper = config.CreateMapper();
        }

        public PermisoUsuarioService(IPermisoUsuarioRepository permisoUsuarioRepository, IMapper mapper, ILogger<PermisoUsuarioService> logger)
        {
            _permisoUsuarioRepository = permisoUsuarioRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PermisoUsuarioResponse>> Delete(int id)
        {
            ResponseModel<PermisoUsuarioResponse> response = new ResponseModel<PermisoUsuarioResponse>();
            PermisoUsuarioResponse permisoUsuarioResponse = new PermisoUsuarioResponse();
            try
            {
                var permisoUsuario = await _permisoUsuarioRepository.GetById(id);

                if (permisoUsuario == null)
                {
                    response.statusCode = 404;
                    response.message = "El permisoUsuario seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _permisoUsuarioRepository.Delete(permisoUsuario);
                permisoUsuarioResponse = _mapper.Map<PermisoUsuarioResponse>(permisoUsuario);
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
            response.message = "PermisoUsuario eliminado exitosamente";
            response.response = permisoUsuarioResponse;
            return response;
        }

        public async Task<ResponseModel<List<PermisoUsuarioResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<PermisoUsuarioResponse>> response = new ResponseModel<List<PermisoUsuarioResponse>>();

            try
            {
                List<PermisoUsuario> lista = await _permisoUsuarioRepository.GetAll(habilitados);
                List<PermisoUsuarioResponse> listaDTO = _mapper.Map<List<PermisoUsuarioResponse>>(lista);

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


        public async Task<ResponseModel<PermisoUsuarioResponse>> GetById(int IdPermisoUsuario)
        {
            ResponseModel<PermisoUsuarioResponse> response = new ResponseModel<PermisoUsuarioResponse>();

            try
            {
                PermisoUsuario permisoUsuario = await _permisoUsuarioRepository.GetById(IdPermisoUsuario);

                if (permisoUsuario == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El permisoUsuario seleccionado no existe";
                    response.response = null;
                    return response;
                }

                PermisoUsuarioResponse PermisoUsuarioResponse = _mapper.Map<PermisoUsuarioResponse>(permisoUsuario);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = PermisoUsuarioResponse;
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

        public async Task<ResponseModel<PermisoUsuarioResponse>> Insert(PermisoUsuarioRequest entity)
        {
            ResponseModel<PermisoUsuarioResponse> response = new ResponseModel<PermisoUsuarioResponse>();
            PermisoUsuarioResponse permisoUsuarioResponse = new PermisoUsuarioResponse();
            try
            {
                PermisoUsuario permisoUsuario = _mapper.Map<PermisoUsuario>(entity);
                permisoUsuario = await _permisoUsuarioRepository.Create(permisoUsuario);
                permisoUsuarioResponse = _mapper.Map<PermisoUsuarioResponse>(permisoUsuario);
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
            response.message = "PermisoUsuario insertado exitosamente";
            response.response = permisoUsuarioResponse;
            return response;
        }


        public async Task<ResponseModel<PermisoUsuarioResponse>> Update(PermisoUsuarioRequest entity)
        {
            ResponseModel<PermisoUsuarioResponse> response = new ResponseModel<PermisoUsuarioResponse>();
            PermisoUsuarioResponse permisoUsuarioResponse = new PermisoUsuarioResponse();
            try
            {
                var permisoUsuario = await _permisoUsuarioRepository.GetById(entity.Id);

                if (permisoUsuario == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El permisoUsuario seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                permisoUsuario = _mapper.Map<PermisoUsuarioRequest, PermisoUsuario>(entity, permisoUsuario);

                await _permisoUsuarioRepository.SaveChangesAsync();
                permisoUsuarioResponse = _mapper.Map<PermisoUsuarioResponse>(permisoUsuario);
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
            response.message = "PermisoUsuario actualizado exitosamente";
            response.response = permisoUsuarioResponse;
            return response;
        }
    }
}
