namespace _04.AddProduct
{
    using System;
    using System.Data.SqlClient;

    public class Startup
    {
        public static void Main()
        {
            var connectionString = "Server=.\\; Database=Northwind; Integrated Security=true";

            SqlConnection connection = new SqlConnection(connectionString);
            var rowsNumber = InsertProduct(
                "TestProduct",
                2,
                3,
                "10 boxes x 20 bags",
                16.5M,
                35,
                10,
                1,
                true,
                connection);

            Console.WriteLine(rowsNumber >= 1 ? "Inserted" : "Not inserted");
        }

        public static int InsertProduct(
            string productName,
            int supplierID,
            int categoryID,
            string quantityPerUnit, 
            decimal unitPrice,
            int unitsInStock,
            int unitsOnOrder,
            int reorderLevel,
            bool discontinued,
            SqlConnection connection)
        {
            var afectedRows = 0;
            string insertComand = "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, Discontinued) " +
                                  "VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @Discontinued)";
            SqlCommand comand = new SqlCommand(insertComand, connection);
            comand.Parameters.AddWithValue("@ProductName", productName);
            comand.Parameters.AddWithValue("@SupplierID", supplierID);
            comand.Parameters.AddWithValue("@CategoryID", categoryID);
            comand.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit);
            comand.Parameters.AddWithValue("@UnitPrice", unitPrice);
            comand.Parameters.AddWithValue("@UnitsInStock", unitsInStock);
            comand.Parameters.AddWithValue("@UnitsOnOrder", unitsOnOrder);
            comand.Parameters.AddWithValue("@Discontinued", discontinued);
            
            connection.Open();
            using (connection)
            {
                afectedRows = comand.ExecuteNonQuery();
            }

            return afectedRows;
        }
    }
}
