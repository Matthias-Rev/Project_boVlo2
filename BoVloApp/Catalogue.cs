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
    public partial class Catalogue : Form
    {
        int currunt_bike_id = 0;
        int max_type_id;
        Bike[] bikes;
        public Catalogue()
        {
            InstantiateBikes();
            max_type_id = bikes.Length-1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //panier
        {
            GlobalVar.Loadform(BackPanel, new Panier());
        }


        private void buttonPre_Click(object sender, EventArgs e)
        {
            currunt_bike_id -= 1;
            if (currunt_bike_id < 0)
            {
                currunt_bike_id = max_type_id;
            }
            UpdateDisplay();

        }
        private void UpdateDisplay()
        {
            Bike bike = bikes[currunt_bike_id];
            veloType.Text = bike.type;
            labelPrixVelo.Text = bike.price;
            picture.Image = Properties.Resources.explorer_beige;
            
        }

            private void buttonNext_Click(object sender, EventArgs e)
        {
            currunt_bike_id += 1;
            if (currunt_bike_id > max_type_id)
            {
                currunt_bike_id = 0;
            }
            UpdateDisplay();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            string insertMySQL = String.Format("INSERT INTO Panier (`Session_key`, `Quantity`, `Product_type`, `Price`, `Size`, `Colour`) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}' )", GlobalVar.ReadXML().key, nbreAjout.Text, veloType.Text, labelPrixVelo.Text, size.Text, colourCIty.Text);
                
            GlobalVar.WriteSQL(insertMySQL);

        }

        private void colourCIty_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (colourCIty.Text)
            {
                case "White":

                    this.picture.Image = Properties.Resources.Velo_ville_cream;
                    break;

                case "Blue":

                    this.picture.Image = Properties.Resources.Velo_ville_bleu;
                    break;
                case "Rose":

                    this.picture.Image = Properties.Resources.Velo_ville_rose;
                    break;
                case "Green":

                    this.picture.Image = Properties.Resources.Velo_ville_turquoise;
                    break;

            }

        }

        private void labelColor_Click(object sender, EventArgs e)
        {
            labelColor.Text = colourCIty.SelectedText.ToString();
        }

        private void explorer_colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (explorer_colour.Text)
            {
                case "White":
                    this.picture.Image = Properties.Resources.explorer_beige;
                    break;

                case "Black":
                    this.picture.Image = Properties.Resources.explorer_noire;
                    break;

                case "Blue":
                    this.picture.Image = Properties.Resources.explorer_bleu;
                    break;
            }
        }

        private void AdevntureColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AdevntureColour.Text)
            {
                case "White":
                    this.picture.Image = Properties.Resources.Adventure_white;
                    break;

                case "Black":
                    this.picture.Image = Properties.Resources.Adventure_black;
                    break;

                case "Blue":
                    this.picture.Image = Properties.Resources.Adventure_blue;
                    break;
            }
        }
        public void InstantiateBikes()
        {
            string requestBike = "SELECT * FROM Bike";
            DataTable veloDispo = GlobalVar.ReadSQL(requestBike);
            foreach (DataRow row in veloDispo.Rows)
            {
                Bike bike = new();
               
            }
        }
    }
    
    

}
