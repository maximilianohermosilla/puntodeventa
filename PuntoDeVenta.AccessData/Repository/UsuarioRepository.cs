using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.Domain.Entities;

namespace PuntoDeVenta.AccessData.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly PuntoDeVentaDbContext vGblContext;

        public UsuarioRepository(PuntoDeVentaDbContext context)
        {
            vGblContext = context;
        }

        public async Task<Usuario> Create(Usuario pEntity)
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

        public async Task Delete(Usuario pEntity)
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

        public async Task<List<Usuario>> GetAll(bool? habilitados)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Usuario.Where(x => habilitados == null || x.Habilitado == habilitados).ToListAsync();
        }

        public async Task<Usuario> GetById(int pId)
        {
            vGblContext.ChangeTracker.Clear();
            return await vGblContext.Usuario.Where(p => p.Id == pId).FirstOrDefaultAsync()!;
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
