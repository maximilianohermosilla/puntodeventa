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
    public class MovimientoService : IMovimientoService
    {
        private readonly IMovimientoRepository _movimientoRepository;
        private readonly IMapper _mapper;

        public MovimientoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _movimientoRepository = new MovimientoRepository(context);
            _mapper = config.CreateMapper();
        }

        public MovimientoService(IMovimientoRepository movimientoRepository, IMapper mapper, ILogger<MovimientoService> logger)
        {
            _movimientoRepository = movimientoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<MovimientoResponse>> Delete(int id)
        {
            ResponseModel<MovimientoResponse> response = new ResponseModel<MovimientoResponse>();
            MovimientoResponse movimientoResponse = new MovimientoResponse();
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
                movimientoResponse = _mapper.Map<MovimientoResponse>(movimiento);
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
            response.message = "Movimiento eliminado exitosamente";
            response.response = movimientoResponse;
            return response;
        }

        public async Task<ResponseModel<List<MovimientoResponse>>> GetAll()
        {
            ResponseModel<List<MovimientoResponse>> response = new ResponseModel<List<MovimientoResponse>>();

            try
            {
                List<Movimiento> lista = await _movimientoRepository.GetAll();
                List<MovimientoResponse> listaDTO = _mapper.Map<List<MovimientoResponse>>(lista);

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


        public async Task<ResponseModel<MovimientoResponse>> GetById(int IdMovimiento)
        {
            ResponseModel<MovimientoResponse> response = new ResponseModel<MovimientoResponse>();

            try
            {
                Movimiento movimiento = await _movimientoRepository.GetById(IdMovimiento);

                if (movimiento == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El movimiento seleccionado no existe";
                    response.response = null;
                    return response;
                }

                MovimientoResponse MovimientoResponse = _mapper.Map<MovimientoResponse>(movimiento);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = MovimientoResponse;
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

        public async Task<ResponseModel<MovimientoResponse>> Insert(MovimientoRequest entity)
        {
            ResponseModel<MovimientoResponse> response = new ResponseModel<MovimientoResponse>();
            MovimientoResponse movimientoResponse = new MovimientoResponse();
            try
            {
                Movimiento movimiento = _mapper.Map<Movimiento>(entity);
                movimiento = await _movimientoRepository.Create(movimiento);
                movimientoResponse = _mapper.Map<MovimientoResponse>(movimiento);
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
            response.message = "Movimiento insertado exitosamente";
            response.response = movimientoResponse;
            return response;
        }


        public async Task<ResponseModel<MovimientoResponse>> Update(MovimientoRequest entity)
        {
            ResponseModel<MovimientoResponse> response = new ResponseModel<MovimientoResponse>();
            MovimientoResponse movimientoResponse = new MovimientoResponse();
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
                                
                movimiento = _mapper.Map<MovimientoRequest, Movimiento>(entity, movimiento);

                await _movimientoRepository.SaveChangesAsync();
                movimientoResponse = _mapper.Map<MovimientoResponse>(movimiento);
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
            response.message = "Movimiento actualizado exitosamente";
            response.response = movimientoResponse;
            return response;
        }
    }
}
