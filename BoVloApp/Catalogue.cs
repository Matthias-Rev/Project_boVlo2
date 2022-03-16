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
        List<Bike> bikes = new();
        public Catalogue()
        {
            InstantiateBikes();
            max_type_id = bikes.Count() - 1;
            InitializeComponent();
            UpdateDisplay();
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
            color_combobox.Items.Clear();
            foreach (string colour in bike.available_colours)
            {
                color_combobox.Items.Add(colour);
            }
            color_combobox.Text = bike.available_colours[0];
            size_combobox.Items.Clear();
            foreach (string size in bike.available_sizes)
            {
                size_combobox.Items.Add(size);
            }
            size_combobox.Text = bike.available_sizes[0];
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
                "('{0}','{1}','{2}','{3}','{4}','{5}' )",
                GlobalVar.ReadXML().key, nbreAjout.Text, veloType.Text, labelPrixVelo.Text, size_combobox.Text, color_combobox.Text);       
            GlobalVar.WriteSQL(insertMySQL);

        }

        public void InstantiateBikes()
        {
            string requestBike = "SELECT * FROM Bike";
            DataTable veloDispo = GlobalVar.ReadSQL(requestBike);
            foreach (DataRow row in veloDispo.Rows)
            {
                Bike bike = new();
                bike.type = row["Name"].ToString();
                bike.price = row["Price"].ToString();
                string id = row["idBike"].ToString();
                DataTable colors = GlobalVar.ReadSQL("SELECT * FROM Color");
                DataTable availablecolors = GlobalVar.ReadSQL(string.Format("SELECT * FROM Bike_color WHERE idBike = '{0}'", id));
                List<string> availablecolorsid = new();
                foreach (DataRow colorrow in availablecolors.Rows)
                {
                    availablecolorsid.Add(colorrow["idColor"].ToString());
                }
                foreach (DataRow colorrow in colors.Rows)
                {
                    foreach (string element in availablecolorsid)
                    {
                        if (element == colorrow["idColor"].ToString())
                        {
                            bike.available_colours.Add(colorrow["Name"].ToString());
                        }
                    }
                }
                DataTable sizes = GlobalVar.ReadSQL("SELECT * FROM Size");
                DataTable availablesizes = GlobalVar.ReadSQL(string.Format("SELECT * FROM Bike_Size WHERE idBike = '{0}'", id));
                List<string> availablesizesid = new();
                foreach (DataRow sizerow in availablesizes.Rows)
                {
                    availablesizesid.Add(sizerow["idSize"].ToString());
                }
                foreach (DataRow sizerow in sizes.Rows)
                {
                    foreach (string element in availablecolorsid)
                    {
                        if (element == sizerow["idSize"].ToString())
                        {
                            bike.available_sizes.Add(sizerow["Size"].ToString());
                        }
                    }
                }
                bikes.Add(bike);
            }
        }

        private void labelPrix_Click(object sender, EventArgs e)
        {

        }
    }
}
