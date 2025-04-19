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
    public class CategoriaProductoService : ICategoriaProductoService
    {
        private readonly ICategoriaProductoRepository _productoRepository;
        private readonly IMapper _mapper;

        public CategoriaProductoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _productoRepository = new CategoriaProductoRepository(context);
            _mapper = config.CreateMapper();

            using var loggerFactory = LoggerFactory.Create(builder => {});
        }

        public CategoriaProductoService(ICategoriaProductoRepository productoRepository, IMapper mapper, ILogger<CategoriaProductoService> logger)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<CategoriaProductoResponse>> Delete(int id)
        {
            ResponseModel<CategoriaProductoResponse> response = new ResponseModel<CategoriaProductoResponse>();
            CategoriaProductoResponse productoResponse = new CategoriaProductoResponse();
            try
            {
                var producto = await _productoRepository.GetById(id);

                if (producto == null)
                {
                    response.statusCode = 404;
                    response.message = "El producto seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _productoRepository.Delete(producto);
                productoResponse = _mapper.Map<CategoriaProductoResponse>(producto);
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
            response.message = "CategoriaProducto eliminado exitosamente";
            response.response = productoResponse;
            return response;
        }

        public async Task<ResponseModel<List<CategoriaProductoResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<CategoriaProductoResponse>> response = new ResponseModel<List<CategoriaProductoResponse>>();

            try
            {
                List<CategoriaProducto> lista = await _productoRepository.GetAll(habilitados);
                List<CategoriaProductoResponse> listaDTO = _mapper.Map<List<CategoriaProductoResponse>>(lista);

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


        public async Task<ResponseModel<CategoriaProductoResponse>> GetById(int IdCategoriaProducto)
        {
            ResponseModel<CategoriaProductoResponse> response = new ResponseModel<CategoriaProductoResponse>();

            try
            {
                CategoriaProducto producto = await _productoRepository.GetById(IdCategoriaProducto);

                if (producto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El producto seleccionado no existe";
                    response.response = null;
                    return response;
                }

                CategoriaProductoResponse CategoriaProductoResponse = _mapper.Map<CategoriaProductoResponse>(producto);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = CategoriaProductoResponse;
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

        public async Task<ResponseModel<CategoriaProductoResponse>> Insert(CategoriaProductoRequest entity)
        {
            ResponseModel<CategoriaProductoResponse> response = new ResponseModel<CategoriaProductoResponse>();
            CategoriaProductoResponse productoResponse = new CategoriaProductoResponse();
            try
            {
                CategoriaProducto producto = _mapper.Map<CategoriaProducto>(entity);
                producto = await _productoRepository.Create(producto);
                productoResponse = _mapper.Map<CategoriaProductoResponse>(producto);
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
            response.message = "CategoriaProducto insertado exitosamente";
            response.response = productoResponse;
            return response;
        }


        public async Task<ResponseModel<CategoriaProductoResponse>> Update(CategoriaProductoRequest entity)
        {
            ResponseModel<CategoriaProductoResponse> response = new ResponseModel<CategoriaProductoResponse>();
            CategoriaProductoResponse productoResponse = new CategoriaProductoResponse();
            try
            {
                var producto = await _productoRepository.GetById(entity.Id);

                if (producto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El producto seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                producto = _mapper.Map<CategoriaProductoRequest, CategoriaProducto>(entity, producto);

                await _productoRepository.SaveChangesAsync();
                productoResponse = _mapper.Map<CategoriaProductoResponse>(producto);
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
            response.message = "CategoriaProducto actualizado exitosamente";
            response.response = productoResponse;
            return response;
        }
    }
}
