﻿using System;
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
            GlobalVar.Loadform(panelMember, new Main());
        }
    }
}
