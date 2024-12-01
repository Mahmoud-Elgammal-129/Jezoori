namespace Jezoori.Repository;

public class SurveyRepository:BaseService<Survey>,ISurveyRepository
{
    private readonly ApplicationDbContext _context;
    public SurveyRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
