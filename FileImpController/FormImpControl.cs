using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data.Common;

namespace FileImpController {
    public partial class FormImpControl : Form {
        OraDatabase OraDatabase { get; set; }

        public FormImpControl() {
            InitializeComponent();
        }

        private void ButtonCountClick(object sender, EventArgs e) {
            string query = "Select count(*) from TRANSMAIN";
            textBoxNumRows.Text = OraDatabase.ExecuteQuery(query).ToString();
            OraDatabase.CloseConnection();
        }

        private void ButtonConnectClick(object sender, EventArgs e) {
            string conStr = "Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = DK01SV7020)(PORT = 1521)))(CONNECT_DATA = (SID = T7020230)));User Id=TESTIMMD;Password=TESTIMMD;";
            OraDatabase = new OraDatabase(conStr);
            richTextBoxMessages.Text = OraDatabase.Connect();
        }
    }
}
