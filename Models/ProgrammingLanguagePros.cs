using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningCoding.Models
{
    public class ProgrammingLanguagePros
    {
        public int ProgrammingLanguageProsId { get; set; } 
        public string ProgrammingLanguageProsDesc { get; set; }

        public int ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}
