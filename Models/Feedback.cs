using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoding.Models
{
    public class Feedback
    {
        [BindNever]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeedbackId { get; set; }

        [Required]
        [DisplayName("Name")]
        public string FeedbackName { get; set; }

        [Required]
        [DisplayName("Email")]
        public string FeedbackEmail { get; set; }

        [Required]
        [DisplayName("Subject")]
        public string FeedbackSubject { get; set; }

        [Required]
        [DisplayName("Message")]
        public string FeedbackMessage { get; set; }
    }
}
