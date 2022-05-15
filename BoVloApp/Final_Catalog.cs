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
    public partial class Final_Catalog : Form
    {
        Main main = null;
        public Final_Catalog(Main main, List<string> variables = null)
        {
            this.main = main;
            InitializeComponent();
            if(variables != null)
            {
                companyNameInput.Text=variables[0];
                companyNameInput.ReadOnly=true;
                VATInput.Text = variables[1];
                VATInput.ReadOnly = true;
                addressInput.Text = variables[2];
                addressInput.ReadOnly = true;
                emailInput.Text = variables[3];
                emailInput.ReadOnly = true;
            }
        }

//---------------------------Add new customer to db----------------------------------------------
        public void SubmitBtn(object sender, EventArgs e)
        {
            // confirm and send the information on the db
            // addd to the database
            bool inputs_valid = true;
            if (companyNameInput.Text.Length == 0)
            {
                companyNameInput.BackColor = Color.Red;
                inputs_valid = false;
            }
            if(VATInput.Text.Length == 0)
            {
                VATInput.BackColor = Color.Red;
                inputs_valid = false;
            }
            if(addressInput.Text.Length == 0)
            {
                addressInput.BackColor = Color.Red; 
                inputs_valid = false;
            }
            if(emailInput.Text.Length == 0)
            {
                emailInput.BackColor = Color.Red; 
                inputs_valid = false;
            }
            if (inputs_valid == true)
            {
                if(emailInput.ReadOnly == false)
                {
                    string insertMySQL = string.Format("INSERT INTO" +
                    " Customer (`Name`, `VAT`, `Address`, `Contact`)" +
                    " VALUES ('{0}','{1}','{2}','{3}' )", companyNameInput.Text, VATInput.Text, addressInput.Text, emailInput.Text);
                    Program.WriteSQL(insertMySQL);
                }
                CreateOrder();
                main.clear();
                Close();
            }   
        }        
        private void companyNameInput_TextChanged(object sender, EventArgs e)
        {
            companyNameInput.BackColor = Color.White;
        }

        private void VATInput_TextChanged(object sender, EventArgs e)
        {
            VATInput.BackColor = Color.White;
        }

        private void addressInput_TextChanged(object sender, EventArgs e)
        {
            addressInput.BackColor = Color.White;
        }

        private void emailInput_TextChanged(object sender, EventArgs e)
        {
            emailInput.BackColor = Color.White;
        }
        private void CreateOrder()
        {
            // To map elements with id : string idbike = Program.types.Select(string.Format("Name = '{0}'", veloType.Text))[0]["idBike"].ToString();
            //string idcolor = Program.colors.Select(string.Format("Name = '{0}'", color_combobox.Text))[0]["idColor"].ToString();
            string request = string.Format(
                   "SELECT Customer_id " +
                   "FROM Customer " +
                   "WHERE VAT='{0}'"
                   , VATInput.Text);
            DataTable dataSql = Program.ReadSQL(request);
            string customer_id = dataSql.Rows[0]["Customer_id"].ToString();
            string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string insertMySQL = string.Format("INSERT INTO"+
                " Orders (`Customer_id`, `Start_Date`, `End_Date`)"+
                " VALUES ('{0}',CAST('{1}' AS DATE), CAST('{2}' AS DATE));SELECT LAST_INSERT_ID();",
                customer_id, date, Program.estimate_delivery_date.ToString("yyyy-MM-dd"));
            DataTable newEntry = Program.ReadSQL(insertMySQL);
            int orderID = int.Parse(newEntry.Rows[0]["LAST_INSERT_ID()"].ToString());
            foreach (string article in Program.basket.Keys)
            {
                string[] variables = article.Split('_');
                string type = variables[0];
                string color = variables[1];
                int size = int.Parse(variables[2]);
                int quantity = Program.basket[article];
                int idBike = int.Parse(Program.types.Select(string.Format("Name = '{0}'", type))[0]["idBike"].ToString());
                int idColor = int.Parse(Program.colors.Select(string.Format("Name = '{0}'", color))[0]["idColor"].ToString());
                string orderdetailrequest = string.Format("INSERT INTO" +
                  " OrderDetails (`idOrder`, `idBike`, `idColor`, `Quantity`,`Size`)" +
                  " VALUES ('{0}','{1}','{2}','{3}','{4}' )", orderID, idBike, idColor, quantity, size);
                Program.WriteSQL(orderdetailrequest);

            }
        }
    }
}
