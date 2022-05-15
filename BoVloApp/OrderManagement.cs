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
        public OrderManagement()
        {
            InitializeComponent();
            DisplayOrder();
        }

        //-----------------------------------Get the data source for the datagridview "Orders"---------------
        private void DisplayOrder()
        {
            DataTable order = GetOrder();
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
        private void DisplayOrderDetails(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView theOrder = sender as DataGridView;
            if (theOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                theOrder.CurrentRow.Selected = true;
                var val = theOrder.Rows[e.RowIndex].Cells["idOrder"].FormattedValue.ToString();

                //------------------Marche pas-----------------------
                //string request = "SELECT * " +
                //    "FROM OrderDetails, Orders, Customer, Basket, Color " +
                //    "WHERE OrderDetails.idOrder = Orders.idOrder " +
                //    "AND OrderDetails.idArticle = Basket.idArticle " +
                //    "AND OrderDetails.idBike = Bike.idBike " +
                //    "AND OrdeDetails.idColor = Color.idColor ";
                //----------------------------------------------------

                string request = "SELECT *  FROM OrderDetails WHERE idOrder=" + val;

                DataTable orderDetail = Program.ReadSQL(request);

                detailsTable.DataSource = orderDetail;


            }
        }

        //-----------------------SQL query to get the the table "Orders" from the db
        private DataTable GetOrder()
        {
            string request = "SELECT Orders.idOrder, Customer.Name, Orders.Date, Orders.status " +
                "FROM Orders, Customer " +
                "WHERE Orders.Customer_id = Customer.Customer_id ";

            DataTable order = Program.ReadSQL(request);

            return order;

        }
    }
}
