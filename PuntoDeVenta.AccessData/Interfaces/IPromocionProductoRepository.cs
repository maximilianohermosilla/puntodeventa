using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IPromocionProductoRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<PromocionProducto>> GetAll(bool? habilitados);
        Task<PromocionProducto> Create(PromocionProducto pEntity);
        Task Delete(PromocionProducto pEntity);
        Task<PromocionProducto> GetById(int pId);
    }
}
