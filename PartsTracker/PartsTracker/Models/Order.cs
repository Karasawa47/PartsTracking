using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PartsTracker.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        
        public int CustomerID { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date{get;set;}
        [DataType(DataType.DateTime)]
        public DateTime DueDate{get;set;}
        public decimal Total{get;set;}

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}