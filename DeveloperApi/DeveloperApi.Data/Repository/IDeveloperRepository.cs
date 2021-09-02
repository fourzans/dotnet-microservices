using System;
using System.Threading;
using System.Threading.Tasks;
using DeveloperApi.Data.Entites;

namespace DeveloperApi.Data.Repository
{
    public interface IDeveloperRepository: IRepository<Developer>
    {
        Task<Developer> GetDeveloperByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}