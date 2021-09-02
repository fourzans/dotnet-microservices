using System;
using System.Threading;
using System.Threading.Tasks;
using DeveloperApi.Data.Database;
using DeveloperApi.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DeveloperApi.Data.Repository
{
    public class DeveloperRepository : Repository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(DeveloperContext developerContext) : base(developerContext)
        {
        }

        public async Task<Developer> GetDeveloperByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await DeveloperContext.Developer.FirstOrDefaultAsync(d => d.Id == id, cancellationToken);
        }
    }
}