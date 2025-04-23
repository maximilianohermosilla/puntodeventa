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
    public class PromocionProductoService : IPromocionProductoService
    {
        private readonly IPromocionProductoRepository _promocionProductoRepository;
        private readonly IMapper _mapper;

        public PromocionProductoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _promocionProductoRepository = new PromocionProductoRepository(context);
            _mapper = config.CreateMapper();

            using var loggerFactory = LoggerFactory.Create(builder => {});
        }

        public PromocionProductoService(IPromocionProductoRepository promocionProductoRepository, IMapper mapper, ILogger<PromocionProductoService> logger)
        {
            _promocionProductoRepository = promocionProductoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PromocionProductoResponse>> Delete(int id)
        {
            ResponseModel<PromocionProductoResponse> response = new ResponseModel<PromocionProductoResponse>();
            PromocionProductoResponse promocionProductoResponse = new PromocionProductoResponse();
            try
            {
                var promocionProducto = await _promocionProductoRepository.GetById(id);

                if (promocionProducto == null)
                {
                    response.statusCode = 404;
                    response.message = "La promoción seleccionada no existe";
                    response.response = null;
                    return response;
                }

                await _promocionProductoRepository.Delete(promocionProducto);
                promocionProductoResponse = _mapper.Map<PromocionProductoResponse>(promocionProducto);
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
            response.message = "Promoción eliminada exitosamente";
            response.response = promocionProductoResponse;
            return response;
        }

        public async Task<ResponseModel<List<PromocionProductoResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<PromocionProductoResponse>> response = new ResponseModel<List<PromocionProductoResponse>>();

            try
            {
                List<PromocionProducto> lista = await _promocionProductoRepository.GetAll(habilitados);
                List<PromocionProductoResponse> listaDTO = _mapper.Map<List<PromocionProductoResponse>>(lista);

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


        public async Task<ResponseModel<PromocionProductoResponse>> GetById(int IdPromocionProducto)
        {
            ResponseModel<PromocionProductoResponse> response = new ResponseModel<PromocionProductoResponse>();

            try
            {
                PromocionProducto promocionProducto = await _promocionProductoRepository.GetById(IdPromocionProducto);

                if (promocionProducto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La promoción seleccionada no existe";
                    response.response = null;
                    return response;
                }

                PromocionProductoResponse PromocionProductoResponse = _mapper.Map<PromocionProductoResponse>(promocionProducto);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = PromocionProductoResponse;
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

        public async Task<ResponseModel<PromocionProductoResponse>> Insert(PromocionProductoRequest entity)
        {
            ResponseModel<PromocionProductoResponse> response = new ResponseModel<PromocionProductoResponse>();
            PromocionProductoResponse promocionProductoResponse = new PromocionProductoResponse();
            try
            {
                PromocionProducto promocionProducto = _mapper.Map<PromocionProducto>(entity);
                promocionProducto = await _promocionProductoRepository.Create(promocionProducto);
                promocionProductoResponse = _mapper.Map<PromocionProductoResponse>(promocionProducto);
            }
            catch (Exception ex)
            {
                response.success = false;
                response.statusCode = 400;
                response.message = ex.Message;
                response.response = null;
                return response;
            }

            response.success = true;
            response.statusCode = 201;
            response.message = "Promoción insertada exitosamente";
            response.response = promocionProductoResponse;
            return response;
        }


        public async Task<ResponseModel<PromocionProductoResponse>> Update(PromocionProductoRequest entity)
        {
            ResponseModel<PromocionProductoResponse> response = new ResponseModel<PromocionProductoResponse>();
            PromocionProductoResponse promocionProductoResponse = new PromocionProductoResponse();
            try
            {
                var promocionProducto = await _promocionProductoRepository.GetById(entity.Id);

                if (promocionProducto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La promoción seleccionada no existe";
                    response.response = null;
                    return response;
                }
                                
                promocionProducto = _mapper.Map<PromocionProductoRequest, PromocionProducto>(entity, promocionProducto);

                await _promocionProductoRepository.SaveChangesAsync();
                promocionProductoResponse = _mapper.Map<PromocionProductoResponse>(promocionProducto);
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
            response.message = "Promoción actualizada exitosamente";
            response.response = promocionProductoResponse;
            return response;
        }
    }
}
