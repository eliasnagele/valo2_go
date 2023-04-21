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
    public partial class news : Form
    {
        public news()
        {
            InitializeComponent();
            tb_newsOne.Text = "Hier stehen später Nachrichten!!! \n"+ "Hier stehen später Nachrichten!!! \n"+ "Hier stehen später Nachrichten!!! \n"+ "Hier stehen später Nachrichten!!! \n";
            tb_newsTwo.Text = "Hier stehen später Nachrichten!!! \n" + "Hier stehen später Nachrichten!!! \n" + "Hier stehen später Nachrichten!!! \n" + "Hier stehen später Nachrichten!!! \n";
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
