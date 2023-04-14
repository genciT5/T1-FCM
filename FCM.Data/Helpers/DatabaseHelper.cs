using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace FCM.Data.Helpers
{
    public static class DatabaseHelper
    {
        private static readonly string _connectionString;

        static DatabaseHelper()
        {
            _connectionString = GetConnectionString();
        }

        private static string GetConnectionString()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            var json = File.ReadAllText(path);
            var jObject = JObject.Parse(json);
            var connectionString = (string)jObject["ConnectionString"];
            return connectionString;
        }

        public static DataTable ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    var adapter = new SqlDataAdapter(command);
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
