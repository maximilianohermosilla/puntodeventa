using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface ICajaMovimientoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<CajaMovimiento>> GetAll();
        Task<List<CajaMovimiento>> GetAllByIdTurno(int pIdTurno);
        Task<CajaMovimiento> GetLast();
        Task<List<CajaMovimiento>> GetAllByFechaAndTipoMovimientoFormaPago(DateTime pFechaDesde, DateTime pFechaHasta, int pIdTipoMovimiento, int pIdFormaPago);
        Task<CajaMovimiento> Create(CajaMovimiento pEntity);
        Task Delete(CajaMovimiento pEntity);
        Task<CajaMovimiento> GetById(int pId);
    }
}
