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
    public class TipoPermisoService : ITipoPermisoService
    {
        private readonly ITipoPermisoRepository _tipoPermisoRepository;
        private readonly IMapper _mapper;

        public TipoPermisoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _tipoPermisoRepository = new TipoPermisoRepository(context);
            _mapper = config.CreateMapper();
        }

        public TipoPermisoService(ITipoPermisoRepository tipoPermisoRepository, IMapper mapper, ILogger<TipoPermisoService> logger)
        {
            _tipoPermisoRepository = tipoPermisoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TipoPermisoResponse>> Delete(int id)
        {
            ResponseModel<TipoPermisoResponse> response = new ResponseModel<TipoPermisoResponse>();
            TipoPermisoResponse tipoPermisoResponse = new TipoPermisoResponse();
            try
            {
                var tipoPermiso = await _tipoPermisoRepository.GetById(id);

                if (tipoPermiso == null)
                {
                    response.statusCode = 404;
                    response.message = "El tipo de permiso seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _tipoPermisoRepository.Delete(tipoPermiso);
                tipoPermisoResponse = _mapper.Map<TipoPermisoResponse>(tipoPermiso);
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
            response.message = "Tipo de Permiso eliminado exitosamente";
            response.response = tipoPermisoResponse;
            return response;
        }

        public async Task<ResponseModel<List<TipoPermisoResponse>>> GetAll()
        {
            ResponseModel<List<TipoPermisoResponse>> response = new ResponseModel<List<TipoPermisoResponse>>();

            try
            {
                List<TipoPermiso> lista = await _tipoPermisoRepository.GetAll();
                List<TipoPermisoResponse> listaDTO = _mapper.Map<List<TipoPermisoResponse>>(lista);

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


        public async Task<ResponseModel<TipoPermisoResponse>> GetById(int IdTipoPermiso)
        {
            ResponseModel<TipoPermisoResponse> response = new ResponseModel<TipoPermisoResponse>();

            try
            {
                TipoPermiso tipoPermiso = await _tipoPermisoRepository.GetById(IdTipoPermiso);

                if (tipoPermiso == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El tipo de permiso seleccionado no existe";
                    response.response = null;
                    return response;
                }

                TipoPermisoResponse TipoPermisoResponse = _mapper.Map<TipoPermisoResponse>(tipoPermiso);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = TipoPermisoResponse;
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

        public async Task<ResponseModel<TipoPermisoResponse>> Insert(TipoPermisoRequest entity)
        {
            ResponseModel<TipoPermisoResponse> response = new ResponseModel<TipoPermisoResponse>();
            TipoPermisoResponse tipoPermisoResponse = new TipoPermisoResponse();
            try
            {
                TipoPermiso tipoPermiso = _mapper.Map<TipoPermiso>(entity);
                tipoPermiso = await _tipoPermisoRepository.Create(tipoPermiso);
                tipoPermisoResponse = _mapper.Map<TipoPermisoResponse>(tipoPermiso);
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
            response.message = "Tipo de Permiso insertado exitosamente";
            response.response = tipoPermisoResponse;
            return response;
        }


        public async Task<ResponseModel<TipoPermisoResponse>> Update(TipoPermisoRequest entity)
        {
            ResponseModel<TipoPermisoResponse> response = new ResponseModel<TipoPermisoResponse>();
            TipoPermisoResponse tipoPermisoResponse = new TipoPermisoResponse();
            try
            {
                var tipoPermiso = await _tipoPermisoRepository.GetById(entity.Id);

                if (tipoPermiso == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El tipo de permiso seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                tipoPermiso = _mapper.Map<TipoPermisoRequest, TipoPermiso>(entity, tipoPermiso);

                await _tipoPermisoRepository.SaveChangesAsync();
                tipoPermisoResponse = _mapper.Map<TipoPermisoResponse>(tipoPermiso);
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
            response.message = "Tipo de Permiso actualizado exitosamente";
            response.response = tipoPermisoResponse;
            return response;
        }
    }
}
