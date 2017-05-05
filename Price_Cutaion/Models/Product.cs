using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Price_Cutaion.Models
{
    public class Product
    {
        [Key]
  
        public int producId { get; set; }
         
        public string productName { get; set; }
        public decimal productPrice { get; set; }
        public string productUrlImg{ get; set; }

    }
}