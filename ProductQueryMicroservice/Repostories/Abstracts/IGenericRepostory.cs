using ProductQueryMicroservice.Entities.Abstracts;

namespace ProductQueryMicroservice.Repostories.Abstracts
{
    public interface IGenericRepostory<T> where T: BaseEntity,new()
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T?> GetAsync(int id);




    }
}
