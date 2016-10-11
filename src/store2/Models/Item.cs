using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace store2.Models
{
    public class Item
    {
        public int ID { get; set; }

        public int SupplierID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 1)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Details")]
        public string Details { get; set; }

        [Range(1, 1000)]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public int Price { get; set; }

        
        [Display(Name = "Category")]
        public string Category { get; set; }

        public string Picture { get; set; }

        [Display(Name = "Date of publish")]
        public DateTime DateOfPublish { get; set; }

        public Supplier Supplier { get; set; }


    }
}
