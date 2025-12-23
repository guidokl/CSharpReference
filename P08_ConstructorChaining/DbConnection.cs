using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_ConstructorChaining
{
    internal class DbConnection
    {
        private string _connectionString;
        // for Example "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
        private TimeSpan _timeout;

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string cannot be null or empty.");

            _connectionString = connectionString;
        }

        public virtual void Open()
        {
            Console.WriteLine("Opening database connection...");
            // Logic to open the database connection
        }

        public virtual void Close()
        {
            Console.WriteLine("Closing database connection...");
            // Logic to close the database connection
        }
    }

    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString) // Call base class constructor
        {
            // Additional initialization for SqlConnection if needed
        }

        public override void Open()
        {
            Console.WriteLine("Opening SQL database connection...");
            // Logic specific to opening SQL database connection
            base.Open(); // Optionally call base method
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL database connection...");
            // Logic specific to closing SQL database connection
            base.Close(); // Optionally call base method
        }
    }

    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString) // Call base class constructor
        {
            // Additional initialization for OracleConnection if needed
        }
        public override void Open()
        {
            Console.WriteLine("Opening Oracle database connection...");
            // Logic specific to opening Oracle database connection
            base.Open(); // Optionally call base method
        }
        public override void Close()
        {
            Console.WriteLine("Closing Oracle database connection...");
            // Logic specific to closing Oracle database connection
            base.Close(); // Optionally call base method
        }
    }
}