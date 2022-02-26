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
    public partial class Commandevelo : Form
    {
        public Commandevelo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Clearform()
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Form)
                {
                    panel1.Controls.Remove(c);
                }
            }
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }
        public void Loadform(object Form)
        {
            Clearform();
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            Form form_to_load = Form as Form;
            form_to_load.TopLevel = false;
            form_to_load.Dock = DockStyle.Fill;
            panel1.Controls.Add(form_to_load);
            panel1.Tag = form_to_load;
            form_to_load.Show();
        }
    }
}
