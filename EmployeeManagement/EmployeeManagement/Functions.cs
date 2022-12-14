using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Functions
    {
        private SqlConnection sqlConnection;
        private string sqlConnectionStr;
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCommand;
        private DataTable dataTable;
        public Functions()
        {
            sqlConnectionStr = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=EmployeeManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(sqlConnectionStr);
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
        }

        public DataTable GetData(string Query)
        {
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter(Query, sqlConnectionStr);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public int SetData(string Query)
        {
            int n = 0;
            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();

            }

            sqlCommand.CommandText = Query;
            n = sqlCommand.ExecuteNonQuery();
            return n;
        }
    }
}
