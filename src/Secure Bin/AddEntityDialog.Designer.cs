#region Author : Aron Sajan Philip
namespace Secure_Bin
{
    partial class AddEntityDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ConfirmPasswordText = new System.Windows.Forms.TextBox();
            this.MasterPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.TargetEntitytext = new System.Windows.Forms.TextBox();
            this.TargetEntitylabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LockButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProgressIndicatorText = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.ContextImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Secure entity";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 200);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ConfirmPasswordText);
            this.tabPage1.Controls.Add(this.MasterPasswordCheckbox);
            this.tabPage1.Controls.Add(this.ConfirmPasswordLabel);
            this.tabPage1.Controls.Add(this.PasswordText);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BrowseButton);
            this.tabPage1.Controls.Add(this.TargetEntitytext);
            this.tabPage1.Controls.Add(this.TargetEntitylabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(445, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Secure parameters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ConfirmPasswordText
            // 
            this.ConfirmPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPasswordText.Location = new System.Drawing.Point(102, 137);
            this.ConfirmPasswordText.Name = "ConfirmPasswordText";
            this.ConfirmPasswordText.Size = new System.Drawing.Size(227, 20);
            this.ConfirmPasswordText.TabIndex = 7;
            this.ConfirmPasswordText.UseSystemPasswordChar = true;
            // 
            // MasterPasswordCheckbox
            // 
            this.MasterPasswordCheckbox.AutoSize = true;
            this.MasterPasswordCheckbox.Location = new System.Drawing.Point(11, 68);
            this.MasterPasswordCheckbox.Name = "MasterPasswordCheckbox";
            this.MasterPasswordCheckbox.Size = new System.Drawing.Size(127, 17);
            this.MasterPasswordCheckbox.TabIndex = 6;
            this.MasterPasswordCheckbox.Text = "Use master password";
            this.MasterPasswordCheckbox.UseVisualStyleBackColor = true;
            this.MasterPasswordCheckbox.CheckedChanged += new System.EventHandler(this.MasterPasswordCheckbox_CheckedChanged);
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(8, 140);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(90, 13);
            this.ConfirmPasswordLabel.TabIndex = 5;
            this.ConfirmPasswordLabel.Text = "Confirm password";
            // 
            // PasswordText
            // 
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordText.Location = new System.Drawing.Point(102, 104);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(227, 20);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(400, 30);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(24, 24);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // TargetEntitytext
            // 
            this.TargetEntitytext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TargetEntitytext.Location = new System.Drawing.Point(102, 32);
            this.TargetEntitytext.Name = "TargetEntitytext";
            this.TargetEntitytext.ReadOnly = true;
            this.TargetEntitytext.Size = new System.Drawing.Size(292, 20);
            this.TargetEntitytext.TabIndex = 1;
            // 
            // TargetEntitylabel
            // 
            this.TargetEntitylabel.AutoSize = true;
            this.TargetEntitylabel.Location = new System.Drawing.Point(8, 34);
            this.TargetEntitylabel.Name = "TargetEntitylabel";
            this.TargetEntitylabel.Size = new System.Drawing.Size(70, 13);
            this.TargetEntitylabel.TabIndex = 0;
            this.TargetEntitylabel.Text = "Target Folder";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 1);
            this.panel1.TabIndex = 4;
            // 
            // LockButton
            // 
            this.LockButton.Location = new System.Drawing.Point(314, 323);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(75, 27);
            this.LockButton.TabIndex = 5;
            this.LockButton.Text = "Lock";
            this.LockButton.UseVisualStyleBackColor = true;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ProgressIndicatorText);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 249);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // ProgressIndicatorText
            // 
            this.ProgressIndicatorText.AutoSize = true;
            this.ProgressIndicatorText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressIndicatorText.Location = new System.Drawing.Point(151, 104);
            this.ProgressIndicatorText.Name = "ProgressIndicatorText";
            this.ProgressIndicatorText.Size = new System.Drawing.Size(178, 16);
            this.ProgressIndicatorText.TabIndex = 1;
            this.ProgressIndicatorText.Text = "Securing entity, please wait...";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Secure_Bin.Properties.Resources.loading29;
            this.pictureBox3.Location = new System.Drawing.Point(225, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(391, 323);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(76, 27);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // ContextImage
            // 
            this.ContextImage.BackColor = System.Drawing.Color.SteelBlue;
            this.ContextImage.Location = new System.Drawing.Point(6, 2);
            this.ContextImage.Name = "ContextImage";
            this.ContextImage.Size = new System.Drawing.Size(58, 61);
            this.ContextImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ContextImage.TabIndex = 8;
            this.ContextImage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(104)))), ((int)(((byte)(145)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(481, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddEntityDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 364);
            this.Controls.Add(this.ContextImage);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.LockButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEntityDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Entity Dialog";
            this.Load += new System.EventHandler(this.AddEntityDialog_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEntityDialog_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox TargetEntitytext;
        private System.Windows.Forms.Label TargetEntitylabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LockButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label ProgressIndicatorText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.PictureBox ContextImage;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.CheckBox MasterPasswordCheckbox;
        private System.Windows.Forms.TextBox ConfirmPasswordText;
    }
} 
#endregion