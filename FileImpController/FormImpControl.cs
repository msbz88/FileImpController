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

namespace ImportController {
    public partial class FormImpControl : Form {
        OraDatabase OraDatabase { get; set; }
        DateTime FromCrets { get; set; }

        public FormImpControl() {
            InitializeComponent();
            InitListView();
        }

        private void InitListView() {
            listViewTransCode.Columns.Add("Trans. Code", 150, HorizontalAlignment.Left);
            listViewTransCode.Columns.Add("Count", 50, HorizontalAlignment.Left);
        }

        private void FillListView(DataTable dt) {
            listViewTransCode.Items.Clear();
            foreach (DataRow row in dt.Rows) {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++) {
                    item.SubItems.Add(row[i].ToString());
                }
                listViewTransCode.Items.Add(item);
            }
        }

        private async void ButtonCountClick(object sender, EventArgs e) {
            if (OraDatabase != null) {
                FromCrets = new DateTime(2017, 5, 1);
                string FromCretsStr = FromCrets.ToString("dd'/'MM'/'yyyy HH:mm:ss");
                string query = "Select trc.trcbus, count(t.transik) " +
                               "From TRANSMAIN t join TRCBUS trc on trc.trcbusno = t.trcbusno " +
                               "Where t.tracan=0 and t.chgts>=to_timestamp(:FromChgts,'DD/MM/YYYY HH24:MI:SS') " +
                               "Group by trc.trcbus " +
                               "Order by trc.trcbus";
                OracleCommand cmd = new OracleCommand(query, OraDatabase.Connection);
                listViewTransCode.Items.Clear();
                textBoxMessages.Text = "Calculating...";
                cmd.Parameters.Add(":FromChgts", OracleDbType.Varchar2).Value = FromCretsStr;
                DataTable dt = await OraDatabase.ExecuteQueryParallel(cmd);
                FillListView(dt);
                textBoxMessages.Text = "";
            } else {
                textBoxMessages.Text = "Please connect first";
            }
        }

        private void ButtonConnectClick(object sender, EventArgs e) {
            if (OraDatabase == null) {
                string conStr = "Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = DK01SV7020)(PORT = 1521)))(CONNECT_DATA = (SID = T7020230)));User Id=TESTIMMD;Password=TESTIMMD;";
                OraDatabase = new OraDatabase(conStr);
                textBoxMessages.Text = OraDatabase.Connect();
            }
        }

        private void ListViewTransCodeColumnClick(object sender, ColumnClickEventArgs e) {
            ItemComparer sorter = listViewTransCode.ListViewItemSorter as ItemComparer;
            if (sorter == null) {
                sorter = new ItemComparer(e.Column);
                listViewTransCode.ListViewItemSorter = sorter;
            } else {
                sorter.Column = e.Column;
            }
            listViewTransCode.Sort();
        }
    }
}
