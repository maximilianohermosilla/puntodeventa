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
    public class CajaMovimientoService : ICajaMovimientoService
    {
        private readonly ICajaMovimientoRepository _movimientoRepository;
        private readonly IMapper _mapper;

        public CajaMovimientoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _movimientoRepository = new CajaMovimientoRepository(context);
            _mapper = config.CreateMapper();
        }

        public CajaMovimientoService(ICajaMovimientoRepository movimientoRepository, IMapper mapper, ILogger<CajaMovimientoService> logger)
        {
            _movimientoRepository = movimientoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<CajaMovimientoResponse>> Delete(int id)
        {
            ResponseModel<CajaMovimientoResponse> response = new ResponseModel<CajaMovimientoResponse>();
            CajaMovimientoResponse movimientoResponse = new CajaMovimientoResponse();
            try
            {
                var movimiento = await _movimientoRepository.GetById(id);

                if (movimiento == null)
                {
                    response.statusCode = 404;
                    response.message = "El movimiento seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _movimientoRepository.Delete(movimiento);
                movimientoResponse = _mapper.Map<CajaMovimientoResponse>(movimiento);
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
            response.message = "CajaMovimiento eliminado exitosamente";
            response.response = movimientoResponse;
            return response;
        }

        public async Task<ResponseModel<List<CajaMovimientoResponse>>> GetAll()
        {
            ResponseModel<List<CajaMovimientoResponse>> response = new ResponseModel<List<CajaMovimientoResponse>>();

            try
            {
                List<CajaMovimiento> lista = await _movimientoRepository.GetAll();
                List<CajaMovimientoResponse> listaDTO = _mapper.Map<List<CajaMovimientoResponse>>(lista);

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

        public async Task<ResponseModel<List<CajaMovimientoResponse>>> GetAllByIdTurno(int idTurno)
        {
            ResponseModel<List<CajaMovimientoResponse>> response = new ResponseModel<List<CajaMovimientoResponse>>();

            try
            {
                List<CajaMovimiento> lista = await _movimientoRepository.GetAllByIdTurno(idTurno);
                List<CajaMovimientoResponse> listaDTO = _mapper.Map<List<CajaMovimientoResponse>>(lista);

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

        public async Task<ResponseModel<List<CajaMovimientoResponse>>> GetAllByFechaAndTipoMovimientoFormaPago(DateTime pFechaDesde, DateTime pFechaHasta, int pIdTipoMovimiento, int pIdFormaPago)
        {
            ResponseModel<List<CajaMovimientoResponse>> response = new ResponseModel<List<CajaMovimientoResponse>>();

            try
            {
                List<CajaMovimiento> lista = await _movimientoRepository.GetAllByFechaAndTipoMovimientoFormaPago(pFechaDesde, pFechaHasta, pIdTipoMovimiento, pIdFormaPago);
                List<CajaMovimientoResponse> listaDTO = _mapper.Map<List<CajaMovimientoResponse>>(lista);

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

        public async Task<ResponseModel<CajaMovimientoResponse>> GetById(int IdCajaMovimiento)
        {
            ResponseModel<CajaMovimientoResponse> response = new ResponseModel<CajaMovimientoResponse>();

            try
            {
                CajaMovimiento movimiento = await _movimientoRepository.GetById(IdCajaMovimiento);

                if (movimiento == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El movimiento seleccionado no existe";
                    response.response = null;
                    return response;
                }

                CajaMovimientoResponse CajaMovimientoResponse = _mapper.Map<CajaMovimientoResponse>(movimiento);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = CajaMovimientoResponse;
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

        public async Task<ResponseModel<CajaMovimientoResponse>> GetLastByFormaPago(int idFormaPago)
        {
            ResponseModel<CajaMovimientoResponse> response = new ResponseModel<CajaMovimientoResponse>();

            try
            {
                CajaMovimiento movimiento = await _movimientoRepository.GetLastByFormaPago(idFormaPago);

                if (movimiento == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "No existe ningún movimiento";
                    response.response = null;
                    return response;
                }

                CajaMovimientoResponse CajaMovimientoResponse = _mapper.Map<CajaMovimientoResponse>(movimiento);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = CajaMovimientoResponse;
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

        public async Task<ResponseModel<CajaMovimientoResponse>> Insert(CajaMovimientoRequest entity)
        {
            ResponseModel<CajaMovimientoResponse> response = new ResponseModel<CajaMovimientoResponse>();
            CajaMovimientoResponse movimientoResponse = new CajaMovimientoResponse();
            try
            {
                CajaMovimiento movimiento = _mapper.Map<CajaMovimiento>(entity);
                movimiento = await _movimientoRepository.Create(movimiento);
                movimientoResponse = _mapper.Map<CajaMovimientoResponse>(movimiento);
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
            response.message = "CajaMovimiento insertado exitosamente";
            response.response = movimientoResponse;
            return response;
        }


        public async Task<ResponseModel<CajaMovimientoResponse>> Update(CajaMovimientoRequest entity)
        {
            ResponseModel<CajaMovimientoResponse> response = new ResponseModel<CajaMovimientoResponse>();
            CajaMovimientoResponse movimientoResponse = new CajaMovimientoResponse();
            try
            {
                var movimiento = await _movimientoRepository.GetById(entity.Id);

                if (movimiento == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El movimiento seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                movimiento = _mapper.Map<CajaMovimientoRequest, CajaMovimiento>(entity, movimiento);

                await _movimientoRepository.SaveChangesAsync();
                movimientoResponse = _mapper.Map<CajaMovimientoResponse>(movimiento);
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
            response.message = "CajaMovimiento actualizado exitosamente";
            response.response = movimientoResponse;
            return response;
        }
    }
}
