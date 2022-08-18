using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerbillingWebApi.Model
{
    [Serializable]
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Customer_Name { get; set; }
        
        public string Address { get; set; }
    }
}
