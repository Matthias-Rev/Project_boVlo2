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
    public partial class GestionDeCommande : Form
    {
        public GestionDeCommande()
        {
            InitializeComponent();

            //check credentials in database
            string request = String.Format(
                "SELECT * " +
                "FROM GestionDeCommande " +
                "WHERE Session_key='{0}'"
                , GlobalVar.ReadXML().key);
            DataTable data = GlobalVar.ReadSQL(request);
            foreach (DataRow row in data.Rows)
            {
                backPanel.Controls.Add(new Label() { Text = row["Nombre_total"].ToString() });
                backPanel.Controls.Add(new Label() { Text = row["Taille"].ToString() });
                backPanel.Controls.Add(new Label() { Text = row["Modèle"].ToString() });
                backPanel.Controls.Add(new Label() { Text = row["Couleur"].ToString() });
                backPanel.Controls.Add(new Label() { Text = row["Société"].ToString() });
                backPanel.Controls.Add(new Label() { Text = row["Date_attendue"].ToString() });

            }


        }

        private void GestionDeCommande_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            GlobalVar.Loadform(backPanel, new GestionDeCommande());
        }
    }
}
