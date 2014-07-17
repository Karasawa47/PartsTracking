using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartsTracker.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }
        public int PartID { get; set; }
        public int Quantity { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal OrderPrice { get; set; }
    }
}