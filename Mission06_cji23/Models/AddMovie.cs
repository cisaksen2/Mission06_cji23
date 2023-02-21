using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_cji23.Models
{
    public class AddMovie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "A title is required!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "A year is required!")]
        public int Year { get; set; }
        [Required(ErrorMessage = "A director is required!")]
        public string Director { get; set; }
        [Required(ErrorMessage = "A rating is required!")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
