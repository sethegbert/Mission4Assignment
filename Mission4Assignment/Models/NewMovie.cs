using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Models
{
    public class NewMovie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage ="Please select a category.")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage ="Movie title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        public short Year { get; set; }

        [Required(ErrorMessage = "Please enter a director.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please select a rating.")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

    }
}
