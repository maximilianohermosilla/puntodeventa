using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IPermisoPerfilService
    {
        Task<ResponseModel<List<PermisoPerfilResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<PermisoPerfilResponse>> GetById(int id);
        Task<ResponseModel<PermisoPerfilResponse>> Insert(PermisoPerfilRequest entity);
        Task<ResponseModel<PermisoPerfilResponse>> Update(PermisoPerfilRequest entity);
        Task<ResponseModel<PermisoPerfilResponse>> Delete(int id);
    }
}
