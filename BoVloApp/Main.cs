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
        }
        public void Loadform(object Form)
        {
            if (Main_panel.Controls.Count > 0)
            {
                Main_panel.Controls.Clear();
            }
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

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //GlobalVar.ResetXML();
            Application.Exit();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            //GlobalVar.ResetXML();
            loginpage.Show();
            Hide();
        }
    }
}
