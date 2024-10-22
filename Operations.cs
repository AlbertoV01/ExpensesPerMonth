using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesPerMonth
{
    public  class Operations
    {
        public Boolean Insert(string date, decimal amount)
        {
            bool ok = false;
            try
            {
                var connection = DatabaseConnection.Instance.Connection;

                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

                string query = $"insert into gastos (fecha, monto) values ('{date}',{amount});";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
                ok = true;

            }
            catch (Exception ex)
            {
                String error = ex.Message;
            }
           
            return ok;
        }

        public Boolean Exist(string date)
        {
            Boolean ok = false;
            try
            {
                var connection = DatabaseConnection.Instance.Connection;
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

                string query = $"select fecha,monto from gastos where fecha='{date}';";
                using (var command = new SQLiteCommand(query,connection))
                {
                    DataTable table = new DataTable();
                    table.Load(command.ExecuteReader());
                    if(table.Rows.Count!=0) {ok=true;}

                }
            }
            catch (Exception e)
            {
                string error =e.Message;
                throw;
            }
            return ok;
        }

        public DataTable GetRows(string date)
        {
            DataTable table = new DataTable();

            try
            {
                var connection = DatabaseConnection.Instance.Connection;
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

                string query = $"select fecha,monto from gastos where fecha='{date}';";
                using (var command = new SQLiteCommand(query, connection))
                {
                    table.Load(command.ExecuteReader());

                }    
            }
            catch (Exception e)
            {
                string error = e.Message;
                throw;
            }
            return table;
        }

        public DataTable GetRowsWithOutFilters()
        {
            DataTable table = new DataTable();

            try
            {
                var connection = DatabaseConnection.Instance.Connection;
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

                string query = $"select fecha,monto from gastos;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    table.Load(command.ExecuteReader());

                }
            }
            catch (Exception e)
            {
                string error = e.Message;
                throw;
            }
            return table;
        }


    }
}
