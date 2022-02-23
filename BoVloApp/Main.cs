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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Loginpage();
        }
        public void Loadform(object Form)
        {
            if (this.Main_panel.Controls.Count > 0)
            {
                this.Main_panel.Controls.Clear();
            }
            Form form_to_load = Form as Form;
            form_to_load.TopLevel = false;
            form_to_load.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(form_to_load);
            this.Main_panel.Tag = form_to_load;
            form_to_load.Show();
        }
        public void LoggedIn()
        {
            Login_Panel.SendToBack();
            Topbar_panel.Visible = true;
            Main_panel.Visible = true;
        }
        public void Loginpage()
        {
            //if logged in, logout (session managment)
            Topbar_panel.Visible = false;
            Main_panel.Visible = false;
            if (Login_Panel.Controls.Count > 0)
            {
                Login_Panel.Controls.Clear();
            }
            Form loginform = new Login();
            loginform.TopLevel = false;
            Login_Panel.Controls.Add(loginform);
            loginform.Show();
            Login_Panel.BringToFront();
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {

        }

    }
}
