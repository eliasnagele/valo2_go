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

            SQLInformation.BundleDetails();

            tB_BundleDetailsDate.Text = SQLInformation.BundleDate;
            tB_BundleDetailsName.Text = SQLInformation.BundleName;
            tB_BundleDetailsPrice.Text = SQLInformation.BundlePrice;
            tB_BundleDetailsRarity.Text = SQLInformation.BundleRarity;              //filling the textboxes with the information of the bundles
            tB_BundleDetailsVariants.Text = SQLInformation.BundleVariants;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
