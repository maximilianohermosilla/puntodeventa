using AutoMapper;
using PuntoDeVenta.Application.DTO;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CajaMovimientoRequest, CajaMovimiento>().ReverseMap();
            CreateMap<CajaMovimientoResponse, CajaMovimiento>().ReverseMap();
            CreateMap<CajaMovimientoResponse, CajaMovimientoRequest>().ReverseMap();

            CreateMap<CategoriaProductoRequest, CategoriaProducto>().ReverseMap();
            CreateMap<CategoriaProductoResponse, CategoriaProducto>().ReverseMap();
            CreateMap<CategoriaProductoResponse, CategoriaProductoRequest>().ReverseMap();

            CreateMap<ClienteRequest, Cliente>().ReverseMap();
            CreateMap<ClienteResponse, Cliente>().ReverseMap();
            CreateMap<ClienteResponse, ClienteRequest>().ReverseMap();

            CreateMap<EstadoRequest, Estado>().ReverseMap();
            CreateMap<EstadoResponse, Estado>().ReverseMap();
            CreateMap<EstadoResponse, EstadoRequest>().ReverseMap();

            CreateMap<FormaPagoRequest, FormaPago>().ReverseMap();
            CreateMap<FormaPagoResponse, FormaPago>().ReverseMap();
            CreateMap<FormaPagoResponse, FormaPagoRequest>().ReverseMap();

            CreateMap<MovimientoRequest, Movimiento>().ReverseMap();
            CreateMap<MovimientoResponse, Movimiento>().ReverseMap();
            CreateMap<MovimientoResponse, MovimientoRequest>().ReverseMap();

            CreateMap<ParametroRequest, Parametro>().ReverseMap();
            CreateMap<ParametroResponse, Parametro>().ReverseMap();
            CreateMap<ParametroResponse, ParametroRequest>().ReverseMap();

            CreateMap<PerfilRequest, Perfil>().ReverseMap();
            CreateMap<PerfilResponse, Perfil>().ReverseMap();
            CreateMap<PerfilResponse, PerfilRequest>().ReverseMap();

            CreateMap<PermisoRequest, Permiso>().ReverseMap();
            CreateMap<PermisoResponse, Permiso>().ReverseMap();
            CreateMap<PermisoResponse, PermisoRequest>().ReverseMap();

            CreateMap<PermisoPerfilRequest, PermisoPerfil>().ReverseMap();
            CreateMap<PermisoPerfilResponse, PermisoPerfil>().ReverseMap();
            CreateMap<PermisoPerfilResponse, PermisoPerfilRequest>().ReverseMap();

            CreateMap<PermisoUsuarioRequest, PermisoUsuario>().ReverseMap();
            CreateMap<PermisoUsuarioResponse, PermisoUsuario>().ReverseMap();
            CreateMap<PermisoUsuarioResponse, PermisoUsuarioRequest>().ReverseMap();

            CreateMap<ProductoRequest, Producto>().ReverseMap();
            CreateMap<ProductoResponse, Producto>().ReverseMap();
            CreateMap<ProductoResponse, ProductoRequest>().ReverseMap();

            CreateMap<ProductoMovimientoRequest, ProductoMovimiento>().ReverseMap();
            CreateMap<ProductoMovimientoResponse, ProductoMovimiento>().ReverseMap();
            CreateMap<ProductoMovimientoResponse, ProductoMovimientoRequest>().ReverseMap();

            CreateMap<PromocionCategoriaRequest, PromocionCategoria>().ReverseMap();
            CreateMap<PromocionCategoriaResponse, PromocionCategoria>().ReverseMap();
            CreateMap<PromocionCategoriaResponse, PromocionCategoriaRequest>().ReverseMap();

            CreateMap<PromocionProductoRequest, PromocionProducto>().ReverseMap();
            CreateMap<PromocionProductoResponse, PromocionProducto>().ReverseMap();
            CreateMap<PromocionProductoResponse, PromocionProductoRequest>().ReverseMap();

            CreateMap<PromocionRequest, Promocion>().ReverseMap();
            CreateMap<PromocionResponse, Promocion>().ReverseMap();
            CreateMap<PromocionResponse, PromocionRequest>().ReverseMap();

            CreateMap<SubCategoriaProductoRequest, SubCategoriaProducto>().ReverseMap();
            CreateMap<SubCategoriaProductoResponse, SubCategoriaProducto>().ReverseMap();
            CreateMap<SubCategoriaProductoResponse, SubCategoriaProductoRequest>().ReverseMap();

            CreateMap<TicketDetalleRequest, TicketDetalle>().ReverseMap();
            CreateMap<TicketDetalleResponse, TicketDetalle>().ReverseMap();
            CreateMap<TicketDetalleResponse, TicketDetalleRequest>().ReverseMap();

            CreateMap<TicketEstadoRequest, TicketEstado>().ReverseMap();
            CreateMap<TicketEstadoResponse, TicketEstado>().ReverseMap();
            CreateMap<TicketEstadoResponse, TicketEstadoRequest>().ReverseMap();

            CreateMap<TicketEstadoRequest, TicketEstado>().ReverseMap();
            CreateMap<TicketEstadoResponse, TicketEstado>().ReverseMap();
            CreateMap<TicketEstadoResponse, TicketEstadoRequest>().ReverseMap();

            CreateMap<TicketRequest, Ticket>().ReverseMap();
            CreateMap<TicketResponse, Ticket>().ReverseMap();
            CreateMap<TicketResponse, TicketRequest>().ReverseMap();

            CreateMap<TipoMovimientoRequest, TipoMovimiento>().ReverseMap();
            CreateMap<TipoMovimientoResponse, TipoMovimiento>().ReverseMap();
            CreateMap<TipoMovimientoResponse, TipoMovimientoRequest>().ReverseMap();

            CreateMap<TipoPermisoRequest, TipoPermiso>().ReverseMap();
            CreateMap<TipoPermisoResponse, TipoPermiso>().ReverseMap();
            CreateMap<TipoPermisoResponse, TipoPermisoRequest>().ReverseMap();

            CreateMap<TurnoRequest, Turno>().ReverseMap();
            CreateMap<TurnoResponse, Turno>().ReverseMap();
            CreateMap<TurnoResponse, TurnoRequest>().ReverseMap();

            CreateMap<UnidadRequest, Unidad>().ReverseMap();
            CreateMap<UnidadResponse, Unidad>().ReverseMap();
            CreateMap<UnidadResponse, UnidadRequest>().ReverseMap();

            CreateMap<UsuarioRequest, Usuario>().ReverseMap();
            CreateMap<UsuarioResponse, Usuario>().ReverseMap();
            CreateMap<UsuarioResponse, UsuarioRequest>().ReverseMap();
        }
    }
}
