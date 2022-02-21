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
    public partial class Menu : BaseForm
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

            COMMANDES.Location = GlobalVar.SetLocation(this, -500,-100, COMMANDES);
        }
        private void COMMANDES_Click(object sender, EventArgs e)
        {

        }
    }
}
