using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoding.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [Required]
        [DisplayName("Title")]
        public string BookTitle { get; set; }

        [Required]
        [DisplayName("Image url")]
        public string BookUrlImage { get; set; }

        [Required]
        [DisplayName("Download url")]
        [Range(1, 5)]
        public string BookDownloadUrl { get; set; }
    }
}
