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
    public class ParametroService : IParametroService
    {
        private readonly IParametroRepository _parametroRepository;
        private readonly IMapper _mapper;

        public ParametroService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _parametroRepository = new ParametroRepository(context);
            _mapper = config.CreateMapper();
        }

        public ParametroService(IParametroRepository parametroRepository, IMapper mapper, ILogger<ParametroService> logger)
        {
            _parametroRepository = parametroRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ParametroResponse>> Delete(int id)
        {
            ResponseModel<ParametroResponse> response = new ResponseModel<ParametroResponse>();
            ParametroResponse parametroResponse = new ParametroResponse();
            try
            {
                var parametro = await _parametroRepository.GetById(id);

                if (parametro == null)
                {
                    response.statusCode = 404;
                    response.message = "El parametro seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _parametroRepository.Delete(parametro);
                parametroResponse = _mapper.Map<ParametroResponse>(parametro);
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
            response.message = "Parametro eliminado exitosamente";
            response.response = parametroResponse;
            return response;
        }

        public async Task<ResponseModel<List<ParametroResponse>>> GetAll()
        {
            ResponseModel<List<ParametroResponse>> response = new ResponseModel<List<ParametroResponse>>();

            try
            {
                List<Parametro> lista = await _parametroRepository.GetAll();
                List<ParametroResponse> listaDTO = _mapper.Map<List<ParametroResponse>>(lista);

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


        public async Task<ResponseModel<ParametroResponse>> GetById(int IdParametro)
        {
            ResponseModel<ParametroResponse> response = new ResponseModel<ParametroResponse>();

            try
            {
                Parametro parametro = await _parametroRepository.GetById(IdParametro);

                if (parametro == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El parametro seleccionado no existe";
                    response.response = null;
                    return response;
                }

                ParametroResponse ParametroResponse = _mapper.Map<ParametroResponse>(parametro);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = ParametroResponse;
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

        public async Task<ResponseModel<ParametroResponse>> Insert(ParametroRequest entity)
        {
            ResponseModel<ParametroResponse> response = new ResponseModel<ParametroResponse>();
            ParametroResponse parametroResponse = new ParametroResponse();
            try
            {
                Parametro parametro = _mapper.Map<Parametro>(entity);
                parametro = await _parametroRepository.Create(parametro);
                parametroResponse = _mapper.Map<ParametroResponse>(parametro);
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
            response.message = "Parametro insertado exitosamente";
            response.response = parametroResponse;
            return response;
        }


        public async Task<ResponseModel<ParametroResponse>> Update(ParametroRequest entity)
        {
            ResponseModel<ParametroResponse> response = new ResponseModel<ParametroResponse>();
            ParametroResponse parametroResponse = new ParametroResponse();
            try
            {
                var parametro = await _parametroRepository.GetById(entity.Id);

                if (parametro == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El parametro seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                parametro = _mapper.Map<ParametroRequest, Parametro>(entity, parametro);

                await _parametroRepository.SaveChangesAsync();
                parametroResponse = _mapper.Map<ParametroResponse>(parametro);
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
            response.message = "Parametro actualizado exitosamente";
            response.response = parametroResponse;
            return response;
        }
    }
}
