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
    public partial class tournament : Form
    {
        public tournament()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            SQLInformation.tournamentShowAll(dt);       //filling the datagridview
            dtv_tournament.DataSource = dt;
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_newtournament1_Click(object sender, EventArgs e)
        {
            Newtournament newtournament = new Newtournament();
            this.Hide();
            newtournament.ShowDialog();
            this.Show();
        }

        private void btn_newtournament2_Click(object sender, EventArgs e)
        {
            Newtournament newtournament = new Newtournament();
            this.Hide();
            newtournament.ShowDialog();
            this.Show();
        }
    }
}
