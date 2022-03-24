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
    public partial class CatalogueMember : Form
    {
        public CatalogueMember()
        {
            InitializeComponent();
            label5.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVar.Loadform(panelMember, new Final_Catalogue());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // search the name of the society in the db
            string request = String.Format(
                "SELECT Name " +
                "FROM Customer " +
                "WHERE Name='{0}'"
                , textBox1.Text);
            DataTable dataSql = GlobalVar.ReadSQL(request);
            foreach (DataColumn column in dataSql.Columns)
            {

                foreach (DataRow row in dataSql.Rows)
                {
                    int i = 0;
                    bool condition = true;
                    try
                    {
                        while (condition == true)
                        {
                            string name = row[i].ToString();
                            if (name == textBox1.Text)
                            {
                                condition = false;
                                MessageBox.Show("trouvé");
                                string request_command = String.Format(
                                        "SELECT * " +
                                        "FROM Order ",
                                        GlobalVar.ReadXML().key);
                                DataTable calendar = GlobalVar.ReadSQL(request);
                            }
                        }
                                i++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        label5.Visible = true;
                        textBox1.Text = "";
                    }
                }
            }
            GlobalVar.Loadform(panelMember, new Final_Catalogue ());
        }
    }
}
