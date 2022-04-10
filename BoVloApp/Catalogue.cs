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
        Main main = null;
        public Catalogue(Main main)
        {
            this.main = main;
            InstantiateBikes();
            max_type_id = bikes.Count() - 1;
            InitializeComponent();
            UpdateDisplay();
            updateImage();
        }

        private void button1_Click(object sender, EventArgs e) //panier
        {
            GlobalVar.Loadform(BackPanel, new Panier(main));
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
            GlobalVar.UpdateCombobox(color_combobox, bike.available_colours);
            GlobalVar.UpdateCombobox(size_combobox, bike.available_sizes);
            //update message
            updateImage();
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
            if (nbreAjout.Text.Length > 0)
            {
                string idbike = GlobalVar.types.Select(String.Format("Name = '{0}'", veloType.Text))[0]["idBike"].ToString();
                string idcolor = GlobalVar.colors.Select(String.Format("Name = '{0}'", color_combobox.Text))[0]["idColor"].ToString();
                string insertMySQL = String.Format("INSERT INTO Basket (`SessionKey`, `Quantity`, `idBike`, `Size`, `idColor`) VALUES " +
                    "('{0}','{1}','{2}','{3}','{4}')",
                    GlobalVar.ReadXML().key, nbreAjout.Text, idbike, Int32.Parse(size_combobox.Text), idcolor);
                nbreAjout.Text = "";
                GlobalVar.WriteSQL(insertMySQL);
            }
            else
            {
                nbreAjout.BackColor = Color.Red;
            }
        }

        public void InstantiateBikes()
        {
            foreach (DataRow row in GlobalVar.types.Rows)
            {
                Bike bike = new();
                bike.type = row["Name"].ToString();
                bike.price = row["Price"].ToString();
                string id = row["idBike"].ToString();
                void SetAvailability(List<string> list, DataTable datatable, string link_table_name, string target_id_name, string target_column_name)
                {
                    DataTable available = GlobalVar.ReadSQL(string.Format("SELECT * FROM {1} WHERE idBike = '{0}'", id, link_table_name));
                    foreach (DataRow available_item in available.Rows)
                    {
                        list.Add(datatable.Select(String.Format("{0} = '{1}'", target_id_name, available_item[target_id_name].ToString()))[0][target_column_name].ToString());
                    }
                }
                SetAvailability(bike.available_colours, GlobalVar.colors, "Bike_color", "idColor", "Name");
                SetAvailability(bike.available_sizes, GlobalVar.sizes, "Bike_Size", "Size", "Size");
                bikes.Add(bike);
            }
        }

        private void labelPrix_Click(object sender, EventArgs e)
        {

        }

        private void labelTest_Click(object sender, EventArgs e)
        {
            
        }

        private void color_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateImage();
        }

        private void updateImage()
        {
            switch (veloType.Text)
            {
                case "City":
                    switch (color_combobox.Text)
                    {
                        case "White":
                            picture.Image = Properties.Resources.Velo_ville_cream;
                            break;
                        case "Red":
                            picture.Image = Properties.Resources.Velo_ville_rose;
                            break;

                        case "Blue":
                            picture.Image = Properties.Resources.Velo_ville_bleu;
                            break;
                        case "Black":
                            picture.Image = Properties.Resources.Velo_ville_turquoise;
                            break;
                    }
                    break;
                case "Explorer":
                    switch (color_combobox.Text)
                    {
                        case "White":
                            picture.Image = Properties.Resources.explorer_beige;
                            break;
                        case "Red":
                            picture.Image = Properties.Resources.explorer_beige;
                            break;
                        case "Blue":
                            picture.Image = Properties.Resources.explorer_bleu;
                            break;
                        case "Black":
                            picture.Image = Properties.Resources.explorer_noire;
                            break;
                    }
                    break;
                case "Adventure":
                    switch (color_combobox.Text)
                    {
                        case "White":
                            picture.Image = Properties.Resources.Adventure_white;
                            break;
                        case "Red":
                            picture.Image = Properties.Resources.explorer_beige;
                            break;
                        case "Blue":
                            picture.Image = Properties.Resources.Adventure_blue;
                            break;
                        case "Black":
                            picture.Image = Properties.Resources.Adventure_black;
                            break;
                    }
                    break;
            }
        }

        private void nbreAjout_TextChanged(object sender, EventArgs e)
        {
            nbreAjout.BackColor = Color.White;
        }
    }
}
