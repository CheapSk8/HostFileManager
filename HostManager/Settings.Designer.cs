namespace HostManager
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.chkPromptPreview = new System.Windows.Forms.CheckBox();
            this.lblSaveLocation = new System.Windows.Forms.Label();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.chkPromptTextSave = new System.Windows.Forms.CheckBox();
            this.pnlSaveLocation = new System.Windows.Forms.Panel();
            this.ddlEditMode = new System.Windows.Forms.ComboBox();
            this.lblEditMode = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tiCheck = new TransparentImageControl();
            this.tiCancel = new TransparentImageControl();
            this.pbSettingsImage = new System.Windows.Forms.PictureBox();
            this.tiSaveLocation = new TransparentImageControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsImage)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPromptPreview
            // 
            this.chkPromptPreview.AutoSize = true;
            this.chkPromptPreview.BackColor = System.Drawing.Color.Transparent;
            this.chkPromptPreview.Location = new System.Drawing.Point(15, 14);
            this.chkPromptPreview.Name = "chkPromptPreview";
            this.chkPromptPreview.Size = new System.Drawing.Size(248, 19);
            this.chkPromptPreview.TabIndex = 1;
            this.chkPromptPreview.Text = "Ask to preview before saving in list mode";
            this.chkPromptPreview.UseVisualStyleBackColor = false;
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.Location = new System.Drawing.Point(15, 130);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(121, 15);
            this.lblSaveLocation.TabIndex = 2;
            this.lblSaveLocation.Text = "Default save location";
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaveLocation.Location = new System.Drawing.Point(19, 158);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.Size = new System.Drawing.Size(210, 14);
            this.txtSaveLocation.TabIndex = 3;
            // 
            // chkPromptTextSave
            // 
            this.chkPromptTextSave.AutoSize = true;
            this.chkPromptTextSave.Location = new System.Drawing.Point(15, 54);
            this.chkPromptTextSave.Name = "chkPromptTextSave";
            this.chkPromptTextSave.Size = new System.Drawing.Size(192, 19);
            this.chkPromptTextSave.TabIndex = 4;
            this.chkPromptTextSave.Text = "Ask before saving in text mode";
            this.chkPromptTextSave.UseVisualStyleBackColor = true;
            // 
            // pnlSaveLocation
            // 
            this.pnlSaveLocation.BackColor = System.Drawing.Color.White;
            this.pnlSaveLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSaveLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlSaveLocation.Location = new System.Drawing.Point(15, 150);
            this.pnlSaveLocation.Name = "pnlSaveLocation";
            this.pnlSaveLocation.Size = new System.Drawing.Size(247, 31);
            this.pnlSaveLocation.TabIndex = 5;
            this.pnlSaveLocation.Click += new System.EventHandler(this.pnlSaveLocation_Click);
            // 
            // ddlEditMode
            // 
            this.ddlEditMode.BackColor = System.Drawing.Color.White;
            this.ddlEditMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlEditMode.FormattingEnabled = true;
            this.ddlEditMode.Location = new System.Drawing.Point(102, 90);
            this.ddlEditMode.Name = "ddlEditMode";
            this.ddlEditMode.Size = new System.Drawing.Size(116, 23);
            this.ddlEditMode.TabIndex = 12;
            // 
            // lblEditMode
            // 
            this.lblEditMode.AutoSize = true;
            this.lblEditMode.Location = new System.Drawing.Point(15, 94);
            this.lblEditMode.Name = "lblEditMode";
            this.lblEditMode.Size = new System.Drawing.Size(81, 15);
            this.lblEditMode.TabIndex = 13;
            this.lblEditMode.Text = "Default mode";
            // 
            // tiCheck
            // 
            this.tiCheck.BackColor = System.Drawing.Color.Transparent;
            this.tiCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tiCheck.HoverImage = global::HostManager.Properties.Resources.Check_24x24;
            this.tiCheck.Image = global::HostManager.Properties.Resources.Check_16x16;
            this.tiCheck.Location = new System.Drawing.Point(357, 0);
            this.tiCheck.Margin = new System.Windows.Forms.Padding(5);
            this.tiCheck.Name = "tiCheck";
            this.tiCheck.Size = new System.Drawing.Size(28, 28);
            this.tiCheck.TabIndex = 11;
            this.tiCheck.ToggleOnHover = true;
            this.tiCheck.Click += new System.EventHandler(this.tiCheck_Click);
            // 
            // tiCancel
            // 
            this.tiCancel.BackColor = System.Drawing.Color.Transparent;
            this.tiCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tiCancel.HoverImage = global::HostManager.Properties.Resources.Cancel_24x24;
            this.tiCancel.Image = global::HostManager.Properties.Resources.Cancel_16x16;
            this.tiCancel.Location = new System.Drawing.Point(357, 160);
            this.tiCancel.Margin = new System.Windows.Forms.Padding(5);
            this.tiCancel.Name = "tiCancel";
            this.tiCancel.Size = new System.Drawing.Size(28, 28);
            this.tiCancel.TabIndex = 10;
            this.tiCancel.ToggleOnHover = true;
            this.tiCancel.Click += new System.EventHandler(this.tiCancel_Click);
            // 
            // pbSettingsImage
            // 
            this.pbSettingsImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSettingsImage.BackColor = System.Drawing.Color.Transparent;
            this.pbSettingsImage.Image = global::HostManager.Properties.Resources.Settings_256x256;
            this.pbSettingsImage.Location = new System.Drawing.Point(224, 33);
            this.pbSettingsImage.Name = "pbSettingsImage";
            this.pbSettingsImage.Size = new System.Drawing.Size(149, 148);
            this.pbSettingsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSettingsImage.TabIndex = 0;
            this.pbSettingsImage.TabStop = false;
            // 
            // tiSaveLocation
            // 
            this.tiSaveLocation.BackColor = System.Drawing.Color.Transparent;
            this.tiSaveLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tiSaveLocation.HoverImage = global::HostManager.Properties.Resources.Open_24x24;
            this.tiSaveLocation.Image = global::HostManager.Properties.Resources.Folder_24x24;
            this.tiSaveLocation.Location = new System.Drawing.Point(234, 153);
            this.tiSaveLocation.Name = "tiSaveLocation";
            this.tiSaveLocation.Size = new System.Drawing.Size(24, 24);
            this.tiSaveLocation.TabIndex = 0;
            this.tiSaveLocation.Text = "transparentImageControl1";
            this.tiSaveLocation.ToggleOnHover = true;
            this.tiSaveLocation.Click += new System.EventHandler(this.tiSaveLocation_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 188);
            this.Controls.Add(this.tiSaveLocation);
            this.Controls.Add(this.lblEditMode);
            this.Controls.Add(this.ddlEditMode);
            this.Controls.Add(this.tiCheck);
            this.Controls.Add(this.tiCancel);
            this.Controls.Add(this.txtSaveLocation);
            this.Controls.Add(this.pnlSaveLocation);
            this.Controls.Add(this.chkPromptTextSave);
            this.Controls.Add(this.lblSaveLocation);
            this.Controls.Add(this.chkPromptPreview);
            this.Controls.Add(this.pbSettingsImage);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSettingsImage;
        private System.Windows.Forms.CheckBox chkPromptPreview;
        private System.Windows.Forms.Label lblSaveLocation;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private System.Windows.Forms.CheckBox chkPromptTextSave;
        private System.Windows.Forms.Panel pnlSaveLocation;
        private TransparentImageControl tiCancel;
        private TransparentImageControl tiCheck;
        private System.Windows.Forms.ComboBox ddlEditMode;
        private System.Windows.Forms.Label lblEditMode;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private TransparentImageControl tiSaveLocation;
    }
}