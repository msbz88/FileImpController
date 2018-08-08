﻿namespace FileImpController {
    public class Connection {
        public string Data { get; set; }

        public Connection(string data, string host, string port, string sid, string serviceName, string schema, string password) {
            string sidOrServiceName = "";
            if (sid=="") {
                sidOrServiceName = "SERVICE_NAME=" + serviceName;
            }
            else {
                sidOrServiceName = "SID=" + sid;
            }
            Data = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(" +
                           "HOST="+ host + ")(" +
                           "PORT=" + port + ")))(CONNECT_DATA=(" +
                           sidOrServiceName + "))); " +
                           "User Id=" + schema + "; " +
                           "Password=" + password + ";";
        }
    }
}
