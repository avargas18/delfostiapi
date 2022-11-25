using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delfostidata
{
    public class SqlServerConnection
    {
        private string connectionString;
        public SqlServerConnection(string connection)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
        }

        public string ExecuteCommandJson(string procedure, string param)
        {
            string result = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(procedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@params", param);
                    object data = cmd.ExecuteScalar();
                    if (data != null) result = data.ToString();

                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }
            }
            return result;
        }

    }
}
