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
                "SELECT Name, VAT, Address, Contact " +
                "FROM Customer " +
                "WHERE VAT='{0}'"
                , companyVATInput.Text);
            DataTable dataSql = GlobalVar.ReadSQL(request);
            if(dataSql.Rows.Count == 0)
            {
                labelNotInDB.Visible = true;
            }
            else
            {
                DataRow data = dataSql.Rows[0];
                Dictionary<string, string> predefined = new();
                predefined.Add("Name", data["Name"].ToString());
                predefined.Add("VAT", data["VAT"].ToString());
                predefined.Add("Address", data["Address"].ToString());
                predefined.Add("Contact", data["Contact"].ToString());
                GlobalVar.Loadform(panelMember, new Final_Catalog(main, predefined));
            }

        }
    }
}
