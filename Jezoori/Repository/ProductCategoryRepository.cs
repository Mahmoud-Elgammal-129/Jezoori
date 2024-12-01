
namespace Jezoori.Repository;

public class ProductCategoryRepository : BaseService<ProductCategory>, IProductCategoryRepository
{
    private readonly ApplicationDbContext _context;
    public ProductCategoryRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
