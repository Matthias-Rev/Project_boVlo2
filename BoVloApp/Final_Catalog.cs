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
        public Final_Catalog(Main main)
        {
            this.main = main;
            InitializeComponent();
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
                string insertMySQL = String.Format("INSERT INTO Customer (`Name`, `TVA`, `Address`, `Contact`) VALUES " +
                    "('{0}','{1}','{2}','{3}' )", companyNameInput.Text, VATInput.Text, addressInput.Text, emailInput.Text);
                GlobalVar.WriteSQL(insertMySQL);
                main.clear();
                Close();
            }
            
        }
        // To map elements with id : string idbike = GlobalVar.types.Select(String.Format("Name = '{0}'", veloType.Text))[0]["idBike"].ToString();
        //string idcolor = GlobalVar.colors.Select(String.Format("Name = '{0}'", color_combobox.Text))[0]["idColor"].ToString();

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
    }
}
