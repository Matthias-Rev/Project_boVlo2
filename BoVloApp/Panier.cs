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
using System.Data.SqlClient;

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


            panierData.DataSource = GetBasket();

        }


        private void buttonFinaliser_Click(object sender, EventArgs e)
        {
            GlobalVar.Loadform(PanelPanier, new CatalogueMember());
        }

        private DataTable GetBasket()
        {
            string request = String.Format("SELECT Bike.Name, Basket.Size, Basket.Quantity, Bike.Price " +
                "FROM Basket, Bike " +
                "WHERE Basket.SessionKey='{0}' " +
                "AND Basket.idBike = Bike.idBike"
            , GlobalVar.ReadXML().key);
            DataTable basket = GlobalVar.ReadSQL(request);

            return basket;

        }
        private void panierData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //
        //---------------------------------------------------------bouton pour update la db
        //
        private void updateDb_Click(object sender, EventArgs e)
        {
            //using (SqlBulkCopy bulkCopy = new SqlBulkCopy(Mysqlconn.connect()))
            //{
            //    foreach (DataColumn c in panierData.Columns)
            //        bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

            //    bulkCopy.DestinationTableName = panierData.TableName;
            //    try
            //    {
            //        bulkCopy.WriteToServer(panierData);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
        }
    }
}
