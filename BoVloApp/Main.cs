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
            var myBtns = GlobalVar.GetAllButtons(this);
            int button_size_x = 400;
            int button_size_y = 100;
            foreach (var btn in myBtns)
            {
                btn.FlatStyle = FlatStyle.System;
                btn.Size = new Size(button_size_x, button_size_y);
            }
            int x_space = 300;
            int y_space = 100;
            Titel.Location = GlobalVar.SetLocation(this, 0, -400, Titel);
            COMMANDES.Location = GlobalVar.SetLocation(this, -x_space, -y_space, COMMANDES);
            STOCK.Location = GlobalVar.SetLocation(this, x_space, y_space, STOCK);
            CATALOGUE.Location = GlobalVar.SetLocation(this, -x_space, y_space, CATALOGUE);
            CALENDRIER.Location = GlobalVar.SetLocation(this, x_space, -y_space, CALENDRIER);
        }
      
        public void LoggedIn()
        {
            Username_label.Text = GlobalVar.ReadXML().username;
            Point point = new Point(Username_label.Location.X - Username_label.Size.Width, Username_label.Location.Y);
            Username_label.Location = point;
        }
        public void clear()
        {
            GlobalVar.Clearform(Main_panel);
        }
        private void Menu_button_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.ResetXML();
            Application.Exit();
        }
        private void Logout_button_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            GlobalVar.ResetXML();
            Hide();
            loginpage.ShowDialog();
            Close();
        }

        private void CATALOGUE_Click(object sender, EventArgs e)
        {
            GlobalVar.Loadform(Main_panel,new Catalog(this));
        }

        private void COMMANDES_Click(object sender, EventArgs e)
        {
            GlobalVar.Loadform(Main_panel, new GestionDeCommande());
        }
        private void CALENDRIER_Click(object sender, EventArgs e)
        {
            GlobalVar.Loadform(Main_panel, new Calendar());
        }
        private void STOCK_Click(object sender, EventArgs e)
        {
            GlobalVar.Loadform(Main_panel, new Stock());
        }
    }
}
