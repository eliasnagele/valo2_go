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
    public partial class BundleDetails : Form
    {
        public BundleDetails()
        {
            InitializeComponent();

            List<string> bundledetails = new List<string>();

            if (Bundles.BundleID.Equals(1))
            {
                bundledetails = SQLInformation.BundleDetails();
            }
            else if (Bundles.BundleID.Equals(2))
            {

            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
