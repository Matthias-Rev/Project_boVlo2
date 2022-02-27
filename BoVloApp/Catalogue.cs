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

            if (this.veloType.Text == "City") 
            {

                MySqlConnection connexion = Mysqlconn.connect();

                string updateQuery = "UPDATE bovlo.bike SET Product_type = '"+veloType.Text+"', Quantity = '" +nbreAjout.Text+ "', Price ='"+labelPrixVelo.Text+"', Size ='"+ size.SelectedText + "', Colour ='"+ colourCIty.SelectedText;


            }

            if (this.veloType.Text == "Explorer")
            {


            }

            if (this.veloType.Text == "Adventure") 
            {

            }

        }

        
        public void hideCityColors()
        {
            this.button7.Visible = false;
            this.turquoise.Visible = false;
            this.button3.Visible = false;
            this.button2.Visible = false;
        }

        public void unhideCityColors()
        {
            this.button7.Visible = true;
            this.turquoise.Visible = true;
            this.button3.Visible = true;
            this.button2.Visible = true;
        }

        public void hideAdventureColors() 
        {
            this.button1.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
        }

        public void unhideAdventureColors()
        {
            this.button1.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
        }

        public void hideExplorerColors()
        {
            this.button6.Visible = false;
            this.button8.Visible = false;
            this.button9.Visible = false;
        }

        public void unhideExplorerColors()
        {
            this.button6.Visible = true;
            this.button8.Visible = true;
            this.button9.Visible = true;
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
            string size = "28";
        }

        private void size_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void colourCIty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colourCIty.SelectedText.ToString() == "White") 
            {
                this.picture.Image = Properties.Resources.Velo_ville_cream;
            }
            if (colourCIty.SelectedText.ToString() == "Blue")
            {
                this.picture.Image = Properties.Resources.Velo_ville_bleu;
            }
            if (colourCIty.SelectedText.ToString() == "Rose")
            {
                this.picture.Image = Properties.Resources.Velo_ville_rose;
            }
            if (colourCIty.SelectedText.ToString() == "Green")
            {
                this.picture.Image = Properties.Resources.Velo_ville_turquoise;
            }

        }

        private void labelColor_Click(object sender, EventArgs e)
        {

        }
    }
    
    

}
