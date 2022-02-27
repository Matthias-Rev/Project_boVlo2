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
        public Catalogue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //panier
        {
            GlobalVar.Loadform(BackPanel, new Panier());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.Velo_ville_rose;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.Velo_ville_turquoise;

        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            if (this.veloType.Text == "City")
            {
                this.veloType.Text = "Adventure";
                this.labelPrixVelo.Text = "700E";
                
                hideCityColors();
                unhideAdventureColors();

                this.picture.Image = Properties.Resources.Adventure_white;

            }

            else if (this.veloType.Text == "Adventure") 
            {
                this.veloType.Text = "Explorer";
                this.labelPrixVelo.Text = "600E";
                
                hideAdventureColors();
                unhideExplorerColors();

                this.picture.Image = Properties.Resources.explorer_beige;
            }

            else if (this.veloType.Text == "Explorer")
            {
                this.veloType.Text = "City";
                this.labelPrixVelo.Text = "500E";
                
                unhideCityColors();
                hideExplorerColors();

                this.picture.Image = Properties.Resources.Velo_ville_cream;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.veloType.Text == "City")
            {
                this.veloType.Text = "Explorer";
                this.labelPrixVelo.Text = "600E";
                
                hideCityColors();
                unhideExplorerColors();

                this.picture.Image = Properties.Resources.explorer_beige;


            }

            else if (this.veloType.Text == "Explorer")
            {
                this.veloType.Text = "Adventure";
                this.labelPrixVelo.Text = "700E";

                unhideAdventureColors();
                hideExplorerColors();

                this.picture.Image = Properties.Resources.Adventure_white;
                
            }

            else if (this.veloType.Text == "Adventure")
            {
                this.veloType.Text = "City";
                this.labelPrixVelo.Text = "500E";

                hideAdventureColors();
                unhideCityColors();

                this.picture.Image = Properties.Resources.Velo_ville_cream;
            }
        }
    

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.Velo_ville_cream;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void turquoise_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.Velo_ville_bleu;

        }

        private void nbreAjout_TextChanged(object sender, EventArgs e)
        {
 
        }

        public bool buttonWasClicked = false;
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            

            string insertMySQL = String.Format("INSERT INTO Panier (`Quantity`, `Product_type`, `Price`, `Size`, `Colour`) VALUES (nbreAjout.Text, veloType.Text, labelPrixVelo.Text, size.Text, colourCIty.Text )";

            //"Product_id = '" + "1";
            GlobalVar.WriteSQL(insertMySQL);
        }

        
        public void hideCityColors()
        {
            this.colourCIty.Visible = false;
        }

        public void unhideCityColors()
        {
            this.colourCIty.Visible = true;
        }

        public void hideAdventureColors() 
        {
            this.AdevntureColour.Visible = false;
        }

        public void unhideAdventureColors()
        {
            this.AdevntureColour.Visible = true;

        }

        public void hideExplorerColors()
        {
            this.explorer_colour.Visible = false;

        }

        public void unhideExplorerColors()
        {
            this.explorer_colour.Visible = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.Adventure_white;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.Adventure_black;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.Adventure_blue;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.explorer_beige;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.explorer_noire;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.explorer_bleu;

        }


        private void size27_Click(object sender, EventArgs e)
        {

        }

        private void size28_Click(object sender, EventArgs e)
        {

        }

        private void size_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            switch (explorer_colour.Text)
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
    }
    
    

}
