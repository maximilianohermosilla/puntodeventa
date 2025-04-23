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
    public class PromocionService : IPromocionService
    {
        private readonly IPromocionRepository _promocionRepository;
        private readonly IMapper _mapper;

        public PromocionService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _promocionRepository = new PromocionRepository(context);
            _mapper = config.CreateMapper();

            using var loggerFactory = LoggerFactory.Create(builder => {});
        }

        public PromocionService(IPromocionRepository promocionRepository, IMapper mapper, ILogger<PromocionService> logger)
        {
            _promocionRepository = promocionRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PromocionResponse>> Delete(int id)
        {
            ResponseModel<PromocionResponse> response = new ResponseModel<PromocionResponse>();
            PromocionResponse promocionResponse = new PromocionResponse();
            try
            {
                var promocion = await _promocionRepository.GetById(id);

                if (promocion == null)
                {
                    response.statusCode = 404;
                    response.message = "La promoción seleccionada no existe";
                    response.response = null;
                    return response;
                }

                await _promocionRepository.Delete(promocion);
                promocionResponse = _mapper.Map<PromocionResponse>(promocion);
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
            response.response = promocionResponse;
            return response;
        }

        public async Task<ResponseModel<List<PromocionResponse>>> GetAll()
        {
            ResponseModel<List<PromocionResponse>> response = new ResponseModel<List<PromocionResponse>>();

            try
            {
                List<Promocion> lista = await _promocionRepository.GetAll();
                List<PromocionResponse> listaDTO = _mapper.Map<List<PromocionResponse>>(lista);

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


        public async Task<ResponseModel<PromocionResponse>> GetById(int IdPromocion)
        {
            ResponseModel<PromocionResponse> response = new ResponseModel<PromocionResponse>();

            try
            {
                Promocion promocion = await _promocionRepository.GetById(IdPromocion);

                if (promocion == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La promoción seleccionada no existe";
                    response.response = null;
                    return response;
                }

                PromocionResponse PromocionResponse = _mapper.Map<PromocionResponse>(promocion);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = PromocionResponse;
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

        public async Task<ResponseModel<PromocionResponse>> Insert(PromocionRequest entity)
        {
            ResponseModel<PromocionResponse> response = new ResponseModel<PromocionResponse>();
            PromocionResponse promocionResponse = new PromocionResponse();
            try
            {
                Promocion promocion = _mapper.Map<Promocion>(entity);
                promocion = await _promocionRepository.Create(promocion);
                promocionResponse = _mapper.Map<PromocionResponse>(promocion);
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
            response.response = promocionResponse;
            return response;
        }


        public async Task<ResponseModel<PromocionResponse>> Update(PromocionRequest entity)
        {
            ResponseModel<PromocionResponse> response = new ResponseModel<PromocionResponse>();
            PromocionResponse promocionResponse = new PromocionResponse();
            try
            {
                var promocion = await _promocionRepository.GetById(entity.Id);

                if (promocion == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La promoción seleccionada no existe";
                    response.response = null;
                    return response;
                }
                                
                promocion = _mapper.Map<PromocionRequest, Promocion>(entity, promocion);

                await _promocionRepository.SaveChangesAsync();
                promocionResponse = _mapper.Map<PromocionResponse>(promocion);
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
            response.response = promocionResponse;
            return response;
        }
    }
}
