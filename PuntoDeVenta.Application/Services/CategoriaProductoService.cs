using AutoMapper;
using Microsoft.Extensions.Logging;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.Application.Services
{
    public class CategoriaProductoService : ICategoriaProductoService
    {
        private readonly ICategoriaProductoRepository _productoRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CategoriaProductoService> _logger;

        public CategoriaProductoService(ICategoriaProductoRepository productoRepository, IMapper mapper, ILogger<CategoriaProductoService> logger)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ResponseModel> Delete(int id)
        {
            ResponseModel response = new ResponseModel();
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

                _logger.LogInformation("Se eliminó el producto: " + id + ", " + producto.Descripcion);
            }
            catch (Exception ex)
            {
                response.success = false;
                response.statusCode = 400;
                response.message = ex.Message;
                response.response = null;
            }

            response.statusCode = 200;
            response.message = "CategoriaProducto eliminado exitosamente";
            response.response = productoResponse;
            return response;
        }

        public async Task<ResponseModel> GetAll()
        {
            ResponseModel response = new ResponseModel();

            try
            {
                List<CategoriaProducto> lista = await _productoRepository.GetAll();
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


        public async Task<ResponseModel> GetById(int IdCategoriaProducto)
        {
            ResponseModel response = new ResponseModel();

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

        public async Task<ResponseModel> Insert(CategoriaProductoRequest entity)
        {
            ResponseModel response = new ResponseModel();
            CategoriaProductoResponse productoResponse = new CategoriaProductoResponse();
            try
            {
                CategoriaProducto producto = _mapper.Map<CategoriaProducto>(entity);
                producto = await _productoRepository.Create(producto);
                productoResponse = _mapper.Map<CategoriaProductoResponse>(producto);

                _logger.LogInformation("Se insertó un nuevo producto: " + producto.Id + ". Nombre: " + producto.Descripcion);
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


        public async Task<ResponseModel> Update(CategoriaProductoRequest entity)
        {
            ResponseModel response = new ResponseModel();
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

                _logger.LogInformation("Se actualizó el producto: " + producto.Id + ". Nombre anterior: " + producto.Descripcion + ". Nombre actual: " + entity.Descripcion);
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
