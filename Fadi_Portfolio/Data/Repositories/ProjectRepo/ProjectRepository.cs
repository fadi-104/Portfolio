using Fadi_Portfolio.Data.Repositories.Base;
using Fadi_Portfolio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fadi_Portfolio.Data.Repositories.ProjectRepo
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {

        public ProjectRepository(ApplicationDbContext context) : base(context)
        {
        }


    }
}
