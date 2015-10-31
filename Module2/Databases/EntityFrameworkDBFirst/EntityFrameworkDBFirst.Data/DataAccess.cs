namespace EntityFrameworkDBFirst.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class DataAccess
    {
        public static void InsertCustomer(Customer custumer)
        {
            var dbContex = new NorthwindEntities();

            using (dbContex)
            {
                dbContex.Customers.Add(custumer);
                dbContex.SaveChanges();
            }
        }

        public static void DeleteCustomer(string custumerId)
        {
            var dbContex = new NorthwindEntities();
            
            using (dbContex)
            {
                var customer = dbContex.Customers
                                .Where(c => c.CustomerID == custumerId)
                                .FirstOrDefault();
                if (customer == null)
                {
                    return;
                }

                dbContex.Customers.Remove(customer);
                dbContex.SaveChanges();
            }
        }

        public static void ChangeCustomerContactName(string customerId, string newName)
        {
            var dbContex = new NorthwindEntities();

            using (dbContex)
            {
                var customer = dbContex.Customers
                    .FirstOrDefault(c => c.CustomerID == customerId);

                if (customer == null)
                {
                    return;
                }

                customer.ContactName = newName;
                dbContex.SaveChanges();
            }
        }

        public static List<Customer> FindCustomersWithOrdersInYearAndCountry(int year, string countryName)
        {
            var dbContex = new NorthwindEntities();

            var customers = dbContex.Customers
                .Where(c => c.Orders.Where(o => o.OrderDate.Value.Year == year && o.ShipCountry == countryName)
                    .Any(o => o.CustomerID == c.CustomerID))
                .Select(c => c)
                .ToList();

            return customers;
        }

        public static List<Customer> FindCustomersWithOrdersInYearAndCountryWithDbCommand(int year, string countryName)
        {
            var dbContext = new NorthwindEntities();

            string selectQuery =
                "SELECT DISTINCT " +
                "c.CustomerID AS[CustomerID]," +
                "c.CompanyName AS[CompanyName]," +
                "c.ContactName AS[ContactName]," +
                "c.ContactTitle AS[ContactTitle]," +
                "c.Address AS[Address]," +
                "c.City AS[City]," +
                "c.Region AS[Region]," +
                "c.PostalCode AS[PostalCode]," +
                "c.Country AS[Country]," +
                "c.Phone AS[Phone]," +
                "c.Fax AS[Fax]" +
                "FROM Customers AS c " +
                "JOIN Orders AS o " +
                "    ON c.CustomerID = o.CustomerID " +
                "WHERE c.Country = 'Canada' AND o.OrderDate BETWEEN '1997-01-01' AND '1997-12-31'";

            var customers = dbContext.Database.SqlQuery<Customer>(selectQuery).ToList();

            return customers;
        }

        public static List<Order> FindSales(string region, DateTime startDate, DateTime endDate)
        {
            var dbContex = new NorthwindEntities();

            var orders = dbContex.Orders
                    .Where(o => o.ShipRegion.ToLower() == region.ToLower()
                    && startDate <= o.OrderDate && o.OrderDate <= endDate)
                    .ToList();

            return orders;
        }
    }
}
