

namespace Jezoori.Repository;

public class ProductRepository : BaseService<Product>, IProductRepository
{
    private readonly ApplicationDbContext _context;
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
