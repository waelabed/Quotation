using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Price_Cutaion.Models
{
    public class SalesProduct
    {

        [Key]
        public int salesproductId { get; set; }
        public Product productId { get; set; }
        public int salesproductQuantity { get; set; }
        public decimal salesproductTotalPrice { get; set; }
        public Quotation QuotationId { get; set; }

    }
}