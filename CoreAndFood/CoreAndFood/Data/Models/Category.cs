using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Category name not empty")]
        [StringLength (20,ErrorMessage= "Please max enter 4-20 lenght characters",MinimumLength =4)]

        public string CategoryName { get; set; }
        public bool Status { get; set; }
        public string CategoryDescription { get; set; }
        public List<Food> Foods { get; set; }
    }
}
