using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IProductoMovimientoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<ProductoMovimiento>> GetAllByFechaAndTipoMovimiento(DateTime pFechaDesde, DateTime pFechaHasta, int pIdTipoMovimiento);
        Task<ProductoMovimiento> Create(ProductoMovimiento pEntity);
        Task<List<ProductoMovimiento>> CreateRange(IList<ProductoMovimiento> pEntities);
        Task Delete(ProductoMovimiento pEntity);
        Task<ProductoMovimiento?> GetById(int pId);
    }
}
