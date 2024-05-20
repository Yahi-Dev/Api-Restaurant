using Restaurant.Core.Application.Interfaces.Repositories;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Contexts;

namespace Application.Repositorio
{
    public class PlatoRepository : GenericsRepository<Plato>, IPlatoRepository
    {
        private readonly ApplicationContext _dbcontext;

        public PlatoRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _dbcontext = applicationContext;
        }
    }
}
