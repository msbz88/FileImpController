using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FileImpController {
    public class OraDatabase {
        OracleConnection Connection { get; set; }
        string ConnString { get; set; }

        public OraDatabase(string connString) {
            ConnString = connString;
        }

        public string Connect() {
            try {
                Connection = new OracleConnection {ConnectionString = ConnString};
                Connection.Open();
                return "Connected to Oracle database: " + Connection.DatabaseName;
            }
            catch(Exception ex) {
                return ex.ToString();
            }
        }

        public void CloseConnection() {
            Connection.Close();
            Connection.Dispose();
        }

        public int ExecuteQuery(string query) {
            OracleCommand cmd = new OracleCommand(query, Connection);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int res = 0;
            try {
                while (dr.Read()) {
                    res = (int)dr.GetDecimal(0);
                }
            }
            finally {
                dr.Close();
            }
            return res;
        }


    }
}
