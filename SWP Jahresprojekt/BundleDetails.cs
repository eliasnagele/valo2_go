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

            DataTable dt = new DataTable();
            
            dt = SQLInformation.BundleDetails();

            if (Bundles.BundleID.Equals(1))
            {
                
                
               
                
            }
            else if(Bundles.BundleID.Equals(2))
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
