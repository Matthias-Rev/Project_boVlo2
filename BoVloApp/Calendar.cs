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
            "FROM calendar " +
            "WHERE SessionKey='{0}'"
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
                //datarow["Price"] = Int32.Parse(GlobalVar.types.Select(String.Format("idBike = '{0}'", row["idBike"].ToString()))[0]["Price"].ToString());
                //datarow["Size"] = row["Size"].ToString();
                //datarow["Color"] = GlobalVar.colors.Select(String.Format("idColor = '{0}'", row["idColor"].ToString()))[0]["Name"].ToString();
                data.Rows.Add(datarow);
                //LabelPrixTotal.Text = (Int32.Parse(row["Quantity"].ToString()) * Int32.Parse(datarow["Price"].ToString()) + Int32.Parse(LabelPrixTotal.Text)).ToString();
            }
            GlobalVar.DisplayTableByData(titels, data, tableLayoutPanel1);
            GlobalVar.SetLocation(this, -100, 0, tableLayoutPanel1);
        }
    }
}
