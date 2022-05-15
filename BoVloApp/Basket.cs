using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace BoVloApp
{
    public partial class Basket : Form
    {
        Main main = null;
        DataTable basket;
        public Basket(Main main)
        {
            this.main = main;
            InitializeComponent();
            basket = GetBasket();
            basket.Columns.Add("Type");
            basket.Columns.Add("Color");
            basket.Columns.Add("Size");
            basket.Columns.Add("Quantity");
            if(Program.basket.Keys.Count > 0)
            {
                foreach (string article in Program.basket.Keys)
                {
                    string[] variables = article.Split('_');
                    DataRow row = basket.NewRow();
                    row["Type"] = variables[0];
                    row["Color"] = variables[1];
                    row["Size"] = variables[2];
                    row["Quantity"] = Program.basket[article];
                    basket.Rows.Add(row);
                }
                DisplayBasket();
                CalculateDeliveryDate();
            }
            
        }
        private void DisplayBasket()
        {
            
            panierData.DataSource = basket;
            panierData.Columns["Type"].ReadOnly = true;
            panierData.Columns["Color"].ReadOnly = true;
            panierData.Columns["Size"].ReadOnly = true;
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            int prixtotal = 0;
            foreach (DataRow row in basket.Rows)
            {
                int quantity = int.Parse(row["Quantity"].ToString());
                int price = int.Parse(Program.types.Select(string.Format("Name = '{0}'", row["Type"]))[0]["Price"].ToString());
                prixtotal += price * quantity;
            }
            LabelPrixTotal.Text = prixtotal.ToString();
        }
        private void CalculateDeliveryDate()
        {
            // Calculate the amount of work-hours needed for the order
            float totalworktime = 0;
            foreach (DataRow row in basket.Rows)
            {
                int quantity = int.Parse(row["Quantity"].ToString());
                int time = int.Parse(Program.types.Select(string.Format("Name = '{0}'", row["Type"]))[0]["Delay"].ToString());
                totalworktime += time * quantity;
            }
            // Transform working day in working hours considering 7 hours of work per day
            float raw_needed_working_days = totalworktime/7;
            
            // Devide the working-days by the amount of workshops
            string get_workshops_request = "SELECT * FROM Workshop";
            DataTable get_workshops_response = Program.ReadSQL(get_workshops_request);
            int workshops_amount = get_workshops_response.Rows.Count;
            raw_needed_working_days = raw_needed_working_days / workshops_amount;

            //Add time margin of 10% of the total time 
            raw_needed_working_days = raw_needed_working_days * (float)1.1;

            // Round up
            int needed_working_days = (int)Math.Ceiling(raw_needed_working_days);

            // Get first available working date
            DateTime first_available_working_day;
            string get_oldest_date_request = "SELECT * FROM Bovlo.Orders where Status <> 'Delivered' order by End_date DESC LIMIT 1";
            DataTable oldest_day_response = Program.ReadSQL(get_oldest_date_request);
            if(oldest_day_response.Rows.Count == 1)
            {
                string date = oldest_day_response.Rows[0]["End_Date"].ToString().Split(' ')[0];
                string day = date.Split("/")[0];
                string month = date.Split("/")[1];
                string year = date.Split("/")[2];
                first_available_working_day = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            }
            else
            {
                first_available_working_day = DateTime.UtcNow;
            }
            DateTime delivery_day = first_available_working_day;
            while (needed_working_days > 0)
            {
                delivery_day = delivery_day.AddDays(1);
                if ((int)delivery_day.DayOfWeek == 6 || (int)delivery_day.DayOfWeek == 7)
                {
                    //weekend
                }
                else
                {
                    needed_working_days--;
                }
            }
            Program.estimate_delivery_date = delivery_day;
            CultureInfo culture = new CultureInfo("en-US");
            label_estimate_date.Text = Program.estimate_delivery_date.ToString("D",culture);
        }


        private void buttonFinaliser_Click(object sender, EventArgs e)
        {
            if(basket.Rows.Count > 0)
            {
                Program.Loadform(PanelPanier, new CatalogMember(main));
            }
            else
            {
                MessageBox.Show("Empty basket");
            }
        }

        private DataTable GetBasket()
        {
            DataTable basket = new();
            return basket;
        }
        //
        //---------------------------------------------------------bouton pour update la db--------------------------------------------
        //
        private void panierData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = basket.Rows[panierData.CurrentCell.RowIndex];
            string reference = row["Type"] + "_" + row["Color"] + "_" + row["Size"];
            Program.basket[reference] = int.Parse(panierData.CurrentCell.Value.ToString());
            CalculatePrice();
            CalculateDeliveryDate();
        }

        private void catalog_button_Click(object sender, EventArgs e)
        {
            main.display(new Catalog(main));
            Close();
        }
    }
}
