using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IProductoMovimientoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<ProductoMovimiento>> GetAllByFechaAndTipoMovimiento(DateTime pFecha, int pIdTipoMovimiento);
        Task<ProductoMovimiento> Create(ProductoMovimiento pEntity);
        Task Delete(ProductoMovimiento pEntity);
        Task<ProductoMovimiento> GetById(int pId);
    }
}
