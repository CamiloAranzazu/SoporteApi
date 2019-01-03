using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CORE.Soporte.Infraestructura
{
    public class BaseDatos
    {
        public static DataSet ExecuteSql(string connectionString, string SQL, bool IsStoredProcedure, params SqlParameter[] parameters)
        {
            using (SqlConnection Conexion = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter DA = new SqlDataAdapter(SQL, Conexion))
                {
                    DA.SelectCommand.CommandType = IsStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;
                    DA.SelectCommand.CommandTimeout = 300;
                    if (parameters != null && parameters.Length > 0)
                    {
                        DA.SelectCommand.Parameters.AddRange(parameters);
                    }
                    DataSet DS = new DataSet();
                    Conexion.Open();
                    DA.Fill(DS);
                    return DS;
                }
            }
        }

        public static void ExecuteNonQuery(string connectionString, string SQL)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                command.CommandType = CommandType.Text;
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void ExecuteSqlScript(string connectionString, string SQL)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                Regex r = new Regex(@"^[\t\r\n]*GO[\t\r\n]*\d*[\t\r\n]*(?:--.*)?$",
                    RegexOptions.Multiline |
                    RegexOptions.IgnorePatternWhitespace |
                    RegexOptions.IgnoreCase);

                foreach (string s in r.Split(SQL))
                {
                    string operation = s.Trim();
                    if (String.IsNullOrEmpty(operation)) continue;

                    SqlCommand cmd = new SqlCommand(operation, sqlConnection);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
