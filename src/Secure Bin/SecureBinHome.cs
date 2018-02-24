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
using SecureBinCore.Engine.FactoryClass;
using SecureBinCore.Engine;
using SecureBinCore.UI;
using Secure_Bin.LoginAuthentication;

namespace Secure_Bin
{
    public partial class SecureBinHome : Form
    {
        const int FILE_ICON = 0;
        const int FOLDER_ICON = 1;
        EntityType SelectedEntity;
        string username;
        string password;
        public SecureBinHome()
        {
            InitializeComponent();
        }

        private void SecureBinHome_Resize(object sender, EventArgs e)
        {
            SetFormElementSize();
        }

        private void SetFormElementSize()
        {
            #region Dynamic Form Element Size
            pictureBox3.Size = new Size(this.Width, pictureBox3.Size.Height);
            pictureBox2.Size = new Size(this.Width, pictureBox2.Size.Height);
            SecureTools.Size = new Size(this.Width, SecureTools.Height);
            int HeightDiff = (statusStrip1.Location.Y) - (ExploreArea.Location.Y + ExploreArea.Height);

            ExploreArea.Size = new Size(this.Width, ExploreArea.Height + HeightDiff);
            #endregion

        }

        private void SecureBinHome_Load(object sender, EventArgs e)
        {
            #region UI Onload Function
            this.Text += " " + ConfigurationSettings.AppSettings["Version"];
            ControlsFlag(false);
            ExploreArea.Visible = false;
            panel1.Visible = true;
            SetFormElementSize();
            ExploreArea.LargeImageList = IconImages;



            #endregion


        }
        private void ControlsFlag(bool flag)
        {
            toolStripAddFileButton.Enabled = flag;
            toolStripButton4.Enabled = flag;
            toolStripButton5.Enabled = flag;
            toolStripButtonAddFolder.Enabled = flag;
            toolStripRefreshButton.Enabled = flag;
            toolStripSettingsButton.Enabled = flag;

        }

        private void AfterAuthentication()
        {
            ExploreArea.Visible = true;
            this.MaximizeBox = true;
            ControlsFlag(true);
            RefreshView();

            this.panel1.Enabled = false;
            this.panel1.Visible = false;

        }
        private void RefreshView()
        {
            #region Explore area refresh view
            ExploreArea.Items.Clear();
            IUISystem UserInterface = new InstantiateElement().CreateNewInstance(ConfigurationSettings.AppSettings["UI"], (ConfigurationSettings.AppSettings["SecureExtension"])) as IUISystem;
            List<string> ListOfFolders = UserInterface.ListAllFolders(false);
            List<string> ListOfFiles = UserInterface.ListAllFiles(false);
            foreach (string folderitem in ListOfFolders)
            {
                ListViewItem itemfolder = new ListViewItem(folderitem);
                itemfolder.ImageIndex = 1;
                ExploreArea.Items.Add(itemfolder);
            }
            foreach (string fileitem in ListOfFiles)
            {
                ListViewItem itemfile = new ListViewItem(fileitem);
                itemfile.ImageIndex = 0;
                ExploreArea.Items.Add(itemfile);
            }
            GC.Collect();
            #endregion

        }

        private void SecureBinHome_LocationChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButtonAddFolder_Click(object sender, EventArgs e)
        {
            AddEntityDialog AddNewEntity = new AddEntityDialog();
            AddNewEntity.SetEntityType(EntityType.Folder);
            AddNewEntity.MasterPassword = password;
            AddNewEntity.ShowDialog();

            RefreshView();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            UnlockDialog UnlockEntity = new UnlockDialog();
            if (ExploreArea.SelectedItems.Count == 1)
            {
                UnlockEntity.SetEntityAttributes(ExploreArea.SelectedItems[0].Text, SelectedEntity);
                UnlockEntity.Password = password;
                UnlockEntity.ShowDialog();
                RefreshView();
            }
            else
            {
                toolStripButton3.Enabled = false;
            }
            toolStripStatusLabel1.Text = "Selected item : None";




        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ExploreArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExploreArea.SelectedItems.Count == 1)
            {

                toolStripButton3.Enabled = true;
                toolStripDeleteButton.Enabled = true;
                if (ExploreArea.SelectedItems[0].ImageIndex == FOLDER_ICON)
                {
                    toolStripButton3.Text = "Unlock Folder";
                    SelectedEntity = EntityType.Folder;
                    toolStripStatusLabel1.Text = "Selected folder name : " + ExploreArea.SelectedItems[0].Text;
                }
                else
                {
                    toolStripButton3.Text = "Unlock File";
                    SelectedEntity = EntityType.File;
                    toolStripStatusLabel1.Text = "Selected file name : " + ExploreArea.SelectedItems[0].Text;
                }
            }
            else
            {
                toolStripButton3.Enabled = false;
                toolStripDeleteButton.Enabled = false;
                toolStripStatusLabel1.Text = "Selected item : None";
            }
        }

        private void ExploreArea_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void toolStripAddFileButton_Click(object sender, EventArgs e)
        {
            AddEntityDialog AddNewEntity = new AddEntityDialog();
            AddNewEntity.SetEntityType(EntityType.File);
            AddNewEntity.MasterPassword = password;
            AddNewEntity.ShowDialog();
            RefreshView();
        }

        private void toolStripRefreshButton_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void toolStripDeleteButton_Click(object sender, EventArgs e)
        {
            if (ExploreArea.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Are you sure, you want to delete the secured " + SelectedEntity.ToString().ToLower() + " " + ExploreArea.SelectedItems[0].Text + "?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string FileName = ExploreArea.SelectedItems[0].Text;
                    IUISystem UserInterface = new InstantiateElement().CreateNewInstance(ConfigurationSettings.AppSettings["UI"], (ConfigurationSettings.AppSettings["SecureExtension"])) as IUISystem;
                    try
                    {
                        UserInterface.DeleteFile(FileName);
                    }
                    catch (Exception DeleteException)
                    {
                        MessageBox.Show("Deletion failed as a result of the following exception : " + DeleteException.Message);
                    }
                    RefreshView();
                }

            }
            else
            {
                toolStripDeleteButton.Enabled = false;
            }
        }

        private void SecureTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SecureBinHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginAuthenticationProcess Authenticate = new LoginAuthenticationProcess(UsernameText.Text, PasswordText.Text);
            Authenticate.DecryptLogin();
            if (Authenticate.ValidLogin)
            {
                username = UsernameText.Text;
                password = PasswordText.Text;
                AfterAuthentication();
            }
            else
            {
                MessageBox.Show("Authentication process failed", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void toolStripSettingsButton_Click(object sender, EventArgs e)
        {
            SettingsWindow Settings = new SettingsWindow();
            Settings.Username = username;
            Settings.Password = password;
            Settings.ShowDialog();
        }








    }
}

#endregion