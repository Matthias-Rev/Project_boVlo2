using System;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;

namespace BoVloApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoggedIn();
            var myBtns = Program.GetAllButtons(this);
            int button_size_x = 400;
            int button_size_y = 100;
            foreach (var btn in myBtns)
            {
                btn.FlatStyle = FlatStyle.System;
                btn.Size = new Size(button_size_x, button_size_y);
            }
            int x_space = 300;
            int y_space = 100;
            Titel.Location = Program.SetLocation(this, 0, -400, Titel);
            Orders.Location = Program.SetLocation(this, -x_space, -y_space, Orders);
            STOCK.Location = Program.SetLocation(this, x_space, y_space, STOCK);
            Catalog.Location = Program.SetLocation(this, -x_space, y_space, Catalog);
            Calendar.Location = Program.SetLocation(this, x_space, -y_space, Calendar);
        }
      
        public void LoggedIn()
        {
            //username can be used if session and permissions are added
            //Username_label.Text = Program.ReadXML().username;
            Point point = new Point(Username_label.Location.X - Username_label.Size.Width, Username_label.Location.Y);
            Username_label.Location = point;
        }
        public void clear()
        {
            Program.Clearform(Main_panel);
        }
        public void display(Form form)
        {
            Program.Clearform(Main_panel);
            Program.Loadform(Main_panel, form);
        }
        private void Menu_button_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void Logout_button_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            Hide();
            loginpage.ShowDialog();
            Close();
        }

        private void CATALOGUE_Click(object sender, EventArgs e)
        {
            Program.Loadform(Main_panel,new Catalog(this));
        }

        private void COMMANDES_Click(object sender, EventArgs e)
        {
            Program.Loadform(Main_panel, new OrderManagement());
        }
        private void CALENDRIER_Click(object sender, EventArgs e)
        {
            Program.Loadform(Main_panel, new Calendar());
        }
        private void STOCK_Click(object sender, EventArgs e)
        {
            Program.Loadform(Main_panel, new Supply());
        }
    }
}
