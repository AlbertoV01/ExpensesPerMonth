using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ExpensesPerMonth
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;

        private static readonly object lockobj = new object();

        private SQLiteConnection connection;
        private DatabaseConnection() 
        {
            connection = new SQLiteConnection("Data Source=c:\\sqlite\\databases\\Gastos.db;");
        }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (lockobj)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseConnection();
                    }
                    return instance;
                }
            }
        }

        public SQLiteConnection Connection 
        { get { return connection; } }

    }
}
