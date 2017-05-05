using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Price_Cutaion.Models
{
    public class Terms
    {
        [Key]
        public int termsId { get; set; }
        public Quotation QuotationId { get; set; }
        public string termsName { get; set; }
        public string termsDescription { get; set; }
        
    }
}