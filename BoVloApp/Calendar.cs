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
            DisplayCalendar();
            ReadOnlyCertainColumns();
        }

        void ReadOnlyCertainColumns()
        {
            Calendar_grid.Columns["Name"].ReadOnly = true;
            Calendar_grid.Columns["idOrder"].ReadOnly = true;
        }

        //------------------------------------------------------------Fetches the datatable containing the db data concerning the production calendar---------------------------
        private void DisplayCalendar()
        {
            Calendar_grid.DataSource = GetCalendar(); ;
            Calendar_grid.Columns["Start"].DefaultCellStyle.Format = "yyyy/MM/dd";
        }

//--------------------------------------------------------Fetches the production calendar data from the db----------------------------------------------------------
        private DataTable GetCalendar()
        {
            string request = "SELECT Customer.Name, Calendar.idOrder,Calendar.Start, Calendar.End " +
                "FROM Orders, Customer, Calendar " +
                "WHERE Calendar.idOrder = Orders.idOrder " +
                "AND Orders.Customer_id = Customer.Customer_id";

            DataTable calendar = GlobalVar.ReadSQL(request);

            return calendar;
        }

//------------------------------------------------Allows to edit the datatable and to update the db with new data---------------------------------------------
        private void Calendar_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView update = sender as DataGridView;
            if (update.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                update.CurrentRow.Selected = true;
                var val = update.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
                var name_col = update.Columns[e.ColumnIndex].Name;
                var name_column = update.Rows[e.RowIndex].Cells["idOrder"].FormattedValue.ToString();
                string request = "UPDATE Calendar SET " + name_col + " = CAST("+ val +" AS DATE) WHERE idOrder = " + name_column;
                DataTable calendarUpdate = GlobalVar.ReadSQL(request);
                update.DataSource = calendarUpdate;
                GetCalendar();
            }
        }
    }
}
