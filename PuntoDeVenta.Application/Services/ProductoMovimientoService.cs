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
    public class ProductoMovimientoService : IProductoMovimientoService
    {
        private readonly IProductoMovimientoRepository _productoRepository;
        private readonly IMapper _mapper;

        public ProductoMovimientoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _productoRepository = new ProductoMovimientoRepository(context);
            _mapper = config.CreateMapper();
        }

        public ProductoMovimientoService(IProductoMovimientoRepository productoRepository, IMapper mapper, ILogger<ProductoMovimientoService> logger)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ProductoMovimientoResponse>> Delete(int id)
        {
            ResponseModel<ProductoMovimientoResponse> response = new ResponseModel<ProductoMovimientoResponse>();
            ProductoMovimientoResponse productoResponse = new ProductoMovimientoResponse();
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
                productoResponse = _mapper.Map<ProductoMovimientoResponse>(producto);
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
            response.message = "ProductoMovimiento eliminado exitosamente";
            response.response = productoResponse;
            return response;
        }

        public async Task<ResponseModel<List<ProductoMovimientoResponse>>> GetAllByFechaAndTipoMovimiento(DateTime pFechaDesde, DateTime pFechaHasta, int pIdTipoMovimiento)
        {
            ResponseModel<List<ProductoMovimientoResponse>> response = new ResponseModel<List<ProductoMovimientoResponse>>();

            try
            {
                List<ProductoMovimiento> lista = await _productoRepository.GetAllByFechaAndTipoMovimiento(pFechaDesde, pFechaHasta, pIdTipoMovimiento);
                List<ProductoMovimientoResponse> listaDTO = _mapper.Map<List<ProductoMovimientoResponse>>(lista);

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


        public async Task<ResponseModel<ProductoMovimientoResponse>> GetById(int IdProductoMovimiento)
        {
            ResponseModel<ProductoMovimientoResponse> response = new ResponseModel<ProductoMovimientoResponse>();

            try
            {
                ProductoMovimiento producto = await _productoRepository.GetById(IdProductoMovimiento);

                if (producto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El producto seleccionado no existe";
                    response.response = null;
                    return response;
                }

                ProductoMovimientoResponse ProductoMovimientoResponse = _mapper.Map<ProductoMovimientoResponse>(producto);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = ProductoMovimientoResponse;
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


        public async Task<ResponseModel<ProductoMovimientoResponse>> Insert(ProductoMovimientoRequest entity)
        {
            ResponseModel<ProductoMovimientoResponse> response = new ResponseModel<ProductoMovimientoResponse>();
            ProductoMovimientoResponse productoResponse = new ProductoMovimientoResponse();
            try
            {
                ProductoMovimiento producto = _mapper.Map<ProductoMovimiento>(entity);
                producto = await _productoRepository.Create(producto);
                productoResponse = _mapper.Map<ProductoMovimientoResponse>(producto);
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
            response.message = "ProductoMovimiento insertado exitosamente";
            response.response = productoResponse;
            return response;
        }


        public async Task<ResponseModel<ProductoMovimientoResponse>> Update(ProductoMovimientoRequest entity)
        {
            ResponseModel<ProductoMovimientoResponse> response = new ResponseModel<ProductoMovimientoResponse>();
            ProductoMovimientoResponse productoResponse = new ProductoMovimientoResponse();
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
                                
                producto = _mapper.Map<ProductoMovimientoRequest, ProductoMovimiento>(entity, producto);

                await _productoRepository.SaveChangesAsync();
                productoResponse = _mapper.Map<ProductoMovimientoResponse>(producto);
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
            response.message = "ProductoMovimiento actualizado exitosamente";
            response.response = productoResponse;
            return response;
        }
    }
}
