using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningCoding.Models
{
    public class ProgrammingLanguage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProgrammingLanguageId { get; set; }
        public string ProgrammingLanguageName { get; set; }
        public string ProgrammingLanguageImageUrl { get; set; }
        public string ProgrammingLanguageCategory { get; set; }
        public string ProgrammingLanguageOverview { get; set; }
        public string ProgrammingLanguageHistory { get; set; }
        public string ProgrammingLanguageTutorials { get; set; }

        public ICollection<ProgrammingLanguagePros> ProgrammingLanguagePros { get; set; }
        public ICollection<ProgrammingLanguageCons> ProgrammingLanguageCons { get; set; }
    }
}
