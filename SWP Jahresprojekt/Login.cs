﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWP_Jahresprojekt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_ExitLogin_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_HomeLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
