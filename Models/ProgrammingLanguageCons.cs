using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningCoding.Models
{
    public class ProgrammingLanguageCons
    {
        public int ProgrammingLanguageConsId { get; set; } 
        public string ProgrammingLanguageConsDesc { get; set; }

        public int ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}