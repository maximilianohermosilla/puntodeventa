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
    public class TipoMovimientoService : ITipoMovimientoService
    {
        private readonly ITipoMovimientoRepository _tipoMovimientoRepository;
        private readonly IMapper _mapper;

        public TipoMovimientoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _tipoMovimientoRepository = new TipoMovimientoRepository(context);
            _mapper = config.CreateMapper();
        }

        public TipoMovimientoService(ITipoMovimientoRepository tipoMovimientoRepository, IMapper mapper, ILogger<TipoMovimientoService> logger)
        {
            _tipoMovimientoRepository = tipoMovimientoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TipoMovimientoResponse>> Delete(int id)
        {
            ResponseModel<TipoMovimientoResponse> response = new ResponseModel<TipoMovimientoResponse>();
            TipoMovimientoResponse tipoMovimientoResponse = new TipoMovimientoResponse();
            try
            {
                var tipoMovimiento = await _tipoMovimientoRepository.GetById(id);

                if (tipoMovimiento == null)
                {
                    response.statusCode = 404;
                    response.message = "El tipo de movimiento seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _tipoMovimientoRepository.Delete(tipoMovimiento);
                tipoMovimientoResponse = _mapper.Map<TipoMovimientoResponse>(tipoMovimiento);
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
            response.message = "Tipo de Movimiento eliminado exitosamente";
            response.response = tipoMovimientoResponse;
            return response;
        }

        public async Task<ResponseModel<List<TipoMovimientoResponse>>> GetAll()
        {
            ResponseModel<List<TipoMovimientoResponse>> response = new ResponseModel<List<TipoMovimientoResponse>>();

            try
            {
                List<TipoMovimiento> lista = await _tipoMovimientoRepository.GetAll();
                List<TipoMovimientoResponse> listaDTO = _mapper.Map<List<TipoMovimientoResponse>>(lista);

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


        public async Task<ResponseModel<TipoMovimientoResponse>> GetById(int IdTipoMovimiento)
        {
            ResponseModel<TipoMovimientoResponse> response = new ResponseModel<TipoMovimientoResponse>();

            try
            {
                TipoMovimiento tipoMovimiento = await _tipoMovimientoRepository.GetById(IdTipoMovimiento);

                if (tipoMovimiento == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El tipo de movimiento seleccionado no existe";
                    response.response = null;
                    return response;
                }

                TipoMovimientoResponse TipoMovimientoResponse = _mapper.Map<TipoMovimientoResponse>(tipoMovimiento);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = TipoMovimientoResponse;
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

        public async Task<ResponseModel<TipoMovimientoResponse>> Insert(TipoMovimientoRequest entity)
        {
            ResponseModel<TipoMovimientoResponse> response = new ResponseModel<TipoMovimientoResponse>();
            TipoMovimientoResponse tipoMovimientoResponse = new TipoMovimientoResponse();
            try
            {
                TipoMovimiento tipoMovimiento = _mapper.Map<TipoMovimiento>(entity);
                tipoMovimiento = await _tipoMovimientoRepository.Create(tipoMovimiento);
                tipoMovimientoResponse = _mapper.Map<TipoMovimientoResponse>(tipoMovimiento);
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
            response.message = "Tipo de Movimiento insertado exitosamente";
            response.response = tipoMovimientoResponse;
            return response;
        }


        public async Task<ResponseModel<TipoMovimientoResponse>> Update(TipoMovimientoRequest entity)
        {
            ResponseModel<TipoMovimientoResponse> response = new ResponseModel<TipoMovimientoResponse>();
            TipoMovimientoResponse tipoMovimientoResponse = new TipoMovimientoResponse();
            try
            {
                var tipoMovimiento = await _tipoMovimientoRepository.GetById(entity.Id);

                if (tipoMovimiento == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El tipo de movimiento seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                tipoMovimiento = _mapper.Map<TipoMovimientoRequest, TipoMovimiento>(entity, tipoMovimiento);

                await _tipoMovimientoRepository.SaveChangesAsync();
                tipoMovimientoResponse = _mapper.Map<TipoMovimientoResponse>(tipoMovimiento);
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
            response.message = "Tipo de Movimiento actualizado exitosamente";
            response.response = tipoMovimientoResponse;
            return response;
        }
    }
}
