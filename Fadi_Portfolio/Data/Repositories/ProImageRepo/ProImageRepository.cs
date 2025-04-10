using Fadi_Portfolio.Data.Repositories.Base;
using Fadi_Portfolio.Entities;

namespace Fadi_Portfolio.Data.Repositories.ProImageRepo
{
    public class ProImageRepository : GenericRepository<ProImage>, IProImageRepository
    {
        public ProImageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
