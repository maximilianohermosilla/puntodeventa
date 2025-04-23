using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IPermisoUsuarioService
    {
        Task<ResponseModel<List<PermisoUsuarioResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<PermisoUsuarioResponse>> GetById(int id);
        Task<ResponseModel<PermisoUsuarioResponse>> Insert(PermisoUsuarioRequest entity);
        Task<ResponseModel<PermisoUsuarioResponse>> Update(PermisoUsuarioRequest entity);
        Task<ResponseModel<PermisoUsuarioResponse>> Delete(int id);
    }
}
