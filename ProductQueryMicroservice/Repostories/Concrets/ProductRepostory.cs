using Autonet_Persistance.Contexts;
using ProductQueryMicroservice.Entities.Concrets;
using ProductQueryMicroservice.Repostories.Abstracts;

namespace ProductQueryMicroservice.Repostories.Concrets
{
    public class ProductRepostory : GenericRepostory<Product>, IProductRepostory
    {
        public ProductRepostory(AppDbContext context) : base(context)
        {
        }
    }
}
