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
    public partial class Panier : Form
    {
        public Panier()
        {
            InitializeComponent();
        }

        public void Clearform()
        {
            foreach (Control c in PanelPanier.Controls)
            {
                if (c is Form)
                {
                    PanelPanier.Controls.Remove(c);
                    (c as Form).Close();
                }
            }

            buttonFinaliser.Visible = true;
            buttonPlanning.Visible = true;
            richTextBox1.Visible = true;
            LabelTotal.Visible = true;
            Title.Visible = true;
            vScrollBar1.Visible = true;
            richTextBox2.Visible = true;
            CadreTaille1.Visible = true;
            CadreType1.Visible = true;
            CadreQuantite1.Visible = true;
            CadrePrix1.Visible = true;
            richTextBox10.Visible = true;
            richTextBox6.Visible = true;
            richTextBox7.Visible = true;
            CadreCouleur1.Visible = true;
            richTextBox8.Visible = true;
            richTextBox12.Visible = true;
        }
        public void Loadform(object Form)
        {
            Clearform();
            buttonFinaliser.Visible = false;
            buttonPlanning.Visible = false;
            richTextBox1.Visible = false;
            LabelTotal.Visible = false;
            Title.Visible = false;
            vScrollBar1.Visible = false;
            richTextBox2.Visible = false;
            CadreTaille1.Visible = false;
            CadreType1.Visible = false;
            CadreQuantite1.Visible = false;
            CadrePrix1.Visible = false;
            richTextBox10.Visible = false;
            richTextBox6.Visible = false;
            richTextBox7.Visible = false;
            CadreCouleur1.Visible = false;
            richTextBox8.Visible = false;
            richTextBox12.Visible = false;

            Form form_to_load = Form as Form;
            form_to_load.TopLevel = false;
            form_to_load.Dock = DockStyle.Fill;
            PanelPanier.Controls.Add(form_to_load);
            PanelPanier.Tag = form_to_load;
            form_to_load.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loadform(new Final_Catalogue());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
