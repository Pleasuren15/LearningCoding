using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoding.Data.Wrapper
{
    public class CRepositoryWrapper : IRepositoryWrapper
    {
        AppDbContext _appDbContext { get; set; }
        IRepositoryProgrammingLanguage repositoryProgrammingLanguage;
        IRepositoryFeedback repositoryFeedback;

        public CRepositoryWrapper(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IRepositoryProgrammingLanguage _repositoryProgramming
        {
            get 
            {
                if (repositoryProgrammingLanguage == null)
                    repositoryProgrammingLanguage = new CRepositoryProgrammingLanguage(_appDbContext);
                return repositoryProgrammingLanguage;
            } 
        }

        public IRepositoryFeedback _repositoryFeedback
        {
            get
            {
                if (repositoryFeedback == null)
                    repositoryFeedback = new CRepositoryFeedback(_appDbContext);
                return repositoryFeedback;
            }
        }


    }
}
