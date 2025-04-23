using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IPerfilService
    {
        Task<ResponseModel<List<PerfilResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<PerfilResponse>> GetById(int id);
        Task<ResponseModel<PerfilResponse>> Insert(PerfilRequest entity);
        Task<ResponseModel<PerfilResponse>> Update(PerfilRequest entity);
        Task<ResponseModel<PerfilResponse>> Delete(int id);
    }
}
