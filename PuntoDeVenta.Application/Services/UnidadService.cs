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
    public class UnidadService : IUnidadService
    {
        private readonly IUnidadRepository _tipoMovimientoRepository;
        private readonly IMapper _mapper;

        public UnidadService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _tipoMovimientoRepository = new UnidadRepository(context);
            _mapper = config.CreateMapper();
        }

        public UnidadService(IUnidadRepository tipoMovimientoRepository, IMapper mapper, ILogger<UnidadService> logger)
        {
            _tipoMovimientoRepository = tipoMovimientoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<UnidadResponse>> Delete(int id)
        {
            ResponseModel<UnidadResponse> response = new ResponseModel<UnidadResponse>();
            UnidadResponse tipoMovimientoResponse = new UnidadResponse();
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
                tipoMovimientoResponse = _mapper.Map<UnidadResponse>(tipoMovimiento);
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

        public async Task<ResponseModel<List<UnidadResponse>>> GetAll()
        {
            ResponseModel<List<UnidadResponse>> response = new ResponseModel<List<UnidadResponse>>();

            try
            {
                List<Unidad> lista = await _tipoMovimientoRepository.GetAll();
                List<UnidadResponse> listaDTO = _mapper.Map<List<UnidadResponse>>(lista);

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


        public async Task<ResponseModel<UnidadResponse>> GetById(int IdUnidad)
        {
            ResponseModel<UnidadResponse> response = new ResponseModel<UnidadResponse>();

            try
            {
                Unidad tipoMovimiento = await _tipoMovimientoRepository.GetById(IdUnidad);

                if (tipoMovimiento == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El tipo de movimiento seleccionado no existe";
                    response.response = null;
                    return response;
                }

                UnidadResponse UnidadResponse = _mapper.Map<UnidadResponse>(tipoMovimiento);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = UnidadResponse;
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

        public async Task<ResponseModel<UnidadResponse>> Insert(UnidadRequest entity)
        {
            ResponseModel<UnidadResponse> response = new ResponseModel<UnidadResponse>();
            UnidadResponse tipoMovimientoResponse = new UnidadResponse();
            try
            {
                Unidad tipoMovimiento = _mapper.Map<Unidad>(entity);
                tipoMovimiento = await _tipoMovimientoRepository.Create(tipoMovimiento);
                tipoMovimientoResponse = _mapper.Map<UnidadResponse>(tipoMovimiento);
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


        public async Task<ResponseModel<UnidadResponse>> Update(UnidadRequest entity)
        {
            ResponseModel<UnidadResponse> response = new ResponseModel<UnidadResponse>();
            UnidadResponse tipoMovimientoResponse = new UnidadResponse();
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
                                
                tipoMovimiento = _mapper.Map<UnidadRequest, Unidad>(entity, tipoMovimiento);

                await _tipoMovimientoRepository.SaveChangesAsync();
                tipoMovimientoResponse = _mapper.Map<UnidadResponse>(tipoMovimiento);
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
