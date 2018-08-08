using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ImportController {
    public class OraDatabase {
        public OracleConnection Connection { get; set; }
        string ConnString { get; set; }

        public OraDatabase(string connString) {
            ConnString = connString;
        }

        public string Connect() {
            try {
                Connection = new OracleConnection { ConnectionString = ConnString };
                Connection.Open();
                return "Connected to Oracle database: " + Connection.DatabaseName;
            } catch (Exception ex) {
                return ex.ToString();
            }
        }

        public void CloseConnection() {
            Connection.Close();
            Connection.Dispose();
        }

        private DataTable ExecuteQuery(OracleCommand cmd) {
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            da.Fill(dt);
            return dt;
        }

        public Task<DataTable> ExecuteQueryParallel(OracleCommand cmd) {
            return Task.Run(()=> ExecuteQuery(cmd));
        }

    }
}
