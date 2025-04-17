using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Repository
{
    public class ProductoRepository : IProductoRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public ProductoRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<Producto> Create(Producto pEntity)
        {
            vGblContext.Add(pEntity);
            await vGblContext.SaveChangesAsync();

            return pEntity;      
        }

        public async Task Delete(Producto pEntity)
        {
            vGblContext.Remove(pEntity);
            await vGblContext.SaveChangesAsync();
        }

        public async Task<List<Producto>> GetAll()
        {
            return await vGblContext.Producto.ToListAsync();
        }

        public async Task<Producto> GetById(int pId)
        {
            return await vGblContext.Producto.Where(p => p.Id == pId).FirstOrDefaultAsync()!;
        }

        public bool SaveChanges()
        {
            return vGblContext.SaveChanges() > 0;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await vGblContext.SaveChangesAsync() > 0;
        }
    }
}
