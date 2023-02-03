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
    public partial class Newtournament : Form
    {
        public Newtournament()
        {
            InitializeComponent();
            tb_place.Hide();
            lbl_place.Hide();
        }

        private void cb_lan_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lan.Checked == true)
            {
                tb_place.Clear();
                lbl_place.Show();
                tb_place.Show();
            }else if(cb_lan.Checked == false)
            {
                tb_place.Hide();
                lbl_place.Hide();
            }
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}