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
    public partial class Panier : Form
    {
        public Panier()
        {
            InitializeComponent();

            //check credentials in database
            string request = String.Format(
                "SELECT * " +
                "FROM Panier " +
                "WHERE Session_key='{0}'"
                , GlobalVar.ReadXML().key);
            DataTable data = GlobalVar.ReadSQL(request);
            foreach (DataRow row in data.Rows)
            {
                TableLayoutPanel.Controls.Add(new Label() { Text = row["Quantity"].ToString() });
                TableLayoutPanel.Controls.Add(new Label() { Text = row["Product_type"].ToString() });
                TableLayoutPanel.Controls.Add(new Label() { Text = row["Price"].ToString() });
                TableLayoutPanel.Controls.Add(new Label() { Text = row["Size"].ToString() });
                TableLayoutPanel.Controls.Add(new Label() { Text = row["Colour"].ToString() });
            }
            

        }


        private void buttonFinaliser_Click(object sender, EventArgs e)
        {
            GlobalVar.Loadform(PanelPanier, new CatalogueMember());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelPanier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panier_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LabelPrixTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
