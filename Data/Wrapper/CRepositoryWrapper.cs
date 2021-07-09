using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoding.Data.Wrapper
{
    public class CRepositoryWrapper : IRepositoryWrapper
    {
        AppDbContext _appDbContext { get; set; }
        IRepositoryProgrammingLanguage _repositoryProgrammingLanguage;

        public CRepositoryWrapper(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IRepositoryProgrammingLanguage _repositoryProgramming
        {
            get 
            {
                if (_repositoryProgrammingLanguage == null)
                    _repositoryProgrammingLanguage = new CRepositoryProgrammingLanguage(_appDbContext);
                return _repositoryProgrammingLanguage;
            } 
        }

    }
}
