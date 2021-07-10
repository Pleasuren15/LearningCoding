using LearningCoding.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LearningCoding.Data
{
    public class CRepositoryProgrammingLanguage : CRepositoryBase<ProgrammingLanguage>, IRepositoryProgrammingLanguage
    {
        public CRepositoryProgrammingLanguage(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public ProgrammingLanguage GetLanguagesWithProsAndCons(int Id)
        {
            return _appDbContext.ProgrammingLanguages.Include(e => e.ProgrammingLanguagePros)
                                            .Include(e => e.ProgrammingLanguageCons)
                .FirstOrDefault(e => e.ProgrammingLanguageId == Id);
        }
    }
}
