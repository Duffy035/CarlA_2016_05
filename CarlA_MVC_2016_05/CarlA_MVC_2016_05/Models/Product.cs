//Carl Andersson

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarlA_MVC_2016_05.Models
{
    public class Product
    {
        [Required, Range(1, 10000000), ScaffoldColumn(false)]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, MaxLength(500)]
        public string ProductText { get; set; }
        [Required, CustomAttribute.CustomAttributeChecker]
        public int ProductNumber { get; set; }
        [Required, Range(1, 9999999)]
        public double Price { get; set; }
        [Required, Range(0, 99999999)]
        public int ProductsInStock { get; set; }
        [Required]
        public int StoreId { get; set; }

    }
}