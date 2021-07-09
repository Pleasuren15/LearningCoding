using LearningCoding.Models;

namespace LearningCoding.Data
{
    public class CRepositoryProgrammingLanguage : CRepositoryBase<ProgrammingLanguage>, IRepositoryProgrammingLanguage
    {
        public CRepositoryProgrammingLanguage(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
