using PartsTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartsTracker.ViewModels
{
    public class AllModels
    {
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<OrderDetail> OrderDetails{get;set;}
        public IEnumerable<Part> Parts { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}