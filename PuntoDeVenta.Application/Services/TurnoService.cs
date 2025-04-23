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
    public class TurnoService : ITurnoService
    {
        private readonly ITurnoRepository _turnoRepository;
        private readonly IMapper _mapper;

        public TurnoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _turnoRepository = new TurnoRepository(context);
            _mapper = config.CreateMapper();
        }

        public TurnoService(ITurnoRepository turnoRepository, IMapper mapper, ILogger<TurnoService> logger)
        {
            _turnoRepository = turnoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TurnoResponse>> Delete(int id)
        {
            ResponseModel<TurnoResponse> response = new ResponseModel<TurnoResponse>();
            TurnoResponse turnoResponse = new TurnoResponse();
            try
            {
                var turno = await _turnoRepository.GetById(id);

                if (turno == null)
                {
                    response.statusCode = 404;
                    response.message = "El turno seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _turnoRepository.Delete(turno);
                turnoResponse = _mapper.Map<TurnoResponse>(turno);
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
            response.message = "Turno eliminado exitosamente";
            response.response = turnoResponse;
            return response;
        }

        public async Task<ResponseModel<List<TurnoResponse>>> GetAll()
        {
            ResponseModel<List<TurnoResponse>> response = new ResponseModel<List<TurnoResponse>>();

            try
            {
                List<Turno> lista = await _turnoRepository.GetAll();
                List<TurnoResponse> listaDTO = _mapper.Map<List<TurnoResponse>>(lista);

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


        public async Task<ResponseModel<TurnoResponse>> GetById(int IdTurno)
        {
            ResponseModel<TurnoResponse> response = new ResponseModel<TurnoResponse>();

            try
            {
                Turno turno = await _turnoRepository.GetById(IdTurno);

                if (turno == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El turno seleccionado no existe";
                    response.response = null;
                    return response;
                }

                TurnoResponse TurnoResponse = _mapper.Map<TurnoResponse>(turno);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = TurnoResponse;
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

        public async Task<ResponseModel<TurnoResponse>> Insert(TurnoRequest entity)
        {
            ResponseModel<TurnoResponse> response = new ResponseModel<TurnoResponse>();
            TurnoResponse turnoResponse = new TurnoResponse();
            try
            {
                Turno turno = _mapper.Map<Turno>(entity);
                turno = await _turnoRepository.Create(turno);
                turnoResponse = _mapper.Map<TurnoResponse>(turno);
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
            response.message = "Turno insertado exitosamente";
            response.response = turnoResponse;
            return response;
        }


        public async Task<ResponseModel<TurnoResponse>> Update(TurnoRequest entity)
        {
            ResponseModel<TurnoResponse> response = new ResponseModel<TurnoResponse>();
            TurnoResponse turnoResponse = new TurnoResponse();
            try
            {
                var turno = await _turnoRepository.GetById(entity.Id);

                if (turno == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El turno seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                turno = _mapper.Map<TurnoRequest, Turno>(entity, turno);

                await _turnoRepository.SaveChangesAsync();
                turnoResponse = _mapper.Map<TurnoResponse>(turno);
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
            response.message = "Turno actualizado exitosamente";
            response.response = turnoResponse;
            return response;
        }
    }
}
