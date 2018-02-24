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
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }
        string _username, _password;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (UserText.Text.Length > 0)
            {
                if (PasswordText.Text.Length >= 8)
                {
                    if (PasswordText.Text.Length <= 16)
                    {
                        if (PasswordText.Text.CompareTo(cnfrmText.Text) == 0)
                        {
                            SaveLoginCredentials ResetCredentials = new SaveLoginCredentials(UserText.Text, PasswordText.Text);
                            ResetCredentials.SaveCredentialsExecute();
                            MessageBox.Show("Your settings has been changed successfully", "Secure Bin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Re-typed password doesn't match with the password you entered", "Password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password should be less than 17 characters", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password should be greater than 7 characters", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username required", "Data required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UserText_TextChanged(object sender, EventArgs e)
        {
            PasswordText.Clear();
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            cnfrmText.Clear();

        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            UserText.Text = Username;
            PasswordText.Text = Password;
            cnfrmText.Text = Password;
        }

    }
}

#endregion