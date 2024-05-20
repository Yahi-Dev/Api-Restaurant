using Restaurant.Core.Application.Interfaces.Repositories;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Contexts;

namespace Application.Repositorio
{
    public class OrdenRepository : GenericsRepository<Orden>, IOrdenRepository
    {
        private readonly ApplicationContext _dbcontext;

        public OrdenRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _dbcontext = applicationContext;
        }
    }
}
