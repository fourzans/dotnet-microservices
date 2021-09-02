using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DeveloperApi.Data.Database;

namespace DeveloperApi.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly DeveloperContext DeveloperContext;

        public Repository(DeveloperContext developerContext)
        {
            this.DeveloperContext = developerContext;
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return DeveloperContext.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception ($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await this.DeveloperContext.AddAsync(entity);
                await this.DevelperContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(UpdateAsync)} entity must not be null");
            }

            try
            {
                await this.DevelperContext.Update(entity);
                await this.DevelperContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated {ex.Message}");
            }
        }
    }
}