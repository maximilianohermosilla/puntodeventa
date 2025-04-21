using AutoMapper;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductoRequest, Producto>().ReverseMap();
            CreateMap<ProductoResponse, Producto>().ReverseMap();
            CreateMap<ProductoResponse, ProductoRequest>().ReverseMap();

            CreateMap<CategoriaProductoRequest, CategoriaProducto>().ReverseMap();
            CreateMap<CategoriaProductoResponse, CategoriaProducto>().ReverseMap();
            CreateMap<CategoriaProductoResponse, CategoriaProductoRequest>().ReverseMap();

            CreateMap<ClienteRequest, Cliente>().ReverseMap();
            CreateMap<ClienteResponse, Cliente>().ReverseMap();
            CreateMap<ClienteResponse, ClienteRequest>().ReverseMap();
        }
    }
}
