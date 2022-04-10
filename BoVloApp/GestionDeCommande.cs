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
    public partial class GestionDeCommande : Form
    {
        public GestionDeCommande()
        {
            InitializeComponent();
            orderTable.DataSource = GetOrder();


        }    

        //----------------------------------------------------can't access "Order" Table-----------------
        private DataTable GetOrder()
        {
            //string request = "SELECT Customer.Name, Order.Date, Order.status " +
            //    "FROM Order, Customer " +
            //    "WHERE Order.Customer_id = Customer.Customer_id ";

            string request = "SELECT * " +
                "FROM Order ";
               
            DataTable order = GlobalVar.ReadSQL(request);

            return order;

        }
    }
}
