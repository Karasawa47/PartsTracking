using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PartsTracker.Models;
using System.Data.Entity;

namespace PartsTracker.DAL
{
    public class CustomerPartInitializer : DropCreateDatabaseIfModelChanges<PartTrackerDbContext>
    {
        protected override void Seed(PartTrackerDbContext context)
        {
            var customers = new List<Customer>
            {
              new Customer{FirstName="Simon",LastName="Roberts",Phone="4546432678",Email="Something@something.com"},
              new Customer{FirstName="Jack",LastName="Smith",Phone="4546432678",Email="Something@something.com"},
              new Customer{FirstName="Bob",LastName="Backster",Phone="4546432678",Email="Something@something.com"},
              new Customer{FirstName="Laura",LastName="Vader",Phone="4546432678",Email="Something@something.com"},
              new Customer{FirstName="Anthony",LastName="Skywalker",Phone="4546432678",Email="Something@something.com"},
              new Customer{FirstName="Sarah",LastName="Solo",Phone="4546432678",Email="Something@something.com"},
              new Customer{FirstName="Sean",LastName="Zahn",Phone="4546432678",Email="Something@something.com"},
              new Customer{FirstName="Videl",LastName="Thrawn",Phone="4546432678",Email="Something@something.com"},
              new Customer{FirstName="Roary",LastName="Garrett",Phone="4546432678",Email="Something@something.com"}

            };
            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order{CustomerID=1,Date=DateTime.Parse("2002-09-01"),DueDate=DateTime.Parse("2002-10-01"),Total=78.50m},
                new Order{CustomerID=1,Date=DateTime.Parse("2002-09-01"),DueDate=DateTime.Parse("2002-10-01"),Total=78.50m},
                new Order{CustomerID=1,Date=DateTime.Parse("2002-09-01"),DueDate=DateTime.Parse("2002-10-01"),Total=45.50m},
                new Order{CustomerID=2,Date=DateTime.Parse("2003-09-01"),DueDate=DateTime.Parse("2004-10-01"),Total=78.50m},
                new Order{CustomerID=2,Date=DateTime.Parse("2007-09-01"),DueDate=DateTime.Parse("2007-10-01"),Total=34.50m},
                new Order{CustomerID=3,Date=DateTime.Parse("2002-09-05"),DueDate=DateTime.Parse("2002-10-01"),Total=50.50m},
                new Order{CustomerID=3,Date=DateTime.Parse("2006-04-01"),DueDate=DateTime.Parse("2006-10-09"),Total=17.40m},
                new Order{CustomerID=3,Date=DateTime.Parse("2002-09-01"),DueDate=DateTime.Parse("2002-10-01"),Total=78.50m},
                new Order{CustomerID=3,Date=DateTime.Parse("2002-09-01"),DueDate=DateTime.Parse("2002-10-01"),Total=2.50m},

            };
            orders.ForEach(o => context.Orders.Add(o));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}