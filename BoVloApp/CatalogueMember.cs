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

        public void Clearform()
        {
            foreach (Control c in panelMember.Controls)
            {
                if (c is Form)
                {
                    panelMember.Controls.Remove(c);
                    (c as Form).Close();
                }
            }
            label1.Visible = true;
            label2.Visible = true;
            panel1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
        }
        public void Loadform(object Form)
        {
            Clearform();
            label1.Visible = true;
            label2.Visible = true;
            panel1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            Form form_to_load = Form as Form;
            form_to_load.TopLevel = false;
            form_to_load.Dock = DockStyle.Fill;
            panelMember.Controls.Add(form_to_load);
            panelMember.Tag = form_to_load;
            form_to_load.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loadform(new Final_Catalogue());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
