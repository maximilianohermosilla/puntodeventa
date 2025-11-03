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

        public async Task Delete(Producto pEntity)
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

        public async Task<List<Producto>> GetAll(bool? habilitados)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Producto.Where(x => habilitados == null || x.Habilitado == habilitados)
                .Include(p => p.CategoriaProducto).Include(p => p.SubCategoriaProducto).Include(p => p.Unidad).ToListAsync();
        }

        public async Task<List<Producto>> GetAllByCategoria(int pIdCategoriaProducto, int? pIdSubCategoriaProducto, bool? habilitados)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Producto.Where(x => (pIdCategoriaProducto == x.IdCategoriaProducto) 
                && (pIdSubCategoriaProducto == null || pIdSubCategoriaProducto == x.IdSubCategoriaProducto)
                && (habilitados == null || x.Habilitado == habilitados))
                .Include(p => p.CategoriaProducto).Include(p => p.SubCategoriaProducto).Include(p => p.Unidad).ToListAsync();
        }        

        public async Task<Producto?> GetById(int pId)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Producto.Include(p => p.CategoriaProducto).Include(p => p.SubCategoriaProducto).Include(p => p.Unidad)
                .Where(p => p.Id == pId).FirstOrDefaultAsync()!;
        }

        public async Task<Producto?> GetByCodigo(string pCodigo)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Producto.Include(p => p.CategoriaProducto).Include(p => p.SubCategoriaProducto).Include(p => p.Unidad)
                .Where(p => p.Codigo == pCodigo).FirstOrDefaultAsync()!;
        }
        public async Task<Producto?> GetByDescripcion(string pDescripcion)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Producto.Include(p => p.CategoriaProducto).Include(p => p.SubCategoriaProducto).Include(p => p.Unidad)
                .Where(p => p.Descripcion.Contains(pDescripcion) || p.CategoriaProducto.Descripcion.Contains(pDescripcion) || p.SubCategoriaProducto.Descripcion.Contains(pDescripcion))
                .FirstOrDefaultAsync()!;
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
