using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartsTracker.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        public string PaymentType { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal PaymentAmount { get; set; }
    }
}