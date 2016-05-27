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
        [Required, ScaffoldColumn(false)]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, MaxLength(500)]
        public string ProductText { get; set; }
        [Required, /*CustomAttribute.CustomAttributeChecker*/] //Freddie, när jag använder min CustomAttribute-klass smäller sidan. Jag begriper inte varför, då klassen ser OK ut?
        public int ProductNumber { get; set; }
        [Required]
        public double Price { get; set; }
        [Required, Range(0, 999)]
        public int ProductsInStock { get; set; }
        [Required, Range(1, 2)]
        public int StoreId { get; set; }

    }
}