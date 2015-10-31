namespace _01.NumberOfRowsInCategories
{
    using System;
    using System.Data.SqlClient;

    public class Startup
    {
        public static void Main()
        {
            var connectionString = "Server=.\\; Database=Northwind; Integrated Security=true";
            var sqlConection = new SqlConnection(connectionString);
            sqlConection.Open();

            using (sqlConection)
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Categories", sqlConection);

                int rowCount = (int)cmd.ExecuteScalar();

                Console.Out.WriteLine("The number of rows is: {0}", rowCount);
            }
        }
    }
}
