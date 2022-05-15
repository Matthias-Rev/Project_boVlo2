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
    public partial class Basket : Form
    {
        Main main = null;
        DataTable basket;
        public Basket(Main main)
        {
            this.main = main;
            InitializeComponent();
            basket = GetBasket();
            basket.Columns.Add("Type");
            basket.Columns.Add("Color");
            basket.Columns.Add("Size");
            basket.Columns.Add("Quantity");
            foreach (string article in Program.basket.Keys)
            {
                string[] variables = article.Split('_');
                DataRow row = basket.NewRow();
                row["Type"] = variables[0];
                row["Color"] = variables[1];
                row["Size"] = variables[2];
                row["Quantity"] = Program.basket[article];
                basket.Rows.Add(row);
            }
            DisplayBasket();
        }
        private void DisplayBasket()
        {
            
            panierData.DataSource = basket;
            panierData.Columns["Type"].ReadOnly = true;
            panierData.Columns["Color"].ReadOnly = true;
            panierData.Columns["Size"].ReadOnly = true;
            CalculatePrice(basket);
        }

        private void CalculatePrice(DataTable basket)
        {
            int prixtotal = 0;
            foreach (DataRow row in basket.Rows)
            {
                int quantity = int.Parse(row["Quantity"].ToString());
                int price = int.Parse(Program.types.Select(string.Format("Name = '{0}'", row["Type"]))[0]["Price"].ToString());
                prixtotal += price * quantity;
            }
            LabelPrixTotal.Text = prixtotal.ToString();
        }

        private void buttonFinaliser_Click(object sender, EventArgs e)
        {
            Program.Loadform(PanelPanier, new CatalogMember(main));
        }

        private DataTable GetBasket()
        {
            DataTable basket = new();
            return basket;
        }
        //
        //---------------------------------------------------------bouton pour update la db--------------------------------------------
        //
        private void panierData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = basket.Rows[panierData.CurrentCell.RowIndex];
            string reference = row["Type"] + "_" + row["Color"] + "_" + row["Size"];
            Program.basket[reference] = int.Parse(panierData.CurrentCell.Value.ToString());
            CalculatePrice(basket);
        }

    }
}
