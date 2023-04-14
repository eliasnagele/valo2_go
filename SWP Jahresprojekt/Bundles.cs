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
    public partial class Bundles : Form
    {
        public static int BundleID;

        public Bundles()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            SQLInformation.BundlesShowAll(dt);
            dgv_bundles.DataSource = dt;
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_Bundle1_Click(object sender, EventArgs e)
        {
            BundleID = 1;   //signals the newest bundle was clicked

            this.Hide();
            BundleDetails bundleDetails = new BundleDetails();
            bundleDetails.ShowDialog();
            this.Show();
        }

        private void bt_Bundle2_Click(object sender, EventArgs e)
        {
            BundleID = 2;   //signals the second-newest bundle was clicked

            this.Hide();
            BundleDetails bundleDetails = new BundleDetails();
            bundleDetails.ShowDialog();
            this.Show();
        }
    }
}
