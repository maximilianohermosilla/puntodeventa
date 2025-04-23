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
    public class PromocionCategoriaService : IPromocionCategoriaService
    {
        private readonly IPromocionCategoriaRepository _promocionCategoriaRepository;
        private readonly IMapper _mapper;

        public PromocionCategoriaService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _promocionCategoriaRepository = new PromocionCategoriaRepository(context);
            _mapper = config.CreateMapper();

            using var loggerFactory = LoggerFactory.Create(builder => {});
        }

        public PromocionCategoriaService(IPromocionCategoriaRepository promocionCategoriaRepository, IMapper mapper, ILogger<PromocionCategoriaService> logger)
        {
            _promocionCategoriaRepository = promocionCategoriaRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PromocionCategoriaResponse>> Delete(int id)
        {
            ResponseModel<PromocionCategoriaResponse> response = new ResponseModel<PromocionCategoriaResponse>();
            PromocionCategoriaResponse promocionCategoriaResponse = new PromocionCategoriaResponse();
            try
            {
                var promocionCategoria = await _promocionCategoriaRepository.GetById(id);

                if (promocionCategoria == null)
                {
                    response.statusCode = 404;
                    response.message = "La promoción seleccionada no existe";
                    response.response = null;
                    return response;
                }

                await _promocionCategoriaRepository.Delete(promocionCategoria);
                promocionCategoriaResponse = _mapper.Map<PromocionCategoriaResponse>(promocionCategoria);
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
            response.response = promocionCategoriaResponse;
            return response;
        }

        public async Task<ResponseModel<List<PromocionCategoriaResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<PromocionCategoriaResponse>> response = new ResponseModel<List<PromocionCategoriaResponse>>();

            try
            {
                List<PromocionCategoria> lista = await _promocionCategoriaRepository.GetAll(habilitados);
                List<PromocionCategoriaResponse> listaDTO = _mapper.Map<List<PromocionCategoriaResponse>>(lista);

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


        public async Task<ResponseModel<PromocionCategoriaResponse>> GetById(int IdPromocionCategoria)
        {
            ResponseModel<PromocionCategoriaResponse> response = new ResponseModel<PromocionCategoriaResponse>();

            try
            {
                PromocionCategoria promocionCategoria = await _promocionCategoriaRepository.GetById(IdPromocionCategoria);

                if (promocionCategoria == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La promoción seleccionada no existe";
                    response.response = null;
                    return response;
                }

                PromocionCategoriaResponse PromocionCategoriaResponse = _mapper.Map<PromocionCategoriaResponse>(promocionCategoria);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = PromocionCategoriaResponse;
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

        public async Task<ResponseModel<PromocionCategoriaResponse>> Insert(PromocionCategoriaRequest entity)
        {
            ResponseModel<PromocionCategoriaResponse> response = new ResponseModel<PromocionCategoriaResponse>();
            PromocionCategoriaResponse promocionCategoriaResponse = new PromocionCategoriaResponse();
            try
            {
                PromocionCategoria promocionCategoria = _mapper.Map<PromocionCategoria>(entity);
                promocionCategoria = await _promocionCategoriaRepository.Create(promocionCategoria);
                promocionCategoriaResponse = _mapper.Map<PromocionCategoriaResponse>(promocionCategoria);
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
            response.response = promocionCategoriaResponse;
            return response;
        }


        public async Task<ResponseModel<PromocionCategoriaResponse>> Update(PromocionCategoriaRequest entity)
        {
            ResponseModel<PromocionCategoriaResponse> response = new ResponseModel<PromocionCategoriaResponse>();
            PromocionCategoriaResponse promocionCategoriaResponse = new PromocionCategoriaResponse();
            try
            {
                var promocionCategoria = await _promocionCategoriaRepository.GetById(entity.Id);

                if (promocionCategoria == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La promoción seleccionada no existe";
                    response.response = null;
                    return response;
                }
                                
                promocionCategoria = _mapper.Map<PromocionCategoriaRequest, PromocionCategoria>(entity, promocionCategoria);

                await _promocionCategoriaRepository.SaveChangesAsync();
                promocionCategoriaResponse = _mapper.Map<PromocionCategoriaResponse>(promocionCategoria);
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
            response.response = promocionCategoriaResponse;
            return response;
        }
    }
}
