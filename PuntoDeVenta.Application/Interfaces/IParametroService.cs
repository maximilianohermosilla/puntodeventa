using PuntoDeVenta.Application.DTO;

namespace PuntoDeVenta.Application.Interfaces
{
    public interface IParametroService
    {
        Task<ResponseModel<List<ParametroResponse>>> GetAll();
        Task<ResponseModel<ParametroResponse>> GetById(int id);
        Task<ResponseModel<ParametroResponse>> Insert(ParametroRequest entity);
        Task<ResponseModel<ParametroResponse>> Update(ParametroRequest entity);
        Task<ResponseModel<ParametroResponse>> Delete(int id);
    }
}
