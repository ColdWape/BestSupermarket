using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestSupermarket.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool IsDiscount { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public string Photo { get; set; }

        public int NewPrice { get; set; }


    }
}
