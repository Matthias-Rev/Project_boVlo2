using System;
using System.Windows.Forms;
using System.Threading;
namespace BoVloApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Titel.Location = GlobalVar.SetLocation(this, 0, -400, Titel);
            Login_box.Location = GlobalVar.SetLocation(this, 0, 0, Login_box);
            AcceptButton = login_button;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //Authentify();
            Mysqlconn.SQL_request();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Authentify()
        {
            //check credentials in database
            //if (user_input.Text == "User" && password_input.Text == "123")
            if (password_input.Text == "123")
            {
                GlobalVar.WriteXML("username", user_input.Text);
                Main main = new Main();
                Hide();
                main.ShowDialog();
                Close();
            }
        }

        private void user_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_input.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
