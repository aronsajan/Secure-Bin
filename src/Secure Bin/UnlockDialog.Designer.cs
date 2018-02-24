#region Author : Aron Sajan Philip
namespace Secure_Bin
{
    partial class UnlockDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UnlockButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UnlockDialogLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EntityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EntityNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextUnlockDest = new System.Windows.Forms.TextBox();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UseMasterPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UnlockProgressText = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(-2, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 1);
            this.panel1.TabIndex = 1;
            // 
            // UnlockButton
            // 
            this.UnlockButton.Location = new System.Drawing.Point(358, 394);
            this.UnlockButton.Name = "UnlockButton";
            this.UnlockButton.Size = new System.Drawing.Size(75, 27);
            this.UnlockButton.TabIndex = 2;
            this.UnlockButton.Text = "Unlock";
            this.UnlockButton.UseVisualStyleBackColor = true;
            this.UnlockButton.Click += new System.EventHandler(this.UnlockButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UnlockDialogLabel
            // 
            this.UnlockDialogLabel.AutoSize = true;
            this.UnlockDialogLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.UnlockDialogLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockDialogLabel.ForeColor = System.Drawing.Color.White;
            this.UnlockDialogLabel.Location = new System.Drawing.Point(64, 18);
            this.UnlockDialogLabel.Name = "UnlockDialogLabel";
            this.UnlockDialogLabel.Size = new System.Drawing.Size(117, 23);
            this.UnlockDialogLabel.TabIndex = 4;
            this.UnlockDialogLabel.Text = "Unlock entity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entity Type : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EntityLabel
            // 
            this.EntityLabel.AutoSize = true;
            this.EntityLabel.Location = new System.Drawing.Point(100, 53);
            this.EntityLabel.Name = "EntityLabel";
            this.EntityLabel.Size = new System.Drawing.Size(13, 13);
            this.EntityLabel.TabIndex = 6;
            this.EntityLabel.Text = "1";
            this.EntityLabel.Click += new System.EventHandler(this.EntityLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Entity Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EntityNameLabel
            // 
            this.EntityNameLabel.AutoSize = true;
            this.EntityNameLabel.Location = new System.Drawing.Point(100, 81);
            this.EntityNameLabel.Name = "EntityNameLabel";
            this.EntityNameLabel.Size = new System.Drawing.Size(13, 13);
            this.EntityNameLabel.TabIndex = 8;
            this.EntityNameLabel.Text = "2";
            this.EntityNameLabel.Click += new System.EventHandler(this.EntityNameLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password ";
            // 
            // TextPassword
            // 
            this.TextPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextPassword.Location = new System.Drawing.Point(127, 215);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(305, 20);
            this.TextPassword.TabIndex = 2;
            this.TextPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unlock Destination";
            // 
            // TextUnlockDest
            // 
            this.TextUnlockDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextUnlockDest.Location = new System.Drawing.Point(127, 159);
            this.TextUnlockDest.Name = "TextUnlockDest";
            this.TextUnlockDest.ReadOnly = true;
            this.TextUnlockDest.Size = new System.Drawing.Size(305, 20);
            this.TextUnlockDest.TabIndex = 12;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBrowse.Location = new System.Drawing.Point(438, 156);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(24, 24);
            this.ButtonBrowse.TabIndex = 0;
            this.ButtonBrowse.Text = "...";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 299);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UseMasterPasswordCheckbox);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ButtonBrowse);
            this.tabPage1.Controls.Add(this.TextUnlockDest);
            this.tabPage1.Controls.Add(this.EntityLabel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TextPassword);
            this.tabPage1.Controls.Add(this.EntityNameLabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unlock options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UseMasterPasswordCheckbox
            // 
            this.UseMasterPasswordCheckbox.AutoSize = true;
            this.UseMasterPasswordCheckbox.Location = new System.Drawing.Point(27, 187);
            this.UseMasterPasswordCheckbox.Name = "UseMasterPasswordCheckbox";
            this.UseMasterPasswordCheckbox.Size = new System.Drawing.Size(127, 17);
            this.UseMasterPasswordCheckbox.TabIndex = 20;
            this.UseMasterPasswordCheckbox.Text = "Use master password";
            this.UseMasterPasswordCheckbox.UseVisualStyleBackColor = true;
            this.UseMasterPasswordCheckbox.CheckedChanged += new System.EventHandler(this.UseMasterPasswordCheckbox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(20, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 1);
            this.panel3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Unlock parameters";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(20, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 1);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Entity information";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.UnlockProgressText);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(1, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(526, 323);
            this.panel4.TabIndex = 21;
            this.panel4.Visible = false;
            // 
            // UnlockProgressText
            // 
            this.UnlockProgressText.AutoSize = true;
            this.UnlockProgressText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockProgressText.Location = new System.Drawing.Point(172, 144);
            this.UnlockProgressText.Name = "UnlockProgressText";
            this.UnlockProgressText.Size = new System.Drawing.Size(182, 16);
            this.UnlockProgressText.TabIndex = 1;
            this.UnlockProgressText.Text = "Unlocking entity, please wait...";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Secure_Bin.Properties.Resources.loading29;
            this.pictureBox4.Location = new System.Drawing.Point(248, 101);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Image = global::Secure_Bin.Properties.Resources.unlock;
            this.pictureBox3.Location = new System.Drawing.Point(9, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(104)))), ((int)(((byte)(145)))));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(528, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UnlockDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 435);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UnlockDialogLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UnlockButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnlockDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unlock Dialog";
            this.Load += new System.EventHandler(this.UnlockDialog_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnlockDialog_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UnlockButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label UnlockDialogLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EntityLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EntityNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextUnlockDest;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label UnlockProgressText;
        private System.Windows.Forms.CheckBox UseMasterPasswordCheckbox;
    }
} 
#endregion