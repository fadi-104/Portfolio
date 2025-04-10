using Fadi_Portfolio.Data.Repositories.Base;
using Fadi_Portfolio.Entities;

namespace Fadi_Portfolio.Data.Repositories.ProTechRepo
{
    public class ProTechRepository : GenericRepository<ProTech>, IProTechRepository
    {
        public ProTechRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
