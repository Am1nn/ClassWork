using Autonet_Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using ProductQueryMicroservice.Entities.Abstracts;
using ProductQueryMicroservice.Repostories.Abstracts;

namespace ProductQueryMicroservice.Repostories.Concrets
{
    public class GenericRepostory<T> : IGenericRepostory<T> where T : BaseEntity, new()
    {

        protected readonly AppDbContext _appDbContext;
        public GenericRepostory(AppDbContext context) {
            _appDbContext = context;
        }
        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _appDbContext.Set<T>().ToListAsync();
        }

        public Task<T?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _appDbContext.Set<T>().FirstOrDefaultAsync(p=>p.Id==id);
        }
    }
}
