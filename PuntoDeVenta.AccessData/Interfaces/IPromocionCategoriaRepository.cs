using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Interfaces
{
    public interface IPromocionCategoriaRepository
    {

        bool SaveChanges();
        Task<bool> SaveChangesAsync();
        Task<List<PromocionCategoria>> GetAll(bool? habilitados);
        Task<PromocionCategoria> Create(PromocionCategoria pEntity);
        Task Delete(PromocionCategoria pEntity);
        Task<PromocionCategoria> GetById(int pId);
    }
}
