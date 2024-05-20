using Restaurant.Core.Application.Interfaces.Repositories;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Contexts;

namespace Application.Repositorio
{
    public class MesaRepository : GenericsRepository<Mesa>, IMesaRepository
    {
        private readonly ApplicationContext _dbcontext;

        public MesaRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _dbcontext = applicationContext;
        }
    }
}
