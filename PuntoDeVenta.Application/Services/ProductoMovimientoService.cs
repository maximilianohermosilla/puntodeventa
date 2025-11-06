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
        private readonly IProductoMovimientoRepository _productoMovimientoRepository;
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;

        public ProductoMovimientoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _productoMovimientoRepository = new ProductoMovimientoRepository(context);
            _productoRepository = new ProductoRepository(context);
            _mapper = config.CreateMapper();
        }

        public ProductoMovimientoService(IProductoMovimientoRepository productoMovimientoRepository, IProductoRepository productoRepository, IMapper mapper, ILogger<ProductoMovimientoService> logger)
        {
            _productoMovimientoRepository = productoMovimientoRepository;
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ProductoMovimientoResponse>> Delete(int id)
        {
            ResponseModel<ProductoMovimientoResponse> response = new ResponseModel<ProductoMovimientoResponse>();
            ProductoMovimientoResponse productoResponse = new ProductoMovimientoResponse();
            try
            {
                var producto = await _productoMovimientoRepository.GetById(id);

                if (producto == null)
                {
                    response.statusCode = 404;
                    response.message = "El producto seleccionado no existe";
                    response.response = null;
                    return response;
                }

                await _productoMovimientoRepository.Delete(producto);
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
                List<ProductoMovimiento> lista = await _productoMovimientoRepository.GetAllByFechaAndTipoMovimiento(pFechaDesde, pFechaHasta, pIdTipoMovimiento);
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
                ProductoMovimiento producto = await _productoMovimientoRepository.GetById(IdProductoMovimiento);

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
                var productoExistente = await _productoRepository.GetById((int)entity.IdProducto!);

                if(productoExistente == null)
                {
                    throw new Exception($"No se encontró el producto {entity.Descripcion}");
                }

                if (productoExistente.Cantidad != 0 && (productoExistente.Cantidad - entity.Cantidad) < 0)
                {
                    throw new Exception($"No se puede completar la venta. La cantidad solicitada ({entity.Cantidad}) de {entity.Descripcion} supera la cantidad en stock ({productoExistente.Cantidad}).");
                }

                ProductoMovimiento producto = _mapper.Map<ProductoMovimiento>(entity);
                producto = await _productoMovimientoRepository.Create(producto);
                productoResponse = _mapper.Map<ProductoMovimientoResponse>(producto);

                if(productoExistente.Cantidad > 0)
                {
                    productoExistente.Cantidad = productoExistente.Cantidad - entity.Cantidad;
                    await _productoRepository.SaveChangesAsync();
                }                
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

        public async Task<ResponseModel<List<ProductoMovimientoResponse>>> InsertRange(List<ProductoMovimientoRequest> entities)
        {
            ResponseModel<List<ProductoMovimientoResponse>> response = new ResponseModel<List<ProductoMovimientoResponse>>();
            List<ProductoMovimientoResponse> productosResponse = new List<ProductoMovimientoResponse>();

            try
            {
                List<Producto> productosExistentes = new List<Producto>();
                foreach (var entity in entities)
                {
                    var productoExistente = await _productoRepository.GetById((int)entity.IdProducto!);

                    if (productoExistente == null)
                    {
                        throw new Exception($"No se encontró el producto {entity.Descripcion}");
                    }

                    if (productoExistente.Cantidad != 0 && (productoExistente.Cantidad - entity.Cantidad) < 0)
                    {
                        throw new Exception($"No se puede completar la venta. La cantidad solicitada ({entity.Cantidad}) de {entity.Descripcion} supera la cantidad en stock ({productoExistente.Cantidad}).");
                    }

                    if (productoExistente.Cantidad > 0)
                    {
                        productoExistente.Cantidad = productoExistente.Cantidad - entity.Cantidad;
                    }

                    productosExistentes.Add(productoExistente);
                }

                List<ProductoMovimiento> productosMovimientos = _mapper.Map<List<ProductoMovimiento>>(entities);
                var createResponse = await _productoMovimientoRepository.CreateRange(productosMovimientos);
                productosResponse = _mapper.Map<List<ProductoMovimientoResponse>>(productosMovimientos);

                if(createResponse != null && createResponse.Any())
                {
                    await _productoRepository.SaveChangesAsync();
                }
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
            response.message = "ProductoMovimiento insertado exitosamente";
            response.response = productosResponse;
            return response;
        }

        public async Task<ResponseModel<ProductoMovimientoResponse>> Update(ProductoMovimientoRequest entity)
        {
            ResponseModel<ProductoMovimientoResponse> response = new ResponseModel<ProductoMovimientoResponse>();
            ProductoMovimientoResponse productoResponse = new ProductoMovimientoResponse();
            try
            {
                var producto = await _productoMovimientoRepository.GetById(entity.Id);

                if (producto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El producto seleccionado no existe";
                    response.response = null;
                    return response;
                }
                                
                producto = _mapper.Map<ProductoMovimientoRequest, ProductoMovimiento>(entity, producto);

                await _productoMovimientoRepository.SaveChangesAsync();
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
