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
            try
            {
                vGblContext.Add(pEntity);
                await vGblContext.SaveChangesAsync();

                return pEntity;
            }
            catch (Exception ex)
            {
                vGblContext.ChangeTracker.Clear();
                throw ex;
            }   
        }

        public async Task Delete(CategoriaProducto pEntity)
        {
            try
            {
                vGblContext.Remove(pEntity);
                await vGblContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                vGblContext.ChangeTracker.Clear();
                throw ex;
            }
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
            try
            {
                return vGblContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                vGblContext.ChangeTracker.Clear();
                throw ex;
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                return await vGblContext.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                vGblContext.ChangeTracker.Clear();
                throw ex;
            }
        }
    }
}
