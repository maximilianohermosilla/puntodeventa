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
    public class PermisoPerfilService : IPermisoPerfilService
    {
        private readonly IPermisoPerfilRepository _permisoPerfilRepository;
        private readonly IMapper _mapper;

        public PermisoPerfilService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _permisoPerfilRepository = new PermisoPerfilRepository(context);
            _mapper = config.CreateMapper();
        }

        public PermisoPerfilService(IPermisoPerfilRepository permisoPerfilRepository, IMapper mapper, ILogger<PermisoPerfilService> logger)
        {
            _permisoPerfilRepository = permisoPerfilRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PermisoPerfilResponse>> Delete(int id)
        {
            ResponseModel<PermisoPerfilResponse> response = new ResponseModel<PermisoPerfilResponse>();
            PermisoPerfilResponse permisoPerfilResponse = new PermisoPerfilResponse();
            try
            {
                var permisoPerfil = await _permisoPerfilRepository.GetById(id);

                if (permisoPerfil == null)
                {
                    response.statusCode = 404;
                    response.message = "El permisoPerfil seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _permisoPerfilRepository.Delete(permisoPerfil);
                permisoPerfilResponse = _mapper.Map<PermisoPerfilResponse>(permisoPerfil);
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
            response.message = "PermisoPerfil eliminado exitosamente";
            response.response = permisoPerfilResponse;
            return response;
        }

        public async Task<ResponseModel<List<PermisoPerfilResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<PermisoPerfilResponse>> response = new ResponseModel<List<PermisoPerfilResponse>>();

            try
            {
                List<PermisoPerfil> lista = await _permisoPerfilRepository.GetAll(habilitados);
                List<PermisoPerfilResponse> listaDTO = _mapper.Map<List<PermisoPerfilResponse>>(lista);

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


        public async Task<ResponseModel<PermisoPerfilResponse>> GetById(int IdPermisoPerfil)
        {
            ResponseModel<PermisoPerfilResponse> response = new ResponseModel<PermisoPerfilResponse>();

            try
            {
                PermisoPerfil permisoPerfil = await _permisoPerfilRepository.GetById(IdPermisoPerfil);

                if (permisoPerfil == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El permisoPerfil seleccionado no existe";
                    response.response = null;
                    return response;
                }

                PermisoPerfilResponse PermisoPerfilResponse = _mapper.Map<PermisoPerfilResponse>(permisoPerfil);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = PermisoPerfilResponse;
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

        public async Task<ResponseModel<PermisoPerfilResponse>> Insert(PermisoPerfilRequest entity)
        {
            ResponseModel<PermisoPerfilResponse> response = new ResponseModel<PermisoPerfilResponse>();
            PermisoPerfilResponse permisoPerfilResponse = new PermisoPerfilResponse();
            try
            {
                PermisoPerfil permisoPerfil = _mapper.Map<PermisoPerfil>(entity);
                permisoPerfil = await _permisoPerfilRepository.Create(permisoPerfil);
                permisoPerfilResponse = _mapper.Map<PermisoPerfilResponse>(permisoPerfil);
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
            response.message = "PermisoPerfil insertado exitosamente";
            response.response = permisoPerfilResponse;
            return response;
        }


        public async Task<ResponseModel<PermisoPerfilResponse>> Update(PermisoPerfilRequest entity)
        {
            ResponseModel<PermisoPerfilResponse> response = new ResponseModel<PermisoPerfilResponse>();
            PermisoPerfilResponse permisoPerfilResponse = new PermisoPerfilResponse();
            try
            {
                var permisoPerfil = await _permisoPerfilRepository.GetById(entity.Id);

                if (permisoPerfil == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El permisoPerfil seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                permisoPerfil = _mapper.Map<PermisoPerfilRequest, PermisoPerfil>(entity, permisoPerfil);

                await _permisoPerfilRepository.SaveChangesAsync();
                permisoPerfilResponse = _mapper.Map<PermisoPerfilResponse>(permisoPerfil);
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
            response.message = "PermisoPerfil actualizado exitosamente";
            response.response = permisoPerfilResponse;
            return response;
        }
    }
}
