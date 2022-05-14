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
            CalculatePrice(basket);
        }

        private void CalculatePrice(DataTable basket)
        {
            int prixtotal = 0;
            foreach (DataRow row in basket.Rows)
            {
                prixtotal += Int32.Parse(row["Price"].ToString()) * Int32.Parse(row["Quantity"].ToString());
            }
            LabelPrixTotal.Text = prixtotal.ToString();
        }

        private void buttonFinaliser_Click(object sender, EventArgs e)
        {
            GlobalVar.Loadform(PanelPanier, new CatalogMember(main));
        }

        private DataTable GetBasket()
        {
            string request = String.Format("SELECT Basket.idArticle, Bike.Name, Basket.Size, Bike.Price, Basket.Quantity " +
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
        private void panierData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = panierData.CurrentCell.OwningColumn.Name;
            int cellValue = Int16.Parse(panierData.CurrentCell.Value.ToString());
            string currentIdArticle = panierData.Rows[panierData.CurrentCell.RowIndex].Cells["idArticle"].Value.ToString();

            label1.Text = columnName;
            label2.Text = cellValue.ToString();
            label3.Text = currentIdArticle;

            string query = String.Format("UPDATE Bovlo.Basket SET `{0}` = '{1}' WHERE (`idArticle` = '{2}')", columnName, cellValue, currentIdArticle);

            GlobalVar.WriteSQL(query);

            label4.Text = query;

        }

    }
}
