using LeaveManagement.web.Data;
using LeaveManagement.web.Generics.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.web.GenericRepoistory
{
    public class GenericRepoistory<T> : IGenericRepoistory<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;

        public GenericRepoistory(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public async Task<T> AddAsync(T enitity)
        {
            await dbContext.AddAsync(enitity);
            await dbContext.SaveChangesAsync();
            return enitity;
        }

        public async Task DeleteAsync(int id)
        {
            var enitity = await dbContext.Set<T>().FindAsync(id);
            dbContext.Set<T>().Remove(enitity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllSync()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int? id)
        {
            if(id == null)
            {
                return null;
            }
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async Task<bool> HasAsync(int id)
        {
            var HasExists = await GetAsync(id);
            return HasExists != null;
        }

        public async Task UpdateAsync(T enitity)
        {
            dbContext.Update(enitity);
            await dbContext.SaveChangesAsync();
        }
    }
}