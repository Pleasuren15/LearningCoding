using LearningCoding.Models;

namespace LearningCoding.Data
{
    public class CRepositoryBook: CRepositoryBase<Book>,IRepositoryBook
    {
        public CRepositoryBook(AppDbContext appDbContext): base(appDbContext)
        {

        }
    }
}
