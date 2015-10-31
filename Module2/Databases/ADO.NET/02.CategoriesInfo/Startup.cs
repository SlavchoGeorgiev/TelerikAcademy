namespace _02.CategoriesInfo
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
                SqlCommand cmd = new SqlCommand("SELECT CategoryName, [Description] FROM Categories", sqlConection);

                SqlDataReader dataReader = cmd.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read())
                    {
                        var name = (string)dataReader["CategoryName"];
                        var descr = (string)dataReader["Description"];

                        Console.WriteLine("{0} - {1}", name, descr);
                    }
                }
            }
        }
    }
}
