using LearningCoding.Models;
using System.Collections.Generic;

namespace LearningCoding.Data
{
    public interface IRepositoryProgrammingLanguage : IRepositoryBase<ProgrammingLanguage>
    {
        ProgrammingLanguage GetLanguagesWithProsAndCons(int Id);
    }
}
