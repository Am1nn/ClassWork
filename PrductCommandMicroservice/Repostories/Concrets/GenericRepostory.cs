using Microsoft.AspNetCore.Http.Connections;
using Microsoft.EntityFrameworkCore;
using PrductCommandMicroservice.DbContexts;
using PrductCommandMicroservice.Repostories.Abstracts;
using ProductQueryMicroservice.Entities.Abstracts;

namespace PrductCommandMicroservice.Repostories.Concrets
{
    public class GenericRepostory<T> : IGenericRepostory<T> where T : BaseEntity, new()
    {


        protected readonly AppDbContext _appDbContext;

        public GenericRepostory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _appDbContext.Set<T>().AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(int id)
        {
            var data=await _appDbContext.Set<T>().FirstOrDefaultAsync(P=>P.Id==id);
            _appDbContext.Set<T>().Remove(data);
            await _appDbContext.SaveChangesAsync();
            return data;
        }

        public async Task SaveChangeAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
             _appDbContext.Set<T>().Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
