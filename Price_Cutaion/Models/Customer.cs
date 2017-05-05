using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Price_Cutaion.Models
{
    public class Customer
    {
        [Key]
        public int customerId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string customerName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string customerEmail { get; set; }
        [Required]
        [Display(Name = "Phone")]
        [Phone]
        public string customerPhone { get; set; }

    }
}