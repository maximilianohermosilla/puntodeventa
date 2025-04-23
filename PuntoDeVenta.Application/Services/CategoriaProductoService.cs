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
        private readonly ICategoriaProductoRepository _categoriaProductoRepository;
        private readonly IMapper _mapper;

        public CategoriaProductoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _categoriaProductoRepository = new CategoriaProductoRepository(context);
            _mapper = config.CreateMapper();

            using var loggerFactory = LoggerFactory.Create(builder => {});
        }

        public CategoriaProductoService(ICategoriaProductoRepository categoriaProductoRepository, IMapper mapper, ILogger<CategoriaProductoService> logger)
        {
            _categoriaProductoRepository = categoriaProductoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<CategoriaProductoResponse>> Delete(int id)
        {
            ResponseModel<CategoriaProductoResponse> response = new ResponseModel<CategoriaProductoResponse>();
            CategoriaProductoResponse categoriaProductoResponse = new CategoriaProductoResponse();
            try
            {
                var categoriaProducto = await _categoriaProductoRepository.GetById(id);

                if (categoriaProducto == null)
                {
                    response.statusCode = 404;
                    response.message = "La categoria de producto seleccionada no existe";
                    response.response = null;
                    return response;
                }

                await _categoriaProductoRepository.Delete(categoriaProducto);
                categoriaProductoResponse = _mapper.Map<CategoriaProductoResponse>(categoriaProducto);
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
            response.message = "Categoria de Producto eliminada exitosamente";
            response.response = categoriaProductoResponse;
            return response;
        }

        public async Task<ResponseModel<List<CategoriaProductoResponse>>> GetAll(bool? habilitados)
        {
            ResponseModel<List<CategoriaProductoResponse>> response = new ResponseModel<List<CategoriaProductoResponse>>();

            try
            {
                List<CategoriaProducto> lista = await _categoriaProductoRepository.GetAll(habilitados);
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
                CategoriaProducto categoriaProducto = await _categoriaProductoRepository.GetById(IdCategoriaProducto);

                if (categoriaProducto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La categoria de producto seleccionada no existe";
                    response.response = null;
                    return response;
                }

                CategoriaProductoResponse CategoriaProductoResponse = _mapper.Map<CategoriaProductoResponse>(categoriaProducto);

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
            CategoriaProductoResponse categoriaProductoResponse = new CategoriaProductoResponse();
            try
            {
                CategoriaProducto categoriaProducto = _mapper.Map<CategoriaProducto>(entity);
                categoriaProducto = await _categoriaProductoRepository.Create(categoriaProducto);
                categoriaProductoResponse = _mapper.Map<CategoriaProductoResponse>(categoriaProducto);
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
            response.message = "Categoria de Producto insertada exitosamente";
            response.response = categoriaProductoResponse;
            return response;
        }


        public async Task<ResponseModel<CategoriaProductoResponse>> Update(CategoriaProductoRequest entity)
        {
            ResponseModel<CategoriaProductoResponse> response = new ResponseModel<CategoriaProductoResponse>();
            CategoriaProductoResponse categoriaProductoResponse = new CategoriaProductoResponse();
            try
            {
                var categoriaProducto = await _categoriaProductoRepository.GetById(entity.Id);

                if (categoriaProducto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La categoria de producto seleccionada no existe";
                    response.response = null;
                    return response;
                }
                                
                categoriaProducto = _mapper.Map<CategoriaProductoRequest, CategoriaProducto>(entity, categoriaProducto);

                await _categoriaProductoRepository.SaveChangesAsync();
                categoriaProductoResponse = _mapper.Map<CategoriaProductoResponse>(categoriaProducto);
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
            response.message = "Categoria de Producto actualizada exitosamente";
            response.response = categoriaProductoResponse;
            return response;
        }
    }
}
