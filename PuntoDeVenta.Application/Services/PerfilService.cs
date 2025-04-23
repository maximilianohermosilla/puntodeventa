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
    public class PerfilService : IPerfilService
    {
        private readonly IPerfilRepository _perfilRepository;
        private readonly IMapper _mapper;

        public PerfilService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _perfilRepository = new PerfilRepository(context);
            _mapper = config.CreateMapper();
        }

        public PerfilService(IPerfilRepository perfilRepository, IMapper mapper, ILogger<PerfilService> logger)
        {
            _perfilRepository = perfilRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PerfilResponse>> Delete(int id)
        {
            ResponseModel<PerfilResponse> response = new ResponseModel<PerfilResponse>();
            PerfilResponse perfilResponse = new PerfilResponse();
            try
            {
                var perfil = await _perfilRepository.GetById(id);

                if (perfil == null)
                {
                    response.statusCode = 404;
                    response.message = "El perfil seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _perfilRepository.Delete(perfil);
                perfilResponse = _mapper.Map<PerfilResponse>(perfil);
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
            response.message = "Perfil eliminado exitosamente";
            response.response = perfilResponse;
            return response;
        }

        public async Task<ResponseModel<List<PerfilResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<PerfilResponse>> response = new ResponseModel<List<PerfilResponse>>();

            try
            {
                List<Perfil> lista = await _perfilRepository.GetAll(habilitados);
                List<PerfilResponse> listaDTO = _mapper.Map<List<PerfilResponse>>(lista);

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


        public async Task<ResponseModel<PerfilResponse>> GetById(int IdPerfil)
        {
            ResponseModel<PerfilResponse> response = new ResponseModel<PerfilResponse>();

            try
            {
                Perfil perfil = await _perfilRepository.GetById(IdPerfil);

                if (perfil == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El perfil seleccionado no existe";
                    response.response = null;
                    return response;
                }

                PerfilResponse PerfilResponse = _mapper.Map<PerfilResponse>(perfil);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = PerfilResponse;
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

        public async Task<ResponseModel<PerfilResponse>> Insert(PerfilRequest entity)
        {
            ResponseModel<PerfilResponse> response = new ResponseModel<PerfilResponse>();
            PerfilResponse perfilResponse = new PerfilResponse();
            try
            {
                Perfil perfil = _mapper.Map<Perfil>(entity);
                perfil = await _perfilRepository.Create(perfil);
                perfilResponse = _mapper.Map<PerfilResponse>(perfil);
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
            response.message = "Perfil insertado exitosamente";
            response.response = perfilResponse;
            return response;
        }


        public async Task<ResponseModel<PerfilResponse>> Update(PerfilRequest entity)
        {
            ResponseModel<PerfilResponse> response = new ResponseModel<PerfilResponse>();
            PerfilResponse perfilResponse = new PerfilResponse();
            try
            {
                var perfil = await _perfilRepository.GetById(entity.Id);

                if (perfil == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El perfil seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                perfil = _mapper.Map<PerfilRequest, Perfil>(entity, perfil);

                await _perfilRepository.SaveChangesAsync();
                perfilResponse = _mapper.Map<PerfilResponse>(perfil);
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
            response.message = "Perfil actualizado exitosamente";
            response.response = perfilResponse;
            return response;
        }
    }
}
