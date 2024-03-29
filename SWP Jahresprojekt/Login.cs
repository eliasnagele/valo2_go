﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public static bool loggedin = false;

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
            bool usernameexist = false;
            bool userisadmin = false;

            string username = tb_UsernameLogin.Text;
            string password = tb_PasswordLogin.Text;

            usernameexist = SQLInformation.CheckIfUsernameExists(username);     //checking if the username exists
            userisadmin = SQLInformation.CheckIfUserIsAdmin(username);          //checking if the user is an admin
            
            if (usernameexist.Equals(true))
            {
                bool matchingpassword = SQLInformation.GetPassword(username, password);

                if (matchingpassword.Equals(true))
                {
                    loggedin = true;
                    admin = userisadmin;
                    MessageBox.Show("Login succesful");
                }
                else
                    MessageBox.Show("Wrong username or password");
            }
        }       //logging in the user

        private void bt_CreateAccount_Click(object sender, EventArgs e)
        {
            string username = tb_UsernameCa.Text;
            string password = tb_PasswordCA.Text;
            string confirmpassword = tb_ConfirmPasswordCA.Text;

            if(password == confirmpassword)     //checking if the entered passwords match
            {
                SQLInformation.AddUser(username, password);
                MessageBox.Show(username.ToUpper() + " wurde erfolgreich erstellt!"); ;
                tb_UsernameCa.Clear();
                tb_PasswordCA.Clear();
                tb_ConfirmPasswordCA.Clear();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }       //create a new account
    }
}
