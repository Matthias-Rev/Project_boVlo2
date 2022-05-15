using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using MySql.Data.MySqlClient;
namespace BoVloApp
{
    static class Program
    {
        public static Dictionary<string, int> basket = new();
        static public DataTable types = ReadSQL("SELECT * FROM Bike");
        static public DataTable colors = ReadSQL("SELECT * FROM Color");
        static public DataTable sizes = ReadSQL("SELECT * FROM Size");
        static public List<Button> GetAllButtons(Form f)
        {
            List<Button> resultList = new List<Button>();
            foreach (Control a in f.Controls)
            {
                if (a is Button)
                {
                    resultList.Add((Button)a);
                }
            }
            return resultList;
        }
        static public Point SetLocation(Control contenant, int x, int y, Control contenu)
        {
            int form_horizontal_center = contenant.Width / 2;
            int form_vertical_center = contenant.Height / 2;
            int x_mid = contenu.Width / 2;
            int y_mid = contenu.Height / 2;
            x = contenant.Location.X + form_horizontal_center - x_mid + x;
            y = contenant.Location.Y + form_vertical_center - y_mid + y;
            return new Point(x, y);
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        static public void Clearform(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Form)
                {
                    panel.Controls.Remove(c);
                    (c as Form).Close();
                }
                else
                {
                    c.Visible = true;
                }
            }
        }
        static public void Loadform(Panel panel, Form form)
        {
            Clearform(panel);
            foreach (Control c in panel.Controls)
            {
                c.Visible = false;
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.Show();
        }
        static public DataTable ReadSQL(string request)
        {
            MySqlConnection connexion = Mysqlconn.connect();
            MySqlCommand command = new MySqlCommand(request, connexion);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataTable dt = new();
            dataAdapter.Fill(dt);
            connexion.Close();
            dataAdapter.Dispose();
            return dt;
        }
        static public void WriteSQL(string request)
        {
            MySqlConnection connexion = Mysqlconn.connect();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.InsertCommand = new MySqlCommand(request, connexion);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            connexion.Close();
        }
        static public void UpdateCombobox(ComboBox combobox, List<string> content)
        {
            combobox.Items.Clear();
            foreach (string item in content)
            {
                combobox.Items.Add(item);
            }
            combobox.Text = content[0];

        }
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main main = new Main();
            Application.Run(main);
        }
    }
}