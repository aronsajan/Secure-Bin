#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Secure_Bin
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            VersionLabel.Text = ConfigurationSettings.AppSettings["Version"];
            SplashTimer.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Stop();
            this.Hide();
            SecureBinHome MainPage = new SecureBinHome();
            MainPage.Show();
        }
    }
}

#endregion