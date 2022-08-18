using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerbillingWebApi.Model
{
    [Serializable]
    public class Invoice
    {
        [Key]
        public int ID { get; set; }

        public int Customer_ID { get; set; }

        public string Invoice_Number { get; set; }

        public DateTime Created_Date { get; set; }
    }
}

