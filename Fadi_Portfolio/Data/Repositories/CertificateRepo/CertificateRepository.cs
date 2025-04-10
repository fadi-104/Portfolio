using Fadi_Portfolio.Data.Repositories.Base;
using Fadi_Portfolio.Entities;

namespace Fadi_Portfolio.Data.Repositories.CertificateRepo
{
    public class CertificateRepository : GenericRepository<Certificate>, ICertificateRepository
    {
        public CertificateRepository(ApplicationDbContext context) : base(context) 
        {   
        }
    }
}
