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
            foreach (var btn in myBtns)
            {
                btn.FlatStyle = FlatStyle.System;
            }
        }

        private void COMMANDES_Click(object sender, EventArgs e)
        {

        }
    }
}
