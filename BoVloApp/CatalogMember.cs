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
        }
//-------------------------------Navigates to new customer window upon pressing this btn---------------------
        private void BecomeCustomer(object sender, EventArgs e)
        {
            GlobalVar.Loadform(panelMember, new Final_Catalog(main));
        }

        //--------------------------Search the name of the company in the db------------------------------------------
        private void LookUpCustomer(object sender, EventArgs e)
        {
            string request = string.Format(
                   "SELECT * " +
                   "FROM Customer " +
                   "WHERE VAT='{0}'"
                   , companyVATInput.Text);
            DataTable dataSql = GlobalVar.ReadSQL(request);
            if (dataSql.Rows.Count == 0)
            {
                labelNotInDB.Visible = true;
            }
            else
            {
                List<string> list = new List<string>();
                list.Add(dataSql.Rows[0]["Name"].ToString());
                list.Add(dataSql.Rows[0]["VAT"].ToString());
                list.Add(dataSql.Rows[0]["Address"].ToString());
                list.Add(dataSql.Rows[0]["Contact"].ToString());
                GlobalVar.Loadform(panelMember, new Final_Catalog(main, list));
            }
        }

    }
}
