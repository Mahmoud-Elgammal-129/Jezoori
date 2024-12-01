namespace Jezoori.Repository;

public class RecipeRepository:BaseService<Recipe>,IRecipeRepository
{
    private readonly ApplicationDbContext _context;
    public RecipeRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
