namespace Jezoori.Repository;

public class SurveyDetailRepository:BaseService<SurveyDetail>,ISurveyDetailRepository
{
    private readonly ApplicationDbContext _context;
    public SurveyDetailRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
