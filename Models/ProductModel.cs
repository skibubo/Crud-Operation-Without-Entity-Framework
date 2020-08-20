using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcWithoutEntityFramework.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        [DisplayName ("Product Name")]
        public String ProductName { get; set; }
        public Decimal Price { get; set; }
        public int Count { get; set; }
    }
}