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
    public partial class Login : Form
    {
        public static bool admin = false;

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

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string username = tb_UsernameLogin.Text;
            string password = tb_PasswordLogin.Text;

            admin = true;
        }

        private void bt_CreateAccount_Click(object sender, EventArgs e)
        {
            string username = tb_UsernameCa.Text;
            string password = tb_PasswordCA.Text;
            string confirmpassword = tb_ConfirmPasswordCA.Text;

            if(password == confirmpassword)
            {
                SQLInformation.AddUser(username, password);
            }
        }
    }
}
