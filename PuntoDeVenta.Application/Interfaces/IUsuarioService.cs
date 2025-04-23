using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<ResponseModel<List<UsuarioResponse>>> GetAll(bool? habilitados);
        Task<ResponseModel<UsuarioResponse>> GetById(int id);
        Task<ResponseModel<UsuarioResponse>> Insert(UsuarioRequest entity);
        Task<ResponseModel<UsuarioResponse>> Update(UsuarioRequest entity);
        Task<ResponseModel<UsuarioResponse>> Delete(int id);
    }
}
