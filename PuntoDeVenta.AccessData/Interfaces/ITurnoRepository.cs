using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface ITurnoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Turno>> GetAll();
        Task<Turno> Create(Turno pEntity);
        Task Delete(Turno pEntity);
        Task<Turno> GetById(int pId);
    }
}
