using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Repository
{
    public class SubCategoriaProductoRepository : ISubCategoriaProductoRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public SubCategoriaProductoRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<SubCategoriaProducto> Create(SubCategoriaProducto pEntity)
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

        public async Task Delete(SubCategoriaProducto pEntity)
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

        public async Task<List<SubCategoriaProducto>> GetAllByCategoria(int pIdCategoriaProducto, bool? habilitados)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.SubCategoriaProducto.Where(x => pIdCategoriaProducto == x.IdCategoriaProducto 
                && (habilitados == null || x.Habilitado == habilitados)).ToListAsync();
        }

        public async Task<SubCategoriaProducto> GetById(int pId)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.SubCategoriaProducto.Where(p => p.Id == pId).FirstOrDefaultAsync()!;
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
