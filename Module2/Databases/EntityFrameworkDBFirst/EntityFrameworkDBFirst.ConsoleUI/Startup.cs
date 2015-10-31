namespace EntityFrameworkDBFirst.ConsoleUI
{
    using System;
    using System.Linq;

    using Data;

    public class Startup
    {
        public static void Main()
        {
            var newCustomer = new Customer()
            {
                CustomerID = "XASDa",
                ContactName = "Pesho",
                CompanyName = "Telerik"
            };

            DataAccess.InsertCustomer(newCustomer);
            Console.WriteLine("Customer inserted!");
            DataAccess.ChangeCustomerContactName(newCustomer.CustomerID, "Ivan");
            Console.WriteLine("Customer contact Name changed!");
            DataAccess.DeleteCustomer(newCustomer.CustomerID);
            Console.WriteLine("Customer deleted!");

            Console.WriteLine(new string('-', 50));
            var customers = DataAccess.FindCustomersWithOrdersInYearAndCountry(1997, "Canada");

            // Only for test, do not do it N+1 problem.
            customers
                .ForEach(c =>
                {
                    Console.WriteLine($"Contact Name: {c.ContactName}," +
                                      $" From: {c.Country}," +
                                      $" Has order in: {c.Orders.FirstOrDefault(o => o.OrderDate.Value.Year == 1997).OrderDate.Value.Year}");
                });

            customers = DataAccess.FindCustomersWithOrdersInYearAndCountryWithDbCommand(1997, "Canada");

            Console.WriteLine(new string('-', 50));
            customers
                .ForEach(c =>
                {
                    Console.WriteLine($"Contact Name: {c.ContactName}," +
                                      $" From: {c.Country},");
                });
            
            Console.WriteLine(new string('-', 50));

            var region = "RJ";
            var startDate = new DateTime(1996, 6, 3);
            var endDate = new DateTime(1997, 6, 3);

            var filterdOrders = DataAccess.FindSales(region, startDate, endDate);

            filterdOrders.ForEach(o => Console.WriteLine($"OrderId: {o.OrderID}," +
                                                         $" Region: {o.ShipRegion}," +
                                                         $" Order date: {o.OrderDate}"));
        }
    }
}
