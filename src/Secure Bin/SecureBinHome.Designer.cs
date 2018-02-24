#region Author : Aron Sajan Philip
namespace Secure_Bin
{
    partial class SecureBinHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecureBinHome));
            this.label1 = new System.Windows.Forms.Label();
            this.SecureTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripAddFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripRefreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSettingsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ExploreArea = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.IconImages = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SecureTools.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secure Bin";
            // 
            // SecureTools
            // 
            this.SecureTools.AutoSize = false;
            this.SecureTools.Dock = System.Windows.Forms.DockStyle.None;
            this.SecureTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddFolder,
            this.toolStripAddFileButton,
            this.toolStripButton3,
            this.toolStripDeleteButton,
            this.toolStripRefreshButton,
            this.toolStripSettingsButton,
            this.toolStripButton4,
            this.toolStripButton5});
            this.SecureTools.Location = new System.Drawing.Point(-1, 65);
            this.SecureTools.Name = "SecureTools";
            this.SecureTools.Size = new System.Drawing.Size(983, 25);
            this.SecureTools.TabIndex = 2;
            this.SecureTools.Text = "toolStrip1";
            this.SecureTools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SecureTools_ItemClicked);
            // 
            // toolStripButtonAddFolder
            // 
            this.toolStripButtonAddFolder.Image = global::Secure_Bin.Properties.Resources.add_folder;
            this.toolStripButtonAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddFolder.Name = "toolStripButtonAddFolder";
            this.toolStripButtonAddFolder.Size = new System.Drawing.Size(85, 22);
            this.toolStripButtonAddFolder.Text = "Add Folder";
            this.toolStripButtonAddFolder.Click += new System.EventHandler(this.toolStripButtonAddFolder_Click);
            // 
            // toolStripAddFileButton
            // 
            this.toolStripAddFileButton.Image = global::Secure_Bin.Properties.Resources._13254;
            this.toolStripAddFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddFileButton.Name = "toolStripAddFileButton";
            this.toolStripAddFileButton.Size = new System.Drawing.Size(70, 22);
            this.toolStripAddFileButton.Text = "Add File";
            this.toolStripAddFileButton.Click += new System.EventHandler(this.toolStripAddFileButton_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = global::Secure_Bin.Properties.Resources.unlocked;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton3.Text = "Unlock";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripDeleteButton
            // 
            this.toolStripDeleteButton.Enabled = false;
            this.toolStripDeleteButton.Image = global::Secure_Bin.Properties.Resources._1334298137_DeleteRed;
            this.toolStripDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteButton.Name = "toolStripDeleteButton";
            this.toolStripDeleteButton.Size = new System.Drawing.Size(60, 22);
            this.toolStripDeleteButton.Text = "Delete";
            this.toolStripDeleteButton.Click += new System.EventHandler(this.toolStripDeleteButton_Click);
            // 
            // toolStripRefreshButton
            // 
            this.toolStripRefreshButton.Image = global::Secure_Bin.Properties.Resources._1334297753_old_view_refresh;
            this.toolStripRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefreshButton.Name = "toolStripRefreshButton";
            this.toolStripRefreshButton.Size = new System.Drawing.Size(94, 22);
            this.toolStripRefreshButton.Text = "Refresh View";
            this.toolStripRefreshButton.Click += new System.EventHandler(this.toolStripRefreshButton_Click);
            // 
            // toolStripSettingsButton
            // 
            this.toolStripSettingsButton.Image = global::Secure_Bin.Properties.Resources.HP_Control;
            this.toolStripSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSettingsButton.Name = "toolStripSettingsButton";
            this.toolStripSettingsButton.Size = new System.Drawing.Size(69, 22);
            this.toolStripSettingsButton.Text = "Settings";
            this.toolStripSettingsButton.Click += new System.EventHandler(this.toolStripSettingsButton_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Secure_Bin.Properties.Resources.Windows_7__80_;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton4.Text = "About";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::Secure_Bin.Properties.Resources.Shutdown_Box_Red;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(45, 22);
            this.toolStripButton5.Text = "Exit";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // ExploreArea
            // 
            this.ExploreArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExploreArea.Location = new System.Drawing.Point(0, 92);
            this.ExploreArea.Name = "ExploreArea";
            this.ExploreArea.Size = new System.Drawing.Size(980, 498);
            this.ExploreArea.TabIndex = 3;
            this.ExploreArea.UseCompatibleStateImageBehavior = false;
            this.ExploreArea.SelectedIndexChanged += new System.EventHandler(this.ExploreArea_SelectedIndexChanged);
            this.ExploreArea.DoubleClick += new System.EventHandler(this.toolStripButton3_Click);
            this.ExploreArea.Click += new System.EventHandler(this.ExploreArea_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel1.Text = "Selected item : None";
            // 
            // IconImages
            // 
            this.IconImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImages.ImageStream")));
            this.IconImages.TransparentColor = System.Drawing.Color.Transparent;
            this.IconImages.Images.SetKeyName(0, "file_locked.png");
            this.IconImages.Images.SetKeyName(1, "Lock_Folder.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PasswordText);
            this.panel1.Controls.Add(this.UsernameText);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 500);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(245, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(245, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 1);
            this.panel2.TabIndex = 5;
            // 
            // PasswordText
            // 
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordText.Location = new System.Drawing.Point(392, 186);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(237, 20);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // UsernameText
            // 
            this.UsernameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameText.Location = new System.Drawing.Point(392, 154);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(237, 20);
            this.UsernameText.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(454, 229);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 27);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(320, 187);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(63, 16);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(320, 155);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(66, 16);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.pictureBox1.Image = global::Secure_Bin.Properties.Resources._1334204134_shield_protection_blue;
            this.pictureBox1.Location = new System.Drawing.Point(9, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(96)))), ((int)(((byte)(117)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(982, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(982, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // SecureBinHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 615);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SecureTools);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExploreArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SecureBinHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Bin - Version :";
            this.Load += new System.EventHandler(this.SecureBinHome_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecureBinHome_FormClosed);
            this.Resize += new System.EventHandler(this.SecureBinHome_Resize);
            this.LocationChanged += new System.EventHandler(this.SecureBinHome_LocationChanged);
            this.SecureTools.ResumeLayout(false);
            this.SecureTools.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip SecureTools;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddFolder;
        private System.Windows.Forms.ToolStripButton toolStripAddFileButton;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ListView ExploreArea;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList IconImages;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolStripRefreshButton;
        private System.Windows.Forms.ToolStripButton toolStripDeleteButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.ToolStripButton toolStripSettingsButton;
    }
}


#endregion