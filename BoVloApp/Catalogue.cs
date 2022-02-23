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
            }

            else if (this.veloType.Text == "Adventure") 
            {
                this.veloType.Text = "Explorer";
            }

            else if (this.veloType.Text == "Explorer")
            {
                this.veloType.Text = "City";
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.veloType.Text == "City")
            {
                this.veloType.Text = "Explorer";
            }

            else if (this.veloType.Text == "Explorer")
            {
                this.veloType.Text = "Adventure";
            }

            else if (this.veloType.Text == "Adventure")
            {
                this.veloType.Text = "City";
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

        private void button11_Click(object sender, EventArgs e) //btn pour back
        {
            Form menu = new Menu();
            menu.ShowDialog(); 
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



    }
}
