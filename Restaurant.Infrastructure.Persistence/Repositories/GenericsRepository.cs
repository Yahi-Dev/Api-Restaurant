using Microsoft.EntityFrameworkCore;
using Restaurant.Core.Application.Interfaces.Repositories;
using Restaurant.Infrastructure.Persistence.Contexts;


namespace Application.Repositorio
{

    public class GenericsRepository<Entity>:  IGenericRepository<Entity> where Entity : class
    {
        private readonly ApplicationContext _dbcontext;


        public GenericsRepository(ApplicationContext applicationContext)
        {
            _dbcontext = applicationContext;
        }


        //Agregar
        public virtual async Task<Entity> AddAsync(Entity entity)
        {
            await _dbcontext.Set<Entity>().AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
            return entity;
        }


        //Editar
        public virtual async Task UpdateAsync(Entity entity, int id)
        {
           Entity entry = await _dbcontext.Set<Entity>().FindAsync(id);
           _dbcontext.Entry(entry).CurrentValues.SetValues(entity);
           await _dbcontext.SaveChangesAsync();
        }


        //Borrar
        public virtual async Task DeleteAsync(Entity entity)
        {
            _dbcontext.Set<Entity>().Remove(entity);
            await _dbcontext.SaveChangesAsync();
        }

        //Devolver todos los productos guardados
        public virtual async Task<List<Entity>> GetAllAsync()
        {
            return await _dbcontext.Set<Entity>().ToListAsync();
        }

        public virtual async Task<List<Entity>> GetAllWithIncludeAsync(List<string> properties)
        {
            var query = _dbcontext.Set<Entity>().AsQueryable();

            foreach (var property in properties)
            {
                query = query.Include(property);
            }

            return await query.ToListAsync();
        }

        public virtual async Task<Entity> GetById(int id)
        {
            return await _dbcontext.Set<Entity>().FindAsync(id);
        }
    }
}
