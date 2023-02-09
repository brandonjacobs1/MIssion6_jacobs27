using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MIssion6_jacobs27.Models
{
    public class Movie
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1000, 9999)]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string LentTo { get; set; }
        public bool Edited { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }
    }
}
