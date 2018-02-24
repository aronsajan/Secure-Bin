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
using System.Resources;
using System.Threading;
using Secure_Bin.Stability;

namespace Secure_Bin
{
    public partial class UnlockDialog : Form
    {
        string EntityName;
        EntityType EntType;
        string EntityTypeLabel;
        public delegate void ExitForm();
        public void SetEntityAttributes(string Name, EntityType Etype)
        {
            EntityName = Name;
            EntType = Etype;
        }

        public UnlockDialog()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuitRoutine();
            CloseForm();
        }

        private void QuitRoutine()
        {

            if (EntType == EntityType.Folder)
            {
                if (UnlockFolderThread != null)
                {
                    if (UnlockFolderThread.IsAlive)
                    {
                        UnlockFolderThread.Abort();
                    }
                }
            }
            else
            {
                if (UnlockFileThread != null)
                {
                    if (UnlockFileThread.IsAlive)
                    {
                        UnlockFileThread.Abort();
                    }
                }
            }
            GC.Collect();

        }


        private void CloseForm()
        {
            this.Close();
        }
        Thread UnlockFolderThread;
        Thread UnlockFileThread;
        string UnlockDest;
        private void UnlockButton_Click(object sender, EventArgs e)
        {
            if (UseMasterPasswordCheckbox.Checked)
            {
                UnlockPassword = Password;
            }
            else
            {
                UnlockPassword = TextPassword.Text;
            }
            if ((TextUnlockDest.Text.Length > 0) && ((TextPassword.Text.Length > 0) || (UseMasterPasswordCheckbox.Checked)))
            {

                UnlockDest = TextUnlockDest.Text[TextUnlockDest.Text.Length - 1].ToString() == @"\" ? TextUnlockDest.Text : TextUnlockDest.Text + @"\";
                panel4.Visible = true;
                tabControl1.Visible = false;
                if (EntType == EntityType.Folder)
                {
                    UnlockProgressText.Text = "Unlocking folder, please wait...";
                    UnlockFolderThread = new Thread(UnlockFolder);
                    UnlockFolderThread.Start();
                }
                else
                {
                    UnlockProgressText.Text = "Unlocking file, please wait...";
                    UnlockFileThread = new Thread(UnlockFile);
                    UnlockFileThread.Start();

                }

            }
            else
            {
                MessageBox.Show("Please fill in the required parameters for unlocking", "Required data missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        string _password;
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

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TextUnlockDest.Text = folderBrowserDialog1.SelectedPath;
            }
            folderBrowserDialog1.Reset();
        }
        ExitForm Quit;
        private void UnlockDialog_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
            UnlockDialogLabel.Text = "Unlock " + EntType.ToString();
            EntityLabel.Text = EntType.ToString();
            EntityNameLabel.Text = EntityName;
            Quit = new ExitForm(CloseForm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EntityLabel_Click(object sender, EventArgs e)
        {

        }

        private void EntityNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private string UnlockPassword
        {
            get;
            set;
        }
        private void UnlockFolder()
        {
            try
            {
                string FolderSecureAssembly = ConfigurationSettings.AppSettings["FolderSecure"];
                ISecureFolder SecureFolder = new InstantiateElement().CreateNewInstance(FolderSecureAssembly) as ISecureFolder;

                SecureFolder.UnlockFolder(EntityName, UnlockDest, UnlockPassword);
                IProcess ProcessObject = new InstantiateElement().CreateNewInstance(ConfigurationSettings.AppSettings["ProcessNamespace"], string.Format("{0}{1}", UnlockDest, EntityName)) as IProcess;
                ProcessObject.RunProcess();
            }
            catch (Exception UnlockException)
            {
                new RemoveTemporaryFiles().Remove();
                MessageBox.Show(EntType.ToString() + " unlocking failed as a result of the following exception : " + UnlockException.Message, EntType.ToString() + " unlocking failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.Invoke(Quit);
        }

        private void UnlockFile()
        {
            try
            {
                string FileSecureAssembly = ConfigurationSettings.AppSettings["FileSecure"];
                ISecureFile SecureFile = new InstantiateElement().CreateNewInstance(FileSecureAssembly) as ISecureFile;
                SecureFile.UnlockFile(EntityName, UnlockDest, UnlockPassword);
                IProcess ProcessObject = new InstantiateElement().CreateNewInstance(ConfigurationSettings.AppSettings["ProcessNamespace"], UnlockDest) as IProcess;
                ProcessObject.RunProcess();
            }
            catch (Exception UnlockException)
            {
                new RemoveTemporaryFiles().Remove();
                MessageBox.Show(EntType.ToString() + " unlocking failed as a result of the following exception : " + UnlockException.Message, EntType.ToString() + " unlocking failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.Invoke(Quit);
        }

        private void UnlockDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuitRoutine();
        }

        private void UseMasterPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseMasterPasswordCheckbox.Checked)
            {
                TextPassword.Clear();
                TextPassword.Enabled = false;
            }
            else
            {
                TextPassword.Enabled = true;

            }
        }




    }
}

#endregion