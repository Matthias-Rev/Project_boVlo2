﻿using System;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Data;

namespace BoVloApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Titel.Location = Program.SetLocation(this, 0, -400, Titel);
            Login_box.Location = Program.SetLocation(this, 0, 0, Login_box);
            AcceptButton = login_button;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Authentify();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Authentify()
        {
            //check credentials in database
            string request = string.Format(
                "SELECT User_id, Permission " +
                "FROM Users " +
                "WHERE Username='{0}' AND Pass='{1}'"
                , user_input.Text, password_input.Text);
            DataTable data = Program.ReadSQL(request);
            foreach(DataRow row in data.Rows)
            {
                Session session = new();
                session.username = user_input.Text;
                session.titel = row["Permission"].ToString();
                session.key = Program.RandomString(20);
                //create session element in program can be added later
                Main main = new Main();
                Hide();
                main.ShowDialog();
                Close();
            }
            MessageBox.Show("Données de connexion invalides");
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
