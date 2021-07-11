using LearningCoding.Models;

namespace LearningCoding.Data
{
    public class CRepositoryFeedback : CRepositoryBase<Feedback> , IRepositoryFeedback
    {
        public CRepositoryFeedback(AppDbContext _appDbContext) : base(_appDbContext)
        {

        }
    }
}
