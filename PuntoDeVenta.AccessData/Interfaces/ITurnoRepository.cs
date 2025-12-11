using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface ITurnoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<Turno>> GetAll();
        Task<List<Turno>> GetAllByFecha(DateTime pFechaDesde, DateTime pFechahasta);
        Task<List<Turno>> GetAllByFechaUsuario(DateOnly fecha, int? idUsuario);
        Task<Turno> Create(Turno pEntity);
        Task Delete(Turno pEntity);
        Task<Turno> GetById(int pId);
        Task<Turno> GetByIdUsuario(int pIdUsuario, bool? pFinalizado);
    }
}
