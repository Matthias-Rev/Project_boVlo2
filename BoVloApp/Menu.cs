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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            var myBtns = GlobalVar.GetAllButtons(this);
            int button_size_x = 400;
            int button_size_y = 100;
            foreach (var btn in myBtns)
            {
                btn.FlatStyle = FlatStyle.System;
                btn.Size = new Size(button_size_x, button_size_y);
            }
            int x_space = 300;
            int y_space = 100;
            Titel.Location = GlobalVar.SetLocation(this, 0, -400, Titel);
            COMMANDES.Location = GlobalVar.SetLocation(this, -x_space, -y_space, COMMANDES);
            STOCK.Location = GlobalVar.SetLocation(this, x_space, y_space, STOCK);
            CATALOGUE.Location = GlobalVar.SetLocation(this, -x_space, y_space, CATALOGUE);
            CALENDRIER.Location = GlobalVar.SetLocation(this, x_space, -y_space, CALENDRIER);
        }
        private void COMMANDES_Click(object sender, EventArgs e)
        {

        }

        private void CATALOGUE_Click(object sender, EventArgs e)
        {
            GlobalVar.menupage.Hide();
            GlobalVar.cataloguepage.ShowDialog();
        }

        private void CALENDRIER_Click(object sender, EventArgs e)
        {

        }

        private void STOCK_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
