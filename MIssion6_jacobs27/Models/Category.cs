using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MIssion6_jacobs27.Models
{
    public class Category
    {   
        [Key]
        [Required]
        public int CategoryID {get; set;}
        public string CategoryName { get; set; }

    }
}
