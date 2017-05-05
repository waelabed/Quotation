using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Price_Cutaion.Models
{
    public class ProductVM
    {
        [Key]

        public int producId { get; set; }
        [Required]
        [Display (Name="Name")]
        public string productName { get; set; }

        [Display(Name = "Price")]
        [Required]
        public decimal productPrice { get; set; }

        [Display(Name = "Image")]
        public string productUrlImg{ get; set; }
        [Required]
        [Display(Name = "Image")]
        public HttpPostedFileBase productAttachImg { get; set; }
    }
}