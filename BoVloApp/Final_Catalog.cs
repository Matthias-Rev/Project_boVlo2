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
            string insertMySQL = String.Format("INSERT INTO Customer (`Name`, `TVA`, `Address`, `Contact`) VALUES " +
            "('{0}','{1}','{2}','{3}' )", companyNameInput.Text, tvaInput.Text, addressInput.Text, contactInput.Text);
            MessageBox.Show(insertMySQL);
            GlobalVar.WriteSQL(insertMySQL);
            main.clear();
            Close();
        }
    }
}
