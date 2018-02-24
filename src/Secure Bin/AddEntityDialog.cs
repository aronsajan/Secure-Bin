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
using System.Threading;
using Secure_Bin.Stability;

namespace Secure_Bin
{
    public partial class AddEntityDialog : Form
    {
        public AddEntityDialog()
        {
            InitializeComponent();
        }
        EntityType Entity;
        Thread LockFolder;
        Thread LockFile;
        string PasswordToLock;
        string _masterPassword = "";
        public delegate void ExitForm();
        private void LockButton_Click(object sender, EventArgs e)
        {

            if (TargetEntitytext.Text.Length > 0)
            {
                if ((PasswordText.Text.Length > 0) || (MasterPasswordCheckbox.Checked))
                {
                    if (!MasterPasswordCheckbox.Checked)
                    {
                        if (PasswordText.Text.CompareTo(ConfirmPasswordText.Text) == 0)
                        {
                            PasswordToLock = PasswordText.Text;
                            LockRoutine();
                        }
                        else
                        {
                            MessageBox.Show("Password's do not match, please re-enter the password", "Password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            PasswordText.Text = "";
                            ConfirmPasswordText.Text = "";
                        }
                    }
                    else
                    {
                        PasswordToLock = MasterPassword;
                        LockRoutine();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a password to lock", "Password required", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
        }

        private void LockRoutine()
        {
            tabControl1.Visible = false;
            panel2.Visible = true;
            LockButton.Enabled = false;
            if (Entity == EntityType.Folder)
            {
                ProgressIndicatorText.Text = "Securing folder, please wait...";
                LockFolder = new Thread(SecureFolderThread);
                LockFolder.Start();
            }
            else
            {
                if (Entity == EntityType.File)
                {
                    ProgressIndicatorText.Text = "Securing file, please wait...";
                    LockFile = new Thread(SecureFileThread);
                    LockFile.Start();
                }
            }
        }

        private void CloseForm()
        {
            this.Close();
        }

        string TargetEntity;
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (Entity == EntityType.Folder)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    TargetEntitytext.Text = folderBrowserDialog1.SelectedPath;
                    TargetEntity = TargetEntitytext.Text;
                    folderBrowserDialog1.Reset();
                }
            }
            else
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Title = "Select the file to be secured";
                openFileDialog1.Filter = "All Files|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    TargetEntitytext.Text = openFileDialog1.FileName;
                    TargetEntity = TargetEntitytext.Text;
                }
                openFileDialog1.Reset();
            }
        }
        ExitForm Quit;
        private void AddEntityDialog_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Quit = new ExitForm(CloseForm);

            if (Entity == EntityType.Folder)
            {
                label1.Text = "Secure folder";
                TargetEntitylabel.Text = "Target folder";
                this.Text = "Add folder dialog";
                ContextImage.Image = Secure_Bin.Properties.Resources.encrypt;
            }
            else
            {
                label1.Text = "Secure file";
                TargetEntitylabel.Text = "Target file";
                this.Text = "Add file dialog";
                ContextImage.Image = Secure_Bin.Properties.Resources.protect_document;
            }
        }

        public void SetEntityType(EntityType Entity)
        {
            this.Entity = Entity;
        }
        public string MasterPassword
        {
            set
            {
                _masterPassword = value;
            }
            get
            {
                return _masterPassword;
            }
        }

        private void SecureFolderThread()
        {
            string FolderSecureAssembly = ConfigurationSettings.AppSettings["FolderSecure"];

            try
            {
                ISecureFolder SecureFolder = new InstantiateElement().CreateNewInstance(FolderSecureAssembly) as ISecureFolder;
                string FolderToLock = TargetEntity;
                folderBrowserDialog1.Reset();
                try
                {
                    SecureFolder.LockFolder(FolderToLock, PasswordToLock);


                }
                catch (Exception LockFailed)
                {
                    new RemoveTemporaryFiles().Remove();
                    MessageBox.Show("Folder locking failed as a result of the exception: " + LockFailed.Message, "Locking failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (ArgumentNullException NamespaceNotFound)
            {

                MessageBox.Show("The folder cannot be locked because, one or more files of Secure Bin has been corrupted", "Locking failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Invoke(Quit);
        }

        private void SecureFileThread()
        {
            try
            {

                ISecureFile SecureFile = new InstantiateElement().CreateNewInstance(ConfigurationSettings.AppSettings["FileSecure"]) as ISecureFile;
                SecureFile.LockFile(TargetEntity, PasswordToLock);

            }
            catch (Exception LockFailed)
            {
                new RemoveTemporaryFiles().Remove();
                MessageBox.Show("File locking failed as a result of the exception: " + LockFailed.Message, "Locking failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Invoke(Quit);
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            QuitRoutine();
            CloseForm();
        }

        private void QuitRoutine()
        {

            if (Entity == EntityType.Folder)
            {
                if (LockFolder != null)
                {
                    if (LockFolder.IsAlive)
                    {
                        LockFolder.Abort();
                    }
                }
            }
            else
            {
                if (LockFile != null)
                {
                    if (LockFile.IsAlive)
                    {
                        LockFile.Abort();
                    }
                }
            }


        }

        private void AddEntityDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuitRoutine();
        }

        private void MasterPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            PasswordText.Text = "";
            ConfirmPasswordText.Text = "";
            CustomPasswordFlag(!MasterPasswordCheckbox.Checked);
        }

        private void CustomPasswordFlag(bool useCustom)
        {
            PasswordText.Enabled = useCustom;
            ConfirmPasswordText.Enabled = useCustom;
        }





    }
}

#endregion