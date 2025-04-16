using Fadi_Portfolio.Data.Repositories.Base;
using Fadi_Portfolio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fadi_Portfolio.Data.Repositories.CertificateRepo
{
    public class CertificateRepository : GenericRepository<Certificate>, ICertificateRepository
    {
        private readonly DbSet<Certificate> _certificates;
        public CertificateRepository(ApplicationDbContext context) : base(context) 
        {
            _certificates = context.Set<Certificate>();
        }

        public async Task<Certificate> GetByNameAsync(string name)
        {
            return await _certificates.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Name == name);
        }
    }
}
