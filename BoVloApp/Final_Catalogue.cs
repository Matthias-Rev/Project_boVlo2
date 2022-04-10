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
        Main main = null;
        public Final_Catalogue(Main main)
        {
            this.main = main;
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            // confirm and send the information on the db
            // addd to the database
            string insertMySQL = String.Format("INSERT INTO Customer (`Name`, `TVA`, `Address`, `Contact`) VALUES " +
            "('{0}','{1}','{2}','{3}' )", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            MessageBox.Show(insertMySQL);
            GlobalVar.WriteSQL(insertMySQL);
            main.clear();
            Close();
        }
    }
}
