using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Repository
{
    public class CategoriaProductoRepository : ICategoriaProductoRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public CategoriaProductoRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<CategoriaProducto> Create(CategoriaProducto pEntity)
        {
            vGblContext.Add(pEntity);
            await vGblContext.SaveChangesAsync();

            return pEntity;      
        }

        public async Task Delete(CategoriaProducto pEntity)
        {
            vGblContext.Remove(pEntity);
            await vGblContext.SaveChangesAsync();
        }

        public async Task<List<CategoriaProducto>> GetAll()
        {
            return await vGblContext.CategoriaProducto.ToListAsync();
        }

        public async Task<CategoriaProducto> GetById(int pId)
        {
            return await vGblContext.CategoriaProducto.Where(p => p.Id == pId).FirstOrDefaultAsync()!;
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
