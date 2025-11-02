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
    public class SubCategoriaProductoService : ISubCategoriaProductoService
    {
        private readonly ISubCategoriaProductoRepository _categoriaProductoRepository;
        private readonly IMapper _mapper;

        public SubCategoriaProductoService(PuntoDeVentaDbContext context)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            _categoriaProductoRepository = new SubCategoriaProductoRepository(context);
            _mapper = config.CreateMapper();

            using var loggerFactory = LoggerFactory.Create(builder => {});
        }

        public SubCategoriaProductoService(ISubCategoriaProductoRepository categoriaProductoRepository, IMapper mapper, ILogger<SubCategoriaProductoService> logger)
        {
            _categoriaProductoRepository = categoriaProductoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<SubCategoriaProductoResponse>> Delete(int id)
        {
            ResponseModel<SubCategoriaProductoResponse> response = new ResponseModel<SubCategoriaProductoResponse>();
            SubCategoriaProductoResponse categoriaProductoResponse = new SubCategoriaProductoResponse();
            try
            {
                var categoriaProducto = await _categoriaProductoRepository.GetById(id);

                if (categoriaProducto == null)
                {
                    response.statusCode = 404;
                    response.message = "La subcategoria de producto seleccionada no existe";
                    response.response = null;
                    return response;
                }

                await _categoriaProductoRepository.Delete(categoriaProducto);
                categoriaProductoResponse = _mapper.Map<SubCategoriaProductoResponse>(categoriaProducto);
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
            response.message = "SubCategoria de Producto eliminada exitosamente";
            response.response = categoriaProductoResponse;
            return response;
        }

        public async Task<ResponseModel<List<SubCategoriaProductoResponse>>> GetAllByCategoria(int pIdCategoriaProducto, bool? habilitados)
        {
            ResponseModel<List<SubCategoriaProductoResponse>> response = new ResponseModel<List<SubCategoriaProductoResponse>>();

            try
            {
                List<SubCategoriaProducto> lista = await _categoriaProductoRepository.GetAllByCategoria(pIdCategoriaProducto, habilitados);
                List<SubCategoriaProductoResponse> listaDTO = _mapper.Map<List<SubCategoriaProductoResponse>>(lista);

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


        public async Task<ResponseModel<SubCategoriaProductoResponse>> GetById(int IdSubCategoriaProducto)
        {
            ResponseModel<SubCategoriaProductoResponse> response = new ResponseModel<SubCategoriaProductoResponse>();

            try
            {
                SubCategoriaProducto categoriaProducto = await _categoriaProductoRepository.GetById(IdSubCategoriaProducto);

                if (categoriaProducto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La subcategoria de producto seleccionada no existe";
                    response.response = null;
                    return response;
                }

                SubCategoriaProductoResponse SubCategoriaProductoResponse = _mapper.Map<SubCategoriaProductoResponse>(categoriaProducto);

                response.message = "Consulta realizada correctamente";
                response.statusCode = 200;
                response.response = SubCategoriaProductoResponse;
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

        public async Task<ResponseModel<SubCategoriaProductoResponse>> Insert(SubCategoriaProductoRequest entity)
        {
            ResponseModel<SubCategoriaProductoResponse> response = new ResponseModel<SubCategoriaProductoResponse>();
            SubCategoriaProductoResponse categoriaProductoResponse = new SubCategoriaProductoResponse();
            try
            {
                SubCategoriaProducto categoriaProducto = _mapper.Map<SubCategoriaProducto>(entity);
                categoriaProducto = await _categoriaProductoRepository.Create(categoriaProducto);
                categoriaProductoResponse = _mapper.Map<SubCategoriaProductoResponse>(categoriaProducto);
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
            response.message = "SubCategoria de Producto insertada exitosamente";
            response.response = categoriaProductoResponse;
            return response;
        }


        public async Task<ResponseModel<SubCategoriaProductoResponse>> Update(SubCategoriaProductoRequest entity)
        {
            ResponseModel<SubCategoriaProductoResponse> response = new ResponseModel<SubCategoriaProductoResponse>();
            SubCategoriaProductoResponse categoriaProductoResponse = new SubCategoriaProductoResponse();
            try
            {
                var categoriaProducto = await _categoriaProductoRepository.GetById(entity.Id);

                if (categoriaProducto == null)
                {
                    response.success = false;
                    response.statusCode = 404;
                    response.message = "La subcategoria de producto seleccionada no existe";
                    response.response = null;
                    return response;
                }
                                
                categoriaProducto = _mapper.Map<SubCategoriaProductoRequest, SubCategoriaProducto>(entity, categoriaProducto);

                await _categoriaProductoRepository.SaveChangesAsync();
                categoriaProductoResponse = _mapper.Map<SubCategoriaProductoResponse>(categoriaProducto);
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
            response.message = "SubCategoria de Producto actualizada exitosamente";
            response.response = categoriaProductoResponse;
            return response;
        }
    }
}
