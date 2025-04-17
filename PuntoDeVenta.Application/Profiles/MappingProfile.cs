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

            CreateMap<CategoriaProductoRequest, CategoriaProducto>().ReverseMap();
            CreateMap<CategoriaProductoResponse, CategoriaProducto>().ReverseMap();
        }
    }
}
