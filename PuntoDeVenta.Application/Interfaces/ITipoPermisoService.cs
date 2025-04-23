using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface ITipoPermisoService
    {
        Task<ResponseModel<List<TipoPermisoResponse>>> GetAll();
        Task<ResponseModel<TipoPermisoResponse>> GetById(int id);
        Task<ResponseModel<TipoPermisoResponse>> Insert(TipoPermisoRequest entity);
        Task<ResponseModel<TipoPermisoResponse>> Update(TipoPermisoRequest entity);
        Task<ResponseModel<TipoPermisoResponse>> Delete(int id);
    }
}
