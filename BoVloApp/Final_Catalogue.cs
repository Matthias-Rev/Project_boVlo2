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
    public partial class Final_Catalogue : Form
    {
        public Final_Catalogue()
        {
            InitializeComponent();
        }

        public void Clearform()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Form)
                {
                    this.Controls.Remove(c);
                    (c as Form).Close();
                }
            }
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
        }
        public void Loadform(object Form)
        {
            Clearform();
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;
            Form form_to_load = Form as Form;
            form_to_load.TopLevel = false;
            form_to_load.Dock = DockStyle.Fill;
            this.Controls.Add(form_to_load);
            this.Tag = form_to_load;
            form_to_load.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Loadform(new Main());
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
    }
}
