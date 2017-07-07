using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace DapperWithOracle.Infra.Context
{
    public class OracleContext
    {
        private static OracleConnection _conn;

        public static OracleConnection GetConnection()
        {
            _conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OracleContext"].ConnectionString);
            _conn.Open();

            return _conn;
        }
    }
}