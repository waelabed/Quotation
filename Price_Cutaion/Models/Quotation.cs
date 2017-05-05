using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Price_Cutaion.Models
{
    public class Quotation
    {
        [Key]
        public int pricecutaionId { get; set; }
      
        public Customer customerId { get; set; }
       



    }
}