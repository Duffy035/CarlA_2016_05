//Carl Andersson

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarlA_MVC_2016_05.Models
{
    public class CustomAttribute
    {
        public class CustomAttributeChecker : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                if (value == null)
                {
                    return false;
                }
                var checkProduct = value.ToString().StartsWith("p-") && value.ToString().EndsWith(value.ToString());
                return checkProduct;
            }

            public override string FormatErrorMessage(string name)
            {
                return name + @" must start with 'p-' followed by a number. Please try again";
            }
        }
    }
}