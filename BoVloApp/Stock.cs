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
    public partial class Stock : Form
    {
//--------------------------------------------------------Initializing the variables that will be used afterwards------------------------------------
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
            GlobalVar.UpdateCombobox(type_combobox, Availablilty(GlobalVar.ReadSQL("SELECT * FROM Bike"), "Name"));
            type_combobox.SelectedItem = null;
            GlobalVar.UpdateCombobox(color_combobox, Availablilty(GlobalVar.ReadSQL("SELECT * FROM Color"), "Name"));
            color_combobox.SelectedItem = null;
            GlobalVar.UpdateCombobox(size_combobox, Availablilty(GlobalVar.ReadSQL("SELECT * FROM Size"), "Size"));
            size_combobox.SelectedItem = null;
            HideAll();
            dataGridView1.DataSource = null;


            stockPiece.DataSource = GetPiece();
            AvailablePiece.DataSource = GetAvailablePiece();
        }

//--------------------------------------------------------Get/Update information regarding the bike stock--------------------------------------------
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

//-----------------------------------------------------------------Button effects-------------------------------------------------------------
    //----------------------------------Get the bikes stock tables-------------------------------
        private void bike_button_Click(object sender, EventArgs e)
        {
            DisplayBikeStock();
            UnHideBikes();
            HidePiece();
        }

        //--------------------------------Hide Bike related buttons and unhide Piece related ones-----------------
        private void piece_button_Click_1(object sender, EventArgs e)
        {
            HideAll();
            HideBikes();
            UnHidePiece();
        }

        //-----------------------------Display the Piece stock data------------------------
        private void piece_button_Click(object sender, EventArgs e)
        {
            DisplayPieceStock();
        }

//------------------------------------------------------------------Update Display------------------------------------------------------------------
        //-----------------------Hides every btn---------------------------
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

        //-------------------------Hides bike datagrideview-------------------------
        private void HideBikes()
        {
            dataGridView1.Visible = false;
        }

        //-------------------------Unides bike datagrideview-------------------------

        private void UnHideBikes()
        {
            dataGridView1.Visible = true;
        }

        //------------------------Set the bike datagridview source data to null, resulting in an empty table------
        private void CleanGridview()
        {
            dataGridView1.DataSource = null;
        }

        //-----------------------------Dsiplay Bike Stock-----------------------------------
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

        //---------------------Dsiplays Piece Stock--------------------------------
        private void DisplayPieceStock()
        {
            HideAll();
            foreach (Control control in piece_supply_components)
            {
                control.Visible = true;
            }
        }

        //---------------------Hides Piece Datagridview-----------------
        private void HidePiece()
        {
            stockPiece.Visible = false;
            OrderPiece.Visible = false;
            AvailablePiece.Visible = false;
        }

        //---------------------Unhides Piece Datagridview-----------------
        private void UnHidePiece()
        {
            stockPiece.Visible = true;
            OrderPiece.Visible = true;
            AvailablePiece.Visible = false;
        }

//--------------------------------------------------------------Get piece data from the db---------------------------------------------------------
        private DataTable GetPiece()
        {
            string request = "SELECT Piece.NamePiece, Piece_Size.Size, Piece_Color.idColor, Bike_Piece.Quantity " +
                "FROM Piece, Piece_Size, Piece_Color, Bike_Piece " +
                "WHERE Piece.idPiece = Piece_Size.idPiece";
            DataTable piece = GlobalVar.ReadSQL(request);

            return piece;

        }

        private DataTable GetAvailablePiece()
        {
            string request = "SELECT Piece.NamePiece FROM Piece";
            DataTable availablePiece = GlobalVar.ReadSQL(request);

            return availablePiece;

        }

        private void OrderPiece_Click(object sender, EventArgs e)
        {
            AvailablePiece.Visible = true;
            stockPiece.Visible = false;
        }
    }
}
