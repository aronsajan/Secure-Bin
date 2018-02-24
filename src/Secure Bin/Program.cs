#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Secure_Bin.Stability;
using System.Configuration;
using System.IO;
using Secure_Bin.LoginAuthentication;

namespace Secure_Bin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Directory.Exists(ConfigurationSettings.AppSettings["AllEntityLocation"]))
            {
                Directory.CreateDirectory(ConfigurationSettings.AppSettings["AllEntityLocation"]);
            }
            try
            {

                if (new FirstTimePasswordSet().IsPasswordToBeSet)
                {
                    Application.Run(new SetPassword());
                }
                else
                {
                    Application.Run(new SplashScreen());
                }
            }
            catch (Exception StartupException)
            {
                MessageBox.Show(StartupException.Message, "Startup failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

#endregion