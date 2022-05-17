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
            CreateBtn();
            DisplayCalendar();
            ReadOnlyCertainColumns();
            
        }

        void main_Call()
        {
            //CreateBtn();
            DisplayCalendar();
            
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
            Calendar_grid.Columns["Start_Date"].DefaultCellStyle.Format = "yyyy/MM/dd";
            Calendar_grid.Columns["End_Date"].DefaultCellStyle.Format = "yyyy/MM/dd";
        }

//--------------------------------------------------------Fetches the production calendar data from the db----------------------------------------------------------
        private DataTable GetCalendar()
        {
            string request = "SELECT Customer.Name, Orders.idOrder,Orders.Start_Date, Orders.End_Date " +
                "FROM Orders, Customer " +
                "WHERE (Orders.Customer_id = Customer.Customer_id AND Orders.Status = 'To Do') ";

            DataTable calendar = Program.ReadSQL(request);

            return calendar;
        }

        //----------------------------------Create a Buttonn on each row-------------------------------
        private void CreateBtn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            Calendar_grid.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Validate ?";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        //------------------------Upon clicking on the "Validate ?" btn, will change the value of Libary.Validate of the given order-----
        private void Validation(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView update_validate = sender as DataGridView;
            if (update_validate.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                update_validate.CurrentRow.Selected = true;
                var name_column = update_validate.Rows[e.RowIndex].Cells["idOrder"].FormattedValue.ToString();

                string request = "UPDATE Orders SET Orders.Status = 'Done' WHERE idOrder = " + name_column;

                DataTable orderDetail = Program.ReadSQL(request);

                update_validate.DataSource = orderDetail;

                main_Call();


            }
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
                string request = string.Format("UPDATE Orders SET {0} = CAST('{1}' AS DATE) WHERE idOrder = '{2}'",name_col, val, name_column);
                DataTable calendarUpdate = GlobalVar.ReadSQL(request);
                update.DataSource = calendarUpdate;
                main_Call();
            }
        }
    }
}
