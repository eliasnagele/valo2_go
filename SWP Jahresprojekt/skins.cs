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
    public partial class skins : Form
    {
        public skins()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            SQLInformation.SkinsshowAll(dt);        //filling the datagridview
            dtv_skins.DataSource = dt;
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void skins_Load(object sender, EventArgs e)
        {

        }
    }
}
