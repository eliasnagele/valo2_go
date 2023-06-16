using System;
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
            SQLInformation.newTourNfill();
            tb_name.Text = SQLInformation.NTourName.ToString();
            tb_pricemoney.Text = SQLInformation.PriceMoney.ToString();              //filling the textboxes with the information about the competition
            tb_Date.Text = SQLInformation.Date.ToString();
            tb_Winner.Text = SQLInformation.Winner.ToString();
            if(SQLInformation.Lan == "1")
            {
                cb_lan.Checked = true;
                tb_place.Text = SQLInformation.Place.ToString();
            }
            else
            {
                cb_lan.Checked = false;
            }
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

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
