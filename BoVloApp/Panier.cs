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

        public void Clearform()
        {
            foreach (Control c in PanelPanier.Controls)
            {
                if (c is Form)
                {
                    PanelPanier.Controls.Remove(c);
                    (c as Form).Close();
                }
            }

            buttonFinaliser.Visible = true;
            buttonPlanning.Visible = true;
            richTextBox1.Visible = true;
            LabelTotal.Visible = true;
            Title.Visible = true;
            TableLayoutPanel.Visible=true;



        }
        public void Loadform(object Form)
        {
            Clearform();
            buttonFinaliser.Visible = false;
            buttonPlanning.Visible = false;
            richTextBox1.Visible = false;
            LabelTotal.Visible = false;
            Title.Visible = false;
            TableLayoutPanel.Visible=false;

            Form form_to_load = Form as Form;
            form_to_load.TopLevel = false;
            form_to_load.Dock = DockStyle.Fill;
            PanelPanier.Controls.Add(form_to_load);
            PanelPanier.Tag = form_to_load;
            form_to_load.Show();


        }

        private void AjoutLigne()
        {

            TableLayoutPanel tlp = new TableLayoutPanel();
            this.Controls.Add(tlp);
            tlp.Controls.Add(buttonFinaliser, 0, 0);//just a test

            // If grid is full add extra cells by adding column

            tlp.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;

            //check credentials in database
            MySqlConnection connexion = Mysqlconn.connect();

            //on peut ici intéragir avec l'objet 'connexion' qui est enfait le lien avec la DB.
            // il faut conclure par :
            connexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loadform(new CatalogueMember());
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
    }
}
