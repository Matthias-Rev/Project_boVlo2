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
        }

               private void AjoutLigne()
        {

            TableLayoutPanel tlp = new TableLayoutPanel();
            this.Controls.Add(tlp);
            tlp.Controls.Add(buttonPlanning, 0, 0);//just a test
            tlp.Controls.Add(buttonPlanning, 1, 0);//juste a test
            tlp.Controls.Add(buttonPlanning, 0, 1);//juste un test

            // If grid is full add extra cells by adding column
            tlp.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;

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

    }
}
