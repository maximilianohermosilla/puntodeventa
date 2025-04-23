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
    public class FormaPagoService : IFormaPagoService
    {
        private readonly IFormaPagoRepository fFormaPagoRepository;
        private readonly IMapper _mapper;

        public FormaPagoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            fFormaPagoRepository = new FormaPagoRepository(context);
            _mapper = config.CreateMapper();
        }

        public FormaPagoService(IFormaPagoRepository formaPagoRepository, IMapper mapper, ILogger<FormaPagoService> logger)
        {
            fFormaPagoRepository = formaPagoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<FormaPagoResponse>> Delete(int id)
        {
            ResponseModel<FormaPagoResponse> response = new ResponseModel<FormaPagoResponse>();
            FormaPagoResponse formaPagoResponse = new FormaPagoResponse();
            try
            {
                var formaPago = await fFormaPagoRepository.GetById(id);

                if (formaPago == null)
                {
                    response.statusCode = 404;
                    response.message = "La forma de pago seleccionada no existe";
                    response.response = null;
                    return response;
                }

                await fFormaPagoRepository.Delete(formaPago);
                formaPagoResponse = _mapper.Map<FormaPagoResponse>(formaPago);
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
            response.message = "Forma de Pago eliminada exitosamente";
            response.response = formaPagoResponse;
            return response;
        }

        public async Task<ResponseModel<List<FormaPagoResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<FormaPagoResponse>> response = new ResponseModel<List<FormaPagoResponse>>();

            try
            {
                List<FormaPago> lista = await fFormaPagoRepository.GetAll(habilitados);
                List<FormaPagoResponse> listaDTO = _mapper.Map<List<FormaPagoResponse>>(lista);

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


        public async Task<ResponseModel<FormaPagoResponse>> GetById(int IdFormaPago)
        {
            ResponseModel<FormaPagoResponse> response = new ResponseModel<FormaPagoResponse>();

            try
            {
                FormaPago formaPago = await fFormaPagoRepository.GetById(IdFormaPago);

                if (formaPago == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La forma de pago seleccionada no existe";
                    response.response = null;
                    return response;
                }

                FormaPagoResponse FormaPagoResponse = _mapper.Map<FormaPagoResponse>(formaPago);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = FormaPagoResponse;
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

        public async Task<ResponseModel<FormaPagoResponse>> Insert(FormaPagoRequest entity)
        {
            ResponseModel<FormaPagoResponse> response = new ResponseModel<FormaPagoResponse>();
            FormaPagoResponse formaPagoResponse = new FormaPagoResponse();
            try
            {
                FormaPago formaPago = _mapper.Map<FormaPago>(entity);
                formaPago = await fFormaPagoRepository.Create(formaPago);
                formaPagoResponse = _mapper.Map<FormaPagoResponse>(formaPago);
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
            response.message = "Forma de Pago insertada exitosamente";
            response.response = formaPagoResponse;
            return response;
        }


        public async Task<ResponseModel<FormaPagoResponse>> Update(FormaPagoRequest entity)
        {
            ResponseModel<FormaPagoResponse> response = new ResponseModel<FormaPagoResponse>();
            FormaPagoResponse formaPagoResponse = new FormaPagoResponse();
            try
            {
                var formaPago = await fFormaPagoRepository.GetById(entity.Id);

                if (formaPago == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La forma de pago seleccionada no existe";
                    response.response = null;
                    return response;
                }
                                
                formaPago = _mapper.Map<FormaPagoRequest, FormaPago>(entity, formaPago);

                await fFormaPagoRepository.SaveChangesAsync();
                formaPagoResponse = _mapper.Map<FormaPagoResponse>(formaPago);
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
            response.message = "Forma de Pago actualizada exitosamente";
            response.response = formaPagoResponse;
            return response;
        }
    }
}
