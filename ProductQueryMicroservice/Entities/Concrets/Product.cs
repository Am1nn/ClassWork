
using ProductQueryMicroservice.Entities.Abstracts;

namespace ProductQueryMicroservice.Entities.Concrets;

public class Product:BaseEntity
{

    public string? Name { get; set; }
    public string? Description { get; set; }


}
