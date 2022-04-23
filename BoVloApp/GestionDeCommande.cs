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
    public partial class GestionDeCommande : Form
    {
        public GestionDeCommande()
        {
            InitializeComponent();
            DisplayOrder();
        }

        private void DisplayOrder()
        {
            DataTable order = GetOrder();
            orderTable.DataSource = order;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            orderTable.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Get Details";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void orderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView theOrder = sender as DataGridView;
            if (theOrder != null)
            {
                var val = theOrder.CurrentCell.Value.ToString();

                //------------------Marche pas-----------------------
                //string request = "SELECT * " +
                //    "FROM OrderDetails, Orders, Customer, Basket, Color " +
                //    "WHERE OrderDetails.idOrder = Orders.idOrder " +
                //    "AND OrderDetails.idArticle = Basket.idArticle " +
                //    "AND OrderDetails.idBike = Bike.idBike " +
                //    "AND OrdeDetails.idColor = Color.idColor ";
                //----------------------------------------------------

                string request = "SELECT *  FROM OrderDetails WHERE idOrder=" + val;

                DataTable orderDetail = GlobalVar.ReadSQL(request);

                detailsTable.DataSource = orderDetail;

                label.Text = val;

            }

        }

        
        //private DataTable GetDetails()
        //{
        //      string request = "SELECT * " +
        //          "FROM OrderDetails, Orders, Customer, Basket, Color " +
        //          "WHERE OrderDetails.idOrder = Orders.idOrder ";
        //          "AND OrderDetails.idArticle = Basket.idArticle "+
        //          "AND OrderDetails.idBike = Bike.idBike "+
        //          "AND OrdeDetails.idColor = Color.idColor ";

        //    string request = "SELECT *  FROM OrderDetails";

        //    DataTable orderDetail = GlobalVar.ReadSQL(request);

        //    return orderDetail;

        //}
        private DataTable GetOrder()
        {
            string request = "SELECT Orders.idOrder, Customer.Name, Orders.Date, Orders.status " +
                "FROM Orders, Customer " +
                "WHERE Orders.Customer_id = Customer.Customer_id ";

            DataTable order = GlobalVar.ReadSQL(request);

            return order;

        }
    }
}
