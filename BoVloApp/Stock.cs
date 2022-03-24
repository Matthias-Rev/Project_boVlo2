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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            //check credentials in database
            string request = String.Format(
                "SELECT * " +
                "FROM Piece "
                , GlobalVar.ReadXML().key);
            DataTable basket = GlobalVar.ReadSQL(request);
            string[] titels = { "NamePiece","id" };
            DataTable data = new();
            foreach (string titel in titels)
            {
                data.Columns.Add(titel);

            }
            foreach (DataRow row in basket.Rows)
            {
                DataRow datarow = data.NewRow();
                datarow["NamePiece"] = row["NamePiece"].ToString();
                datarow["idPiece"] = row["idPiece"].ToString();
                data.Rows.Add(datarow);
                GlobalVar.DisplayTableByData(titels, data, tableLayoutPanel1);
                GlobalVar.SetLocation(this, -100, 0, tableLayoutPanel1);
            }
        }
    }
}
