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
            colourSizeBtn.CityColour = "rose";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.Velo_ville_turquoise;
            colourSizeBtn.CityColour = "turquoise";
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
            colourSizeBtn.CityColour = "white";

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
            colourSizeBtn.CityColour = "blue";

        }

        private void nbreAjout_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (this.veloType.Text == "City") 
            {
                //article = new article
                //article.type = ....

                Article ArticleCity = new();

                ArticleCity.type = "City";
                ArticleCity.quantity = nbreAjout.Text;
                ArticleCity.colour = colourSizeBtn.CityColour;
                ArticleCity.size = colourSizeBtn.CitySize;
                ArticleCity.price = labelPrixVelo.Text;

                GlobalVar.WriteXML("panier", ArticleCity);

                Console.WriteLine("yo");

            }

            if (this.veloType.Text == "Explorer")
            {
                Article ArticleExplorer = new();

                ArticleExplorer.type = "Explorer";
                ArticleExplorer.quantity = nbreAjout.Text;
                ArticleExplorer.colour = colourSizeBtn.ExplorerColour;
                ArticleExplorer.size = colourSizeBtn.ExplorerSize;
                ArticleExplorer.price = labelPrixVelo.Text;

                GlobalVar.WriteXML("panier", ArticleExplorer);

            }

            if (this.veloType.Text == "Adventure") 
            {
                Article ArticleAdventure = new();

                ArticleAdventure.type = "Adventure";
                ArticleAdventure.quantity = nbreAjout.Text;
                ArticleAdventure.colour = colourSizeBtn.AdventureColour;
                ArticleAdventure.size = colourSizeBtn.AdventureSize;
                ArticleAdventure.price = labelPrixVelo.Text;

                GlobalVar.WriteXML("panier", ArticleAdventure);
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
            colourSizeBtn.AdventureColour = "white";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.Adventure_black;
            colourSizeBtn.AdventureColour = "black";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.Adventure_blue;
            colourSizeBtn.AdventureColour = "blue";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.explorer_beige;
            colourSizeBtn.ExplorerColour = "white";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.explorer_noire;
            colourSizeBtn.ExplorerColour = "black";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.picture.Image = Properties.Resources.explorer_bleu;
            colourSizeBtn.ExplorerColour = "blue";
        }

        private void labelPrixVelo_Click(object sender, EventArgs e)
        {

        }

        public static class colourSizeBtn
        {
            public static string CitySize = "";
            public static string CityColour = "";
            
            public static string ExplorerSize = "";
            public static string ExplorerColour = "";
            
            public static string AdventureSize = "";
            public static string AdventureColour = "";

        }

        private void size27_Click(object sender, EventArgs e)
        {
            if(this.veloType.Text == "City") 
            {
                colourSizeBtn.CitySize = "27";
            }
            if (this.veloType.Text == "Explorer")
            {
                colourSizeBtn.ExplorerSize = "27";
            }
            if (this.veloType.Text == "Adventure")
            {
                colourSizeBtn.AdventureSize = "27";
            }
        }

        private void size28_Click(object sender, EventArgs e)
        {
            if (this.veloType.Text == "City")
            {
                colourSizeBtn.CitySize = "28";
            }
            if (this.veloType.Text == "Explorer")
            {
                colourSizeBtn.ExplorerSize = "28";
            }
            if (this.veloType.Text == "Adventure")
            {
                colourSizeBtn.AdventureSize = "28";
            }
        }
    }
    
    

}
