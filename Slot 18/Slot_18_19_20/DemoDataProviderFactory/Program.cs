using System;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data;

namespace DemoDataProviderFactory
{
    class Program
    {
        //Get connection string from appsettings.json
        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConnection = config["ConnectionString:MyStoreDB"];
            return strConnection;
        }// end GetConnectionString
       static void ViewProducts()
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            //Get the connection object
            using DbConnection connection = factory.CreateConnection();
            if (connection == null)
            {
                Console.WriteLine($"Unable to create the connection object.");
                return;
            }
            connection.ConnectionString = GetConnectionString();
            connection.Open();
            //Make command object
            DbCommand command = factory.CreateCommand();
            if (command == null)
            {
                Console.WriteLine($"Unable to create the command object.");
                return;
            }
            command.Connection = connection;
            command.CommandText = "Select ProductID, ProductName From Products";
            //Print out data with data reader.
            using DbDataReader dataReader = command.ExecuteReader();
            Console.WriteLine("******Product List*********");
            while (dataReader.Read())
            {
                Console.WriteLine($"ProductID: {dataReader["ProductId"]}, " +
                    $"ProductName: {dataReader["ProductName"]}.");
            }
        }//end ViewProducts
        static void Main(String[] args)
        {
            ViewProducts();
            Console.ReadLine();
        }//end Main
    }

}
