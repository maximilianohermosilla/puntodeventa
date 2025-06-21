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
    public class ProductoService: IProductoService
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;

        public ProductoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _productoRepository = new ProductoRepository(context);
            _mapper = config.CreateMapper();
        }

        public ProductoService(IProductoRepository productoRepository, IMapper mapper, ILogger<ProductoService> logger)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ProductoResponse>> Delete(int id)
        {
            ResponseModel<ProductoResponse> response = new ResponseModel<ProductoResponse>();
            ProductoResponse productoResponse = new ProductoResponse();
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
                productoResponse = _mapper.Map<ProductoResponse>(producto);
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
            response.message = "Producto eliminado exitosamente";
            response.response = productoResponse;
            return response;
        }

        public async Task<ResponseModel<List<ProductoResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<ProductoResponse>> response = new ResponseModel<List<ProductoResponse>>();

            try
            {
                List<Producto> lista = await _productoRepository.GetAll(habilitados);
                List<ProductoResponse> listaDTO = _mapper.Map<List<ProductoResponse>>(lista);

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


        public async Task<ResponseModel<ProductoResponse>> GetById(int IdProducto)
        {
            ResponseModel<ProductoResponse> response = new ResponseModel<ProductoResponse>();

            try
            {
                Producto producto = await _productoRepository.GetById(IdProducto);

                if (producto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El producto seleccionado no existe";
                    response.response = null;
                    return response;
                }

                ProductoResponse ProductoResponse = _mapper.Map<ProductoResponse>(producto);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = ProductoResponse;
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

        public async Task<ResponseModel<ProductoResponse>> GetByCodigo(string codigo)
        {
            ResponseModel<ProductoResponse> response = new ResponseModel<ProductoResponse>();

            try
            {
                Producto producto = await _productoRepository.GetByCodigo(codigo);

                if (producto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "El producto seleccionado no existe";
                    response.response = null;
                    return response;
                }

                ProductoResponse ProductoResponse = _mapper.Map<ProductoResponse>(producto);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = ProductoResponse;
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

        public async Task<ResponseModel<ProductoResponse>> Insert(ProductoRequest entity)
        {
            ResponseModel<ProductoResponse> response = new ResponseModel<ProductoResponse>();
            ProductoResponse productoResponse = new ProductoResponse();
            try
            {
                Producto producto = _mapper.Map<Producto>(entity);
                producto = await _productoRepository.Create(producto);
                productoResponse = _mapper.Map<ProductoResponse>(producto);
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
            response.message = "Producto insertado exitosamente";
            response.response = productoResponse;
            return response;
        }


        public async Task<ResponseModel<ProductoResponse>> Update(ProductoRequest entity)
        {
            ResponseModel<ProductoResponse> response = new ResponseModel<ProductoResponse>();
            ProductoResponse productoResponse = new ProductoResponse();
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
                                
                producto = _mapper.Map<ProductoRequest, Producto>(entity, producto);

                await _productoRepository.SaveChangesAsync();
                productoResponse = _mapper.Map<ProductoResponse>(producto);
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
            response.message = "Producto actualizado exitosamente";
            response.response = productoResponse;
            return response;
        }
    }
}
