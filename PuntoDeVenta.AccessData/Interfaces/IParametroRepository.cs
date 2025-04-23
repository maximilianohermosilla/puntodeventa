using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IParametroRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Parametro>> GetAll();
        Task<Parametro> Create(Parametro pEntity);
        Task Delete(Parametro pEntity);
        Task<Parametro> GetById(int pId);
    }
}
