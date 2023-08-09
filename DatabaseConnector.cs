using System;
using System.Data.SqlClient;

public class DatabaseConnector
{
    public bool ConnectToDatabase(string connectionString)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            return false;
        }
    }
}