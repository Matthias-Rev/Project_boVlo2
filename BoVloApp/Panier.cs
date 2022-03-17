using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BoVloApp
{
    public partial class Panier : Form
    {
        public Panier()
        {
            InitializeComponent();

            //check credentials in database
            string request = String.Format(
                "SELECT * " +
                "FROM Basket " +
                "WHERE SessionKey='{0}'"
                , GlobalVar.ReadXML().key);
            DataTable basket = GlobalVar.ReadSQL(request);
            string[] titels = { "Quantity", "Type", "Price", "Size", "Color" };
            DataTable data = new();
            foreach(string titel in titels)
            {
                data.Columns.Add(titel);
            }
            foreach(DataRow row in basket.Rows)
            {
                DataRow datarow = data.NewRow();
                datarow["Quantity"] = row["Quantity"].ToString();
                datarow["Type"] = GlobalVar.types.Select(String.Format("idBike = '{0}'", row["idBike"].ToString()))[0]["Name"].ToString();
                datarow["Price"] = Int32.Parse(GlobalVar.types.Select(String.Format("idBike = '{0}'", row["idBike"].ToString()))[0]["Price"].ToString());
                datarow["Size"] = row["Size"].ToString();
                datarow["Color"] = GlobalVar.colors.Select(String.Format("idColor = '{0}'", row["idColor"].ToString()))[0]["Name"].ToString();
                data.Rows.Add(datarow);
                LabelPrixTotal.Text = (Int32.Parse(row["Quantity"].ToString())* Int32.Parse(datarow["Price"].ToString()) + Int32.Parse(LabelPrixTotal.Text)).ToString();
            }
            GlobalVar.DisplayTableByData(titels, data, TableLayoutPanel);
            GlobalVar.SetLocation(this, -100, 0, TableLayoutPanel);
            //foreach (DataRow row in data.Rows)
            //{

            //    TableLayoutPanel.Controls.Add(new Label() { Text = row["Quantity"].ToString() });
            //    TableLayoutPanel.Controls.Add(new Label() { Text = row["Product_type"].ToString() });
            //    TableLayoutPanel.Controls.Add(new Label() { Text = row["Price"].ToString() });
            //    TableLayoutPanel.Controls.Add(new Label() { Text = row["Size"].ToString() });
            //    TableLayoutPanel.Controls.Add(new Label() { Text = row["Colour"].ToString() });
            //}


        }


        private void buttonFinaliser_Click(object sender, EventArgs e)
        {
            GlobalVar.Loadform(PanelPanier, new CatalogueMember());
        }

    }
}
