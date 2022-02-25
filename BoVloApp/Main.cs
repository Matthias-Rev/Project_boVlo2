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
        public void Clearform()
        {
            foreach (Control c in Main_panel.Controls)
            {
                if (c is Form)
                {
                    Main_panel.Controls.Remove(c);
                    (c as Form).Close();
                }
            }
            Titel.Visible = true;
            COMMANDES.Visible = true;
            STOCK.Visible = true;
            CATALOGUE.Visible = true;
            CALENDRIER.Visible = true;
        }
        public void Loadform(object Form)
        {
            Clearform();
            Titel.Visible = false;
            COMMANDES.Visible = false;
            STOCK.Visible = false;
            CATALOGUE.Visible = false;
            CALENDRIER.Visible = false;
            Form form_to_load = Form as Form;
            form_to_load.TopLevel = false;
            form_to_load.Dock = DockStyle.Fill;
            Main_panel.Controls.Add(form_to_load);
            Main_panel.Tag = form_to_load;
            form_to_load.Show();
        }
        public void LoggedIn()
        {
            Username_label.Text = GlobalVar.ReadXML("username");
            Point point = new Point(Username_label.Location.X - Username_label.Size.Width, Username_label.Location.Y);
            Username_label.Location = point;
        }
        private void Menu_button_Click(object sender, EventArgs e)
        {
            Clearform();
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
            Loadform(new Catalogue());
        }

        private void COMMANDES_Click(object sender, EventArgs e)
        {
            Loadform(new GestionDeCommande());
        }
    }
}
