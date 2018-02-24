#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Secure_Bin.LoginAuthentication;

namespace Secure_Bin
{
    public partial class SetPassword : Form
    {
        public SetPassword()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SavePasswordButton_Click(object sender, EventArgs e)
        {
            if ((UsernameText.Text.Length > 0) && (PasswordText.Text.Length > 0))
            {
                if (PasswordText.Text.CompareTo(ConfirmPasswordText.Text) == 0)
                {
                    if ((PasswordText.Text.Length >= 8) && (PasswordText.Text.Length <= 16))
                    {
                        SaveLoginCredentials SaveCredentials = new SaveLoginCredentials(UsernameText.Text, PasswordText.Text);
                        SaveCredentials.SaveCredentialsExecute();
                        MessageBox.Show("Application needs to restart for settings to take effect", "Restart Secure Bin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Password should have a length ranging from 8-16 characters", "Secure Bin", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Secure Bin", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Please enter the required data", "Secure Bin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}

#endregion