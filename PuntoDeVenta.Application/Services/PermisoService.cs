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
    public class PermisoService : IPermisoService
    {
        private readonly IPermisoRepository _permisoRepository;
        private readonly IMapper _mapper;

        public PermisoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _permisoRepository = new PermisoRepository(context);
            _mapper = config.CreateMapper();
        }

        public PermisoService(IPermisoRepository permisoRepository, IMapper mapper, ILogger<PermisoService> logger)
        {
            _permisoRepository = permisoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PermisoResponse>> Delete(int id)
        {
            ResponseModel<PermisoResponse> response = new ResponseModel<PermisoResponse>();
            PermisoResponse permisoResponse = new PermisoResponse();
            try
            {
                var permiso = await _permisoRepository.GetById(id);

                if (permiso == null)
                {
                    response.statusCode = 404;
                    response.message = "El permiso seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _permisoRepository.Delete(permiso);
                permisoResponse = _mapper.Map<PermisoResponse>(permiso);
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
            response.message = "Permiso eliminado exitosamente";
            response.response = permisoResponse;
            return response;
        }

        public async Task<ResponseModel<List<PermisoResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<PermisoResponse>> response = new ResponseModel<List<PermisoResponse>>();

            try
            {
                List<Permiso> lista = await _permisoRepository.GetAll(habilitados);
                List<PermisoResponse> listaDTO = _mapper.Map<List<PermisoResponse>>(lista);

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


        public async Task<ResponseModel<PermisoResponse>> GetById(int IdPermiso)
        {
            ResponseModel<PermisoResponse> response = new ResponseModel<PermisoResponse>();

            try
            {
                Permiso permiso = await _permisoRepository.GetById(IdPermiso);

                if (permiso == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El permiso seleccionado no existe";
                    response.response = null;
                    return response;
                }

                PermisoResponse PermisoResponse = _mapper.Map<PermisoResponse>(permiso);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = PermisoResponse;
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

        public async Task<ResponseModel<PermisoResponse>> Insert(PermisoRequest entity)
        {
            ResponseModel<PermisoResponse> response = new ResponseModel<PermisoResponse>();
            PermisoResponse permisoResponse = new PermisoResponse();
            try
            {
                Permiso permiso = _mapper.Map<Permiso>(entity);
                permiso = await _permisoRepository.Create(permiso);
                permisoResponse = _mapper.Map<PermisoResponse>(permiso);
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
            response.message = "Permiso insertado exitosamente";
            response.response = permisoResponse;
            return response;
        }


        public async Task<ResponseModel<PermisoResponse>> Update(PermisoRequest entity)
        {
            ResponseModel<PermisoResponse> response = new ResponseModel<PermisoResponse>();
            PermisoResponse permisoResponse = new PermisoResponse();
            try
            {
                var permiso = await _permisoRepository.GetById(entity.Id);

                if (permiso == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El permiso seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                permiso = _mapper.Map<PermisoRequest, Permiso>(entity, permiso);

                await _permisoRepository.SaveChangesAsync();
                permisoResponse = _mapper.Map<PermisoResponse>(permiso);
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
            response.message = "Permiso actualizado exitosamente";
            response.response = permisoResponse;
            return response;
        }
    }
}
