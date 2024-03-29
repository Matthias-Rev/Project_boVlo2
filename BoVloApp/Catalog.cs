﻿using System;
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
    public partial class Catalog : Form
    {
//--------------------------------------------initializing variables----------------------------------
        int currunt_bike_id = 0;
        int max_type_id;
        List<Bike> bikes = new();
        Main main = null;
        public Catalog(Main main)
        {
            this.main = main;
            InstantiateBikes();
            max_type_id = bikes.Count() - 1;
            InitializeComponent();
            UpdateDisplay();
        }

//---------------------------------------Navigate to the basket window------------------------------------
        private void GoToBasket(object sender, EventArgs e)
        {
            main.display(new Basket(main));
        }

//-------------------------------------Buttons that allow to cycle through the bike selection-----------
        private void buttonPre_Click(object sender, EventArgs e)
        {
            currunt_bike_id -= 1;
            if (currunt_bike_id < 0)
            {
                currunt_bike_id = max_type_id;
            }
            UpdateDisplay();
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

//--------------------------Update selection boxes as well as bike images when cycling through the bike catalog--------
        private void UpdateDisplay()
        {
            Bike bike = bikes[currunt_bike_id];
            veloType.Text = bike.type;
            labelPriceBike.Text = bike.price;
            Program.UpdateCombobox(color_combobox, bike.available_colours);
            Program.UpdateCombobox(size_combobox, bike.available_sizes);
            //update message
        }
 
//-----------------------------------------------------Add items to basket-------------------------------
        private void AddBtn(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                string type = veloType.Text;
                string color = color_combobox.Text;
                string size = size_combobox.Text;
                int quantity = int.Parse(inputBox.Text);
                string reference = type + "_" + color + "_" + size;
                if (Program.basket.ContainsKey(reference))
                {
                    Program.basket[reference] += quantity;
                }
                else { Program.basket.Add(reference, quantity); }
                inputBox.Text = ""; 
            }
            else
            {
                inputBox.BackColor = Color.Red;
            }
        }

        //--------------------------Set default color of input box------------------------------------
        private void InputBoxColorChange(object sender, EventArgs e)
        {
            inputBox.BackColor = Color.White;
        }


//----------------------------------------Instantiate bike objects with information available in db---------------------------------
        public void InstantiateBikes()
        {
            foreach (DataRow row in Program.types.Rows)
            {
                Bike bike = new();
                bike.type = row["Name"].ToString();
                bike.price = row["Price"].ToString();
                string id = row["idBike"].ToString();
                void SetAvailability(List<string> list, DataTable datatable, string link_table_name, string target_id_name, string target_column_name)
                {
                    DataTable available = Program.ReadSQL(string.Format("SELECT * FROM {1} WHERE idBike = '{0}'", id, link_table_name));
                    foreach (DataRow available_item in available.Rows)
                    {
                        list.Add(datatable.Select(string.Format("{0} = '{1}'", target_id_name, available_item[target_id_name].ToString()))[0][target_column_name].ToString());
                    }
                }
                SetAvailability(bike.available_colours, Program.colors, "Bike_color", "idColor", "Name");
                SetAvailability(bike.available_sizes, Program.sizes, "Bike_Size", "Size", "Size");
                bikes.Add(bike);
            }
        }






    }
}
