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
        Main main = null;
        public Panier(Main main)
        {
            this.main = main;
            InitializeComponent();
            DisplayBasket();
        }
        private void DisplayBasket()
        {
            DataTable basket = GetBasket();
            panierData.DataSource = basket;
            int prixtotal = 0;
            foreach(DataRow row in basket.Rows)
            {
                prixtotal += Int32.Parse(row["Price"].ToString()) * Int32.Parse(row["Quantity"].ToString());
            }
            LabelPrixTotal.Text = prixtotal.ToString();
        }


        private void buttonFinaliser_Click(object sender, EventArgs e)
        {
            GlobalVar.Loadform(PanelPanier, new CatalogueMember(main));
        }

        private DataTable GetBasket()
        {
            string request = String.Format("SELECT Bike.Name, Basket.Size, Bike.Price, Basket.Quantity " +
                "FROM Basket, Bike " +
                "WHERE Basket.SessionKey='{0}' " +
                "AND Basket.idBike = Bike.idBike"
            , GlobalVar.ReadXML().key);
            DataTable basket = GlobalVar.ReadSQL(request);
            return basket;
        }
        //
        //---------------------------------------------------------bouton pour update la db--------------------------------------------
        //
        private void updateDb_Click(object sender, EventArgs e)
        {
            //using (SqlBulkCopy bulkcopy = new SqlBulkCopy(Mysqlconn.connect()))
            //{
            //    foreach (DataColumn c in panierData.Columns)
            //        bulkcopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

            //    bulkcopy.DestinationTableName = panierData.TableName;
            //    try
            //    {
            //        bulkcopy.WriteToServer(DataTable);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            foreach (DataRow row in GetBasket().Rows)
            {
                string query = "Insert INTO temp_table (Name, Size, Quantity, Price ) values (" 
                    + row["Name"] + ", "    
                    + row["Size"] + ", " 
                    + row["Quantity"] + ", " 
                    + row["Price"] + ")";
                GlobalVar.WriteSQL(query);
            }
        }
    }
}
