using PartsTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartsTracker.ViewModels
{
    public class CustomerOrder
    {
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}