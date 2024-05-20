using Restaurant.Core.Application.Interfaces.Repositories;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Contexts;

namespace Application.Repositorio
{
    public class IngredientesRepository : GenericsRepository<Ingredientes>, IIngredientesRepository
    {
        private readonly ApplicationContext _dbcontext;

        public IngredientesRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _dbcontext = applicationContext;
        }
    }
}
