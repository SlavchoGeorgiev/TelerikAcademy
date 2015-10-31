namespace _05.RetrievesImagesForAllCategories
{
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;

    public class Startup
    {
        private static SqlConnection connection;

        private static void Main()
        {
            connection = new SqlConnection("Server=.\\; Database=Northwind; Integrated Security=true");
            connection.Open();

            using (connection)
            {
                SqlCommand cmd = new SqlCommand("SELECT Picture FROM Categories", connection);

                var reader = cmd.ExecuteReader();
                using (reader)
                {
                    var number = 1;
                    while (reader.Read())
                    {
                        byte[] picture = (byte[])reader["Picture"];
                        SaveImageToFiles("Image-" + number, picture);
                        number++;
                    }
                }
            }
        }

        private static void SaveImageToFiles(string fileName, byte[] imgBinaryData, string fileExtension = "jpg", string filePath = "../../")
        {
            int imgStartPosition = 78;
            var memoryStream = new MemoryStream(imgBinaryData, imgStartPosition, imgBinaryData.Length - imgStartPosition);
            using (memoryStream)
            {
                using (var image = Image.FromStream(memoryStream, true, true))
                {
                    image.Save(filePath + fileName + "." + fileExtension);
                }
            }
        }
    }
}
