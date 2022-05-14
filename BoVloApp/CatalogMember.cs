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
    public partial class CatalogMember : Form
    {
        Main main = null;
        public CatalogMember(Main main)
        {
            this.main = main;
            InitializeComponent();
            InitialValueNotInDBLbl();
        }

//--------------------------------Initializes the "Customer not found" label to be not visible----------------
        private void InitialValueNotInDBLbl()
        {
            labelNotInDB.Visible = false;
        }

//-------------------------------Navigates to new customer window upon pressing this btn---------------------
        private void BecomeCustomer(object sender, EventArgs e)
        {
            GlobalVar.Loadform(panelMember, new Final_Catalog(main));
        }

//--------------------------Search the name of the company in the db------------------------------------------
        private void LookUpCustomer(object sender, EventArgs e)
        {
            string request = String.Format(
                "SELECT Name " +
                "FROM Customer " +
                "WHERE Name='{0}'"
                , companyNameInput.Text);
            DataTable dataSql = GlobalVar.ReadSQL(request);
            foreach (DataColumn column in dataSql.Columns)
            {

                foreach (DataRow row in dataSql.Rows)
                {
                    int i = 0;
                    bool condition = true;
                    try
                    {
                        while (condition == true)
                        {
                            string name = row[i].ToString();
                            if (name == companyNameInput.Text)
                            {
                                condition = false;
                                string request_command = "SELECT * FROM Order ";
                                DataTable calendar = GlobalVar.ReadSQL(request_command);
                            }
                        }
                                i++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        labelNotInDB.Visible = true;
                        companyNameInput.Text = "";
                    }
                }
            }
            GlobalVar.Loadform(panelMember, new Final_Catalog (main));
        }
    }
}
