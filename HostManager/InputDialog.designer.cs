namespace HostManager
{
    partial class InputDialog
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
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblInputInstructions = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.ipAddress = new IPAddressControlLib.IPAddressControl();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtComments
            // 
            this.txtComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Location = new System.Drawing.Point(12, 108);
            this.txtComments.Margin = new System.Windows.Forms.Padding(4);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(252, 20);
            this.txtComments.TabIndex = 3;
            // 
            // lblInputInstructions
            // 
            this.lblInputInstructions.AutoSize = true;
            this.lblInputInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputInstructions.Location = new System.Drawing.Point(19, 5);
            this.lblInputInstructions.Name = "lblInputInstructions";
            this.lblInputInstructions.Size = new System.Drawing.Size(239, 15);
            this.lblInputInstructions.TabIndex = 1;
            this.lblInputInstructions.Text = "Enter the IP and URL for the new host map";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(189, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(12, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(51, 41);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(17, 13);
            this.lblIpAddress.TabIndex = 4;
            this.lblIpAddress.Text = "IP";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(39, 66);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "URL";
            // 
            // lblComments
            // 
            this.lblComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(12, 94);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(62, 13);
            this.lblComments.TabIndex = 6;
            this.lblComments.Text = "COMMENT";
            // 
            // ipAddress
            // 
            this.ipAddress.AllowInternalTab = true;
            this.ipAddress.AutoHeight = true;
            this.ipAddress.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddress.Location = new System.Drawing.Point(74, 37);
            this.ipAddress.MinimumSize = new System.Drawing.Size(85, 20);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.ReadOnly = false;
            this.ipAddress.Size = new System.Drawing.Size(121, 20);
            this.ipAddress.TabIndex = 1;
            this.ipAddress.Text = "...";
            // 
            // txtUrl
            // 
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrl.Location = new System.Drawing.Point(74, 62);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(189, 20);
            this.txtUrl.TabIndex = 2;
            // 
            // InputDialog
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(276, 169);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblIpAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInputInstructions);
            this.Controls.Add(this.txtComments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new mapping";
            this.Load += new System.EventHandler(this.InputDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblInputInstructions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblComments;
        private IPAddressControlLib.IPAddressControl ipAddress;
        private System.Windows.Forms.TextBox txtUrl;
    }
}