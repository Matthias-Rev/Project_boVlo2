using System;
using System.Windows.Forms;
namespace BoVloApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Titel.Location = GlobalVar.SetLocation(this, 0, -400, Titel);
            Login_box.Location = GlobalVar.SetLocation(this, 0, 0, Login_box);
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //check credentials in database
            if (user_input.Text == "User" && password_input.Text == "123")
            {
                GlobalVar.WriteXML("username", user_input.Text);
                Main main = new Main();
                main.Show();
                Hide();
            }
        }
    }
}
