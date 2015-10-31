namespace _03.ProductsInAnyCategory
{
    using System;
    using System.Data.SqlClient;

    public class Startup
    {
        public static void Main()
        {
            var connectionString = "Server=.\\; Database=Northwind; Integrated Security=true";
            var sqlComant = "SELECT c.CategoryName AS CategoryName, p.ProductName AS ProductName FROM Products p JOIN Categories c ON p.CategoryID= c.CategoryID ORDER BY c.CategoryName";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand comand = new SqlCommand(sqlComant, connection);
            connection.Open();

            using (connection)
            {
                SqlDataReader reader = comand.ExecuteReader();

                using (reader)
                {
                    int number = 1;
                    var lastCategory = string.Empty;
                    while (reader.Read())
                    {
                        var categoryName = (string)reader["CategoryName"];
                        var productName = (string)reader["ProductName"];

                        if (lastCategory != categoryName)
                        {
                            number = 1;
                            Console.WriteLine($"Category: {categoryName}");
                        }

                        Console.WriteLine("{0} - {1}", number, productName);
                        number++;
                        lastCategory = categoryName;
                    }
                }
            }
        }
    }
}
