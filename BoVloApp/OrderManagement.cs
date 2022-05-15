using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoVloApp
{
    public partial class OrderManagement : Form
    {
        DataTable order = GetOrder();
        public OrderManagement()
        {
            InitializeComponent();
            DisplayOrder();
        }

        //-----------------------------------Get the data source for the datagridview "Orders"---------------
        private void DisplayOrder()
        {
            orderTable.DataSource = order;
            CreateBtn();
        }
        
        //----------------------------------Create a Buttonn on each row-------------------------------
        private void CreateBtn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            orderTable.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Get Details";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        //------------------------Upon clicking on the "Get Details" btn, will show the order detail of the given order-----
        private void GetDetail(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView theOrder = sender as DataGridView;
            if (theOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                theOrder.CurrentRow.Selected = true;
                var val = theOrder.Rows[e.RowIndex].Cells["idOrder"].FormattedValue.ToString();
                DisplayOrderDetails(val);
            }
        }
        private void DisplayOrderDetails(string idOrder)
        {
            string request = "SELECT *  FROM OrderDetails WHERE idOrder=" + idOrder;
            DataTable raw_orderDetail = Program.ReadSQL(request);
            DataTable orderDetail = new();
            orderDetail.Columns.Add("Type");
            orderDetail.Columns.Add("Color");
            orderDetail.Columns.Add("Size");
            orderDetail.Columns.Add("Quantity");
            foreach (DataRow row in raw_orderDetail.Rows)
            {
                DataRow new_row = orderDetail.NewRow();
                new_row["Type"] = Program.types.Select(string.Format("idBike = '{0}'", row["idBike"].ToString()))[0]["Name"].ToString();
                new_row["Color"] = Program.colors.Select(string.Format("idColor = '{0}'", row["idColor".ToString()]))[0]["Name"].ToString();
                new_row["Size"] = row["Size"];
                new_row["Quantity"] = row["Quantity"];
                orderDetail.Rows.Add(new_row);
            }
            detailsTable.DataSource = orderDetail;
        }

        //-----------------------SQL query to get the the table "Orders" from the db
        private static DataTable GetOrder()
        {
            string request = "SELECT Orders.idOrder, Customer.Name, Orders.Start_Date, Orders.End_Date, Orders.status " +
                "FROM Orders, Customer " +
                "WHERE Orders.Customer_id = Customer.Customer_id ";

            DataTable order = Program.ReadSQL(request);

            //string idbike = Program.types.Select(string.Format("Name = '{0}'", veloType.Text))[0]["idBike"].ToString

            return order;

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataRow[] row = order.Select("idOrder = '" + textBox_search.Text + "'");
            if(row.Length == 0)
            {
                MessageBox.Show("The ID of this order doesn't exist");
            }
            else
            {
                DisplayOrderDetails(textBox_search.Text);
            }
        }
    }
}
