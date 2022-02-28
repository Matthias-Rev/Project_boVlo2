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

            MySqlConnection connexion = Mysqlconn.connect();

            TableLayoutPanel.Controls.Add(new Label() { Text = "Type du Vélo" });
            TableLayoutPanel.Controls.Add(new Label() { Text = "Taille du Vélo" });
            TableLayoutPanel.Controls.Add(new Label() { Text = "Nombre de Vélo" });
            TableLayoutPanel.Controls.Add(new Label() { Text = "Couleur du Vélo" });
            TableLayoutPanel.Controls.Add(new Label() { Text = "Prix du Vélo" });


            connexion.Close();
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
    }
}
