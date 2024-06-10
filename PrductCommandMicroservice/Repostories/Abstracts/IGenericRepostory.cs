using ProductQueryMicroservice.Entities.Abstracts;

namespace PrductCommandMicroservice.Repostories.Abstracts
{
    public interface IGenericRepostory<T> where T : BaseEntity
    {

        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task SaveChangeAsync();
    }
}
