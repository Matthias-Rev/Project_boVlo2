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
    public partial class Calendar : Form
    {
            public Calendar()
        {
            InitializeComponent();
            DisplayOrder();
        }

<<<<<<< HEAD
        private void DisplayOrder()
        {
            DataTable order = GetMore();
            //DataTable order = GetCalendar();
            Calendar_grid.DataSource = order;
            Calendar_grid.Columns["Start"].DefaultCellStyle.Format = "yyyy/MM/dd";
        }

            
        private DataTable GetCalendar()
        {
            string request = "SELECT Calendar " +
                "FROM Calendar ";
            DataTable dates = GlobalVar.ReadSQL(request);

            return dates;

        }
        private DataTable GetMore()
        {
            string request = "SELECT Customer.Name, Calendar.idOrder,Calendar.Start, Calendar.End " +
                "FROM Orders, Customer, Calendar " +
                "WHERE Calendar.idOrder = Orders.idOrder " +
                "AND Orders.Customer_id = Customer.Customer_id";

            DataTable order = GlobalVar.ReadSQL(request);


            return order;

        }
        private DataTable Update_date()
        {
            string request = "SELECT Customer.Name ,Calendar.idOrder, Calendar.Start, Calendar.End " +
                "FROM Orders, Customer, Calendar " +
                "WHERE Calendar.idOrder = Orders.idOrder " +
                "AND Orders.Customer_id = Customer.Customer_id";
            DataTable order = GlobalVar.ReadSQL(request);
            return order;
        }

        private void Calendar_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView update = sender as DataGridView;
            if (update.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
=======
            string request = String.Format(
            "SELECT * " +
            "FROM Calendar "
    ,       GlobalVar.ReadXML().key);
            DataTable calendar = GlobalVar.ReadSQL(request);
            string[] titels = { "Command_id", "Start date", "End date"};
            DataTable data = new();
            foreach (string titel in titels)
            {
                data.Columns.Add(titel);
            }
            foreach (DataRow row in calendar.Rows)
>>>>>>> bcd9de73f17aae232d0b26841957090f3a49d6b1
            {

                update.CurrentRow.Selected = true;
                var val = update.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
                var name_col = update.Columns[e.ColumnIndex].Name;
                var name_column = update.Rows[e.RowIndex].Cells["idOrder"].FormattedValue.ToString();

                //------------------Marche pas-----------------------
                //string request = "SELECT * " +
                //    "FROM OrderDetails, Orders, Customer, Basket, Color " +
                //    "WHERE OrderDetails.idOrder = Orders.idOrder " +
                //    "AND OrderDetails.idArticle = Basket.idArticle " +
                //    "AND OrderDetails.idBike = Bike.idBike " +
                //    "AND OrdeDetails.idColor = Color.idColor ";
                //----------------------------------------------------

                string request = "UPDATE Calendar SET " + name_col + " = CAST("+ val +" AS DATETIME) WHERE idOrder = " + name_column;
                DataTable orderDetail = GlobalVar.ReadSQL(request);

                update.DataSource = orderDetail;
                GetMore();

                //-------------------------This label is used for debugging purposes
                //label2.Text = val.ToString();

            }
        }
    }
}
