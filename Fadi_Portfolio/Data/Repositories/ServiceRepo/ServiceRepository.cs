using Fadi_Portfolio.Data.Repositories.Base;
using Fadi_Portfolio.Entities;

namespace Fadi_Portfolio.Data.Repositories.ServiceRepo
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(ApplicationDbContext context) : base(context)
        {   
        }
    }
}
