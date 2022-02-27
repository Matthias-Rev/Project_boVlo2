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
    public partial class GestionDeCommande : Form
    {
        public GestionDeCommande()
        {
            InitializeComponent();
            Title.Location = GlobalVar.SetLocation(this, 0, -400, Title);
        }

        private void GestionDeCommande_Load(object sender, EventArgs e)
        {

        }
        public void Clearform()
        {
            foreach (Control c in backPanel.Controls)
            {
                if (c is Form)
                {
                    backPanel.Controls.Remove(c);
                    (c as Form).Close();
                }
            }

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            button1.Visible = true;
            Title.Visible = true;
            
        }
        public void Loadform(object Form)
        {
            Clearform();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            button1.Visible = false;
            Title.Visible = false;
            

            Form form_to_load = Form as Form;
            form_to_load.TopLevel = false;
            form_to_load.Dock = DockStyle.Fill;
            backPanel.Controls.Add(form_to_load);
            backPanel.Tag = form_to_load;
            form_to_load.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GlobalVar.Loadform(backPanel, new GestionDeCommande());
        }
    }
}
