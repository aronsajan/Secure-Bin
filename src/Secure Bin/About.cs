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
using SecureBinCore.Engine;
using SecureBinCore.Engine.FactoryClass;

namespace Secure_Bin
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            VersionLabel2.Text = ConfigurationSettings.AppSettings["Version"];
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {
            IProcess SendMail = new InstantiateElement().CreateNewInstance(ConfigurationSettings.AppSettings["ProcessNamespace"], "mailto:aronsajan@gmail.com") as IProcess;
            SendMail.RunProcess();
        }
    }
}

#endregion