using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace store2.Models
{
    public class Branch
    {
        public int ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 1)]
        [Display(Name = "Branch Name")]
        public string BranchName { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 1)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}
