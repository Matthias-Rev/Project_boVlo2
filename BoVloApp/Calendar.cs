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

        private void DisplayOrder(string beginning = "yes")
        {
            if (beginning == "yes")
            {
                CreateBtn();
            }
            DataTable order = GetMore();
            Calendar_grid.DataSource = order;
            Calendar_grid.Columns["Start"].DefaultCellStyle.Format = "yyyy/MM/dd";
            
        }
        //-----------------------Get the data source for the datagridview "Calendar"-
        private DataTable GetMore()
        {

            string request = "SELECT Customer.Name, Calendar.idOrder,Calendar.Start, Calendar.End " +
                "FROM Orders, Customer, Calendar " +
                "WHERE (Calendar.idOrder = Orders.idOrder AND Orders.Customer_id = Customer.Customer_id)" +
                "AND Calendar.Validate = 'false'";

            DataTable dates = GlobalVar.ReadSQL(request);


            return dates;

        }
        //----------------------------------Create a Buttonn on each row-------------------------------
        private void CreateBtn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            Calendar_grid.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Validate";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }
        //------------------------Upon clicking on the "Validate" btn, will change the value called Validate of the clicked command-----
        private void Validate_command(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView Validation = sender as DataGridView;
            if (Validation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Validation.CurrentRow.Selected = true;
                Validation.CurrentRow.Selected = true;
                var val = Validation.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
                var name_col = Validation.Columns[e.ColumnIndex].Name;
                var name_column = Validation.Rows[e.RowIndex].Cells["idOrder"].FormattedValue.ToString();

                string request_validation = String.Format("UPDATE Bovlo.Calendar SET Calendar.Validate = 'true' WHERE idOrder = '{0}'", name_column);

                DataTable orderDetail = GlobalVar.ReadSQL(request_validation);

                Validation.DataSource = orderDetail;


            }
        }

        //------------------------Editing the row, will change the row value in the Database-----
        private void Calendar_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView update = sender as DataGridView;
            if (update.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string request = String.Format(
                "SELECT * " +
                "FROM Calendar ",
                GlobalVar.ReadXML().key);
                DataTable calendar = GlobalVar.ReadSQL(request);
                string[] titels = { "Command_id", "Start date", "End date" };
                DataTable data = new();
            foreach (string titel in titels)
            {
                data.Columns.Add(titel);
            }
                foreach (DataRow row in calendar.Rows)

                {

                    update.CurrentRow.Selected = true;
                    var val = update.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
                    var name_col = update.Columns[e.ColumnIndex].Name;
                    var name_column = update.Rows[e.RowIndex].Cells["idOrder"].FormattedValue.ToString();

                    string request_update = String.Format("UPDATE Bovlo.Calendar SET {0} = CAST('{1}' AS DATETIME) WHERE idOrder = '{2}'", name_col, val, name_column);
                    DataTable orderDetail = GlobalVar.ReadSQL(request_update);

                    update.DataSource = orderDetail;
                    DisplayOrder("no");

                }
            }
        }
    }
}