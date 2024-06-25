using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        public DbConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PROJEKAT"].ConnectionString);
        }
        public void OpenConnection()
        {
            connection?.Open();
        }
        public void CloseConnection()
        {
            if(connection != null && connection.State!=ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public void BeginTransaction()
        {
            transaction = connection?.BeginTransaction();
        }
        public void Commit()
        {
            if(transaction != null) transaction.Commit();
        }
        public void Rollback()
        {
            if(transaction != null) transaction.Rollback();
        }
        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", connection, transaction);
        }

        
    }
}
