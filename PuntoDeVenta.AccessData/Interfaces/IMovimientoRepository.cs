using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IMovimientoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Movimiento>> GetAll();
        Task<List<Movimiento>> GetAllByIdTurno(int pIdTurno);
        Task<Movimiento> Create(Movimiento pEntity);
        Task Delete(Movimiento pEntity);
        Task<Movimiento> GetById(int pId);
    }
}
