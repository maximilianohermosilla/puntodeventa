using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IPermisoService
    {
        Task<ResponseModel<List<PermisoResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<PermisoResponse>> GetById(int id);
        Task<ResponseModel<PermisoResponse>> Insert(PermisoRequest entity);
        Task<ResponseModel<PermisoResponse>> Update(PermisoRequest entity);
        Task<ResponseModel<PermisoResponse>> Delete(int id);
    }
}
