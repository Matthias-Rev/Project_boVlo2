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

            TableLayoutPanel panier = new TableLayoutPanel();

            //Create the dynamic label
            Label type = new Label();
            type.Text = "type de vélo";
            panier.Controls.Add(type);

            Label taille = new Label();
            taille.Text = "taille du vélo";
            panier.Controls.Add(taille);

            Label quantite = new Label();
            quantite.Text = "nombre de vélo";
            panier.Controls.Add(quantite);

            Label couleur = new Label();
            couleur.Text = "couleur du vélo";
            panier.Controls.Add(couleur);

            Label prix = new Label();
            prix.Text = "prix du vélo";
            panier.Controls.Add(prix);

            TableLayoutPanel.Controls.Add(panier);
        }

        private void AjoutLigne()
        {


            //check credentials in database
            MySqlConnection connexion = Mysqlconn.connect();

            //on peut ici intéragir avec l'objet 'connexion' qui est enfait le lien avec la DB.
            // il faut conclure par :
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
