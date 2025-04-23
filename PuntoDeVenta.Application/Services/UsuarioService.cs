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
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _usuarioRepository = new UsuarioRepository(context);
            _mapper = config.CreateMapper();
        }

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper, ILogger<UsuarioService> logger)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<UsuarioResponse>> Delete(int id)
        {
            ResponseModel<UsuarioResponse> response = new ResponseModel<UsuarioResponse>();
            UsuarioResponse usuarioResponse = new UsuarioResponse();
            try
            {
                var usuario = await _usuarioRepository.GetById(id);

                if (usuario == null)
                {
                    response.statusCode = 404;
                    response.message = "El usuario seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _usuarioRepository.Delete(usuario);
                usuarioResponse = _mapper.Map<UsuarioResponse>(usuario);
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
            response.message = "Usuario eliminado exitosamente";
            response.response = usuarioResponse;
            return response;
        }

        public async Task<ResponseModel<List<UsuarioResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<UsuarioResponse>> response = new ResponseModel<List<UsuarioResponse>>();

            try
            {
                List<Usuario> lista = await _usuarioRepository.GetAll(habilitados);
                List<UsuarioResponse> listaDTO = _mapper.Map<List<UsuarioResponse>>(lista);

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


        public async Task<ResponseModel<UsuarioResponse>> GetById(int IdUsuario)
        {
            ResponseModel<UsuarioResponse> response = new ResponseModel<UsuarioResponse>();

            try
            {
                Usuario usuario = await _usuarioRepository.GetById(IdUsuario);

                if (usuario == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El usuario seleccionado no existe";
                    response.response = null;
                    return response;
                }

                UsuarioResponse UsuarioResponse = _mapper.Map<UsuarioResponse>(usuario);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = UsuarioResponse;
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

        public async Task<ResponseModel<UsuarioResponse>> Insert(UsuarioRequest entity)
        {
            ResponseModel<UsuarioResponse> response = new ResponseModel<UsuarioResponse>();
            UsuarioResponse usuarioResponse = new UsuarioResponse();
            try
            {
                Usuario usuario = _mapper.Map<Usuario>(entity);
                usuario = await _usuarioRepository.Create(usuario);
                usuarioResponse = _mapper.Map<UsuarioResponse>(usuario);
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
            response.message = "Usuario insertado exitosamente";
            response.response = usuarioResponse;
            return response;
        }


        public async Task<ResponseModel<UsuarioResponse>> Update(UsuarioRequest entity)
        {
            ResponseModel<UsuarioResponse> response = new ResponseModel<UsuarioResponse>();
            UsuarioResponse usuarioResponse = new UsuarioResponse();
            try
            {
                var usuario = await _usuarioRepository.GetById(entity.Id);

                if (usuario == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El usuario seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                usuario = _mapper.Map<UsuarioRequest, Usuario>(entity, usuario);

                await _usuarioRepository.SaveChangesAsync();
                usuarioResponse = _mapper.Map<UsuarioResponse>(usuario);
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
            response.message = "Usuario actualizado exitosamente";
            response.response = usuarioResponse;
            return response;
        }
    }
}
