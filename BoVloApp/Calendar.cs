using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoVloApp
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();

            string request = String.Format(
            "SELECT * " +
            "FROM calendar "
    ,       GlobalVar.ReadXML().key);
            DataTable calendar = GlobalVar.ReadSQL(request);
            string[] titels = { "Command_id", "Start date", "End date"};
            DataTable data = new();
            foreach (string titel in titels)
            {
                data.Columns.Add(titel);
            }
            foreach (DataRow row in calendar.Rows)
            {
                DataRow datarow = data.NewRow();
                datarow["Command_id"] = row["idOrder"].ToString();
                datarow["Start date"] = row["start"].ToString();
                datarow["End date"] = row["end"].ToString();
                data.Rows.Add(datarow);
            }
            //GlobalVar.DisplayTableByData(titels, data, tableLayoutPanel1);
            GlobalVar.SetLocation(this, -100, 0, tableLayoutPanel1);
        }
    }
}
