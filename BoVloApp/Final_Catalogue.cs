using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BoVloApp
{
    public partial class Final_Catalogue : Form
    {
        public Final_Catalogue()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            // confirm and send the information on the db
            MySqlConnection connexion = Mysqlconn.connect();
            GlobalVar.Loadform(panelFinal, new Main());
            // textBox1.Text
            connexion.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // addd to the database
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // addd to the database
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // addd to the database
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // add db
        }
    }
}
