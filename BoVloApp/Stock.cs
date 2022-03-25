﻿using System;
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
    public partial class Stock : Form
    {
        List<Control> bike_supply_components = new();
        List<Control> piece_supply_components = new();
        public Stock()
        {
            InitializeComponent();
            bike_supply_components.Add(type_label);
            bike_supply_components.Add(color_label);
            bike_supply_components.Add(size_label);
            bike_supply_components.Add(type_combobox);
            bike_supply_components.Add(color_combobox);
            bike_supply_components.Add(size_combobox);
            piece_supply_components.Add(search_button);
            piece_supply_components.Add(search_textbox);
            List<string> Availablilty(DataTable table, string target_column_name)
            {
                List<string> result = new();
                result.Add("");
                foreach (DataRow available_item in table.Rows)
                {
                    result.Add(available_item[target_column_name].ToString());
                }
                return result;
            }
            GlobalVar.UpdateCombobox(type_combobox, Availablilty(GlobalVar.types,"Name"));
            type_combobox.SelectedItem = null;
            GlobalVar.UpdateCombobox(color_combobox, Availablilty(GlobalVar.colors, "Name"));
            color_combobox.SelectedItem = null;
            GlobalVar.UpdateCombobox(size_combobox, Availablilty(GlobalVar.sizes, "Size"));
            size_combobox.SelectedItem = null;
            HideAll();
            dataGridView1.DataSource = null;
        }
        private void HideAll()
        {
            foreach (Control control in bike_supply_components)
            {
                control.Visible = false;
            }
            foreach (Control control in piece_supply_components)
            {
                control.Visible = false;
            }
        }
        private void CleanGridview()
        {
            dataGridView1.DataSource = null;
        }

        private void UpdateBikeSupplyData()
        {
            CleanGridview();
            string request = "SELECT * FROM BikeStock";
            List<string> condition = new();
            if (type_combobox.SelectedItem != null && type_combobox.SelectedItem.ToString() != "")
            {
                condition.Add(String.Format("idBike = '{0}'", GlobalVar.types.Select(String.Format("Name = '{0}'", type_combobox.Text))[0]["idBike"].ToString()));
            }
            if (color_combobox.SelectedItem != null && color_combobox.SelectedItem.ToString() != "")
            {
               condition.Add(String.Format("idColor = '{0}'", GlobalVar.colors.Select(String.Format("Name = '{0}'", color_combobox.Text))[0]["idColor"].ToString()));
            }
            if (size_combobox.SelectedItem != null && size_combobox.SelectedItem.ToString() != "")
            {
                condition.Add(String.Format("Size = '{0}'", size_combobox.Text));
            }
            if (condition.Count > 0)
            {
                request += " WHERE ";
                request += String.Join(" AND ", condition.ToArray());
            }
            DataTable supply = GlobalVar.ReadSQL(request);
            DataTable data = new();
            string[] titels = { "Type", "Color", "Size", "Quantity" };

            foreach (string titel in titels)
            {
                data.Columns.Add(titel);
            }
            foreach (DataRow row in supply.Rows)
            {
                DataRow datarow = data.NewRow();
                datarow["Type"] = GlobalVar.types.Select(String.Format("idBike = '{0}'", row["idBike"].ToString()))[0]["Name"].ToString();
                datarow["Color"] = GlobalVar.colors.Select(String.Format("idColor = '{0}'", row["idColor"].ToString()))[0]["Name"].ToString();
                datarow["Size"] = row["Size"].ToString();
                datarow["Quantity"] = row["Quantity"].ToString();
                data.Rows.Add(datarow);
            }
            dataGridView1.DataSource = data;
        }

        private void UpdatePieceData()
        {
            CleanGridview();
            string request = "SELECT * FROM Piece";
            List<string> condition = new();
            for(int n in String.Format("Name")) 
            {
                if (search_textbox.Text.Contains())
                {

                }
                }

        }

        private void DisplayBikeStock()
        {
            HideAll();
            type_combobox.SelectedItem = null;
            color_combobox.SelectedItem = null;
            size_combobox.SelectedItem = null;
            foreach (Control control in bike_supply_components)
            {
                control.Visible = true;
            }
            UpdateBikeSupplyData();
        }
        private void DisplayPieceStock()
        {
            HideAll();
            foreach (Control control in piece_supply_components)
            {
                control.Visible = true;
            }
        }

        private void piece_button_Click(object sender, EventArgs e)
        {
            DisplayPieceStock();
        }

        private void type_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBikeSupplyData();
        }

        private void color_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBikeSupplyData();
        }

        private void size_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBikeSupplyData();
        }

        private void bike_button_Click(object sender, EventArgs e)
        {
            DisplayBikeStock();
        }
    }
}
