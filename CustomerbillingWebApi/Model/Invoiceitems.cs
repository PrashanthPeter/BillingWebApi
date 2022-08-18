using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerbillingWebApi.Model
{
    [Serializable]
    public class Invoiceitems
    {
        [Key]
        public int ID { get; set; }

        public int InvoiceID { get; set; }

        public int ItemID { get; set; }

        public int Price { get; set; }
    }
}

