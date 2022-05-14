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
            if (name_textbox.Text.Length == 0)
            {
                name_textbox.BackColor = Color.Red;
                inputs_valid = false;
            }
            if(VAT_textbox.Text.Length == 0)
            {
                VAT_textbox.BackColor = Color.Red;
                inputs_valid = false;
            }
            if(address_textbox.Text.Length == 0)
            {
                address_textbox.BackColor = Color.Red; 
                inputs_valid = false;
            }
            if(email_textbox.Text.Length == 0)
            {
                email_textbox.BackColor = Color.Red; 
                inputs_valid = false;
            }
            if (inputs_valid == true)
            {
                string insertMySQL = String.Format("INSERT INTO Customer (`Name`, `TVA`, `Address`, `Contact`) VALUES " +
                    "('{0}','{1}','{2}','{3}' )", name_textbox.Text, VAT_textbox.Text, address_textbox.Text, email_textbox.Text);
                GlobalVar.WriteSQL(insertMySQL);
                main.clear();
                Close();
            }
            
        }
        // To map elements with id : string idbike = GlobalVar.types.Select(String.Format("Name = '{0}'", veloType.Text))[0]["idBike"].ToString();
        //string idcolor = GlobalVar.colors.Select(String.Format("Name = '{0}'", color_combobox.Text))[0]["idColor"].ToString();

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {
            name_textbox.BackColor = Color.White;
        }

        private void VAT_textbox_TextChanged(object sender, EventArgs e)
        {
            VAT_textbox.BackColor = Color.White;
        }

        private void address_textbox_TextChanged(object sender, EventArgs e)
        {
            address_textbox.BackColor = Color.White;
        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {
            email_textbox.BackColor = Color.White;
        }
    }
}
