namespace HostManager
{
    partial class frmHostFileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHostFileManager));
            this.pnlHostsText = new System.Windows.Forms.Panel();
            this.lnkReloadTest = new System.Windows.Forms.LinkLabel();
            this.lnkEditHostList = new System.Windows.Forms.LinkLabel();
            this.txtHostText = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlToolBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHostList = new System.Windows.Forms.Panel();
            this.pbListDel = new System.Windows.Forms.PictureBox();
            this.pbListAdd = new System.Windows.Forms.PictureBox();
            this.lnkReloadList = new System.Windows.Forms.LinkLabel();
            this.lnkEditHostText = new System.Windows.Forms.LinkLabel();
            this.lvMappings = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuLineItemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCommentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUncommentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHostsText.SuspendLayout();
            this.pnlToolBar.SuspendLayout();
            this.pnlHostList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListAdd)).BeginInit();
            this.mnuLineItemMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHostsText
            // 
            this.pnlHostsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHostsText.BackColor = System.Drawing.Color.Transparent;
            this.pnlHostsText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHostsText.Controls.Add(this.lnkReloadTest);
            this.pnlHostsText.Controls.Add(this.lnkEditHostList);
            this.pnlHostsText.Controls.Add(this.txtHostText);
            this.pnlHostsText.Location = new System.Drawing.Point(0, 58);
            this.pnlHostsText.Name = "pnlHostsText";
            this.pnlHostsText.Size = new System.Drawing.Size(525, 448);
            this.pnlHostsText.TabIndex = 7;
            // 
            // lnkReloadTest
            // 
            this.lnkReloadTest.AutoSize = true;
            this.lnkReloadTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkReloadTest.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReloadTest.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkReloadTest.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.lnkReloadTest.Location = new System.Drawing.Point(13, 424);
            this.lnkReloadTest.Name = "lnkReloadTest";
            this.lnkReloadTest.Size = new System.Drawing.Size(122, 14);
            this.lnkReloadTest.TabIndex = 7;
            this.lnkReloadTest.TabStop = true;
            this.lnkReloadTest.Text = "Reload from Host file";
            this.lnkReloadTest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReloadTest_LinkClicked);
            // 
            // lnkEditHostList
            // 
            this.lnkEditHostList.AutoSize = true;
            this.lnkEditHostList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkEditHostList.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEditHostList.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEditHostList.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(153)))), ((int)(((byte)(83)))));
            this.lnkEditHostList.Location = new System.Drawing.Point(390, 424);
            this.lnkEditHostList.Name = "lnkEditHostList";
            this.lnkEditHostList.Size = new System.Drawing.Size(119, 14);
            this.lnkEditHostList.TabIndex = 5;
            this.lnkEditHostList.TabStop = true;
            this.lnkEditHostList.Text = "Edit list of mappings";
            this.lnkEditHostList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditHostList_LinkClicked);
            // 
            // txtHostText
            // 
            this.txtHostText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHostText.BackColor = System.Drawing.Color.AliceBlue;
            this.txtHostText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHostText.Location = new System.Drawing.Point(13, 19);
            this.txtHostText.Multiline = true;
            this.txtHostText.Name = "txtHostText";
            this.txtHostText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHostText.Size = new System.Drawing.Size(496, 402);
            this.txtHostText.TabIndex = 6;
            this.txtHostText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHostText_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(233)))));
            this.pnlToolBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlToolBar.Controls.Add(this.button1);
            this.pnlToolBar.Controls.Add(this.btnSettings);
            this.pnlToolBar.Controls.Add(this.btnExit);
            this.pnlToolBar.Controls.Add(this.btnExport);
            this.pnlToolBar.Controls.Add(this.btnSave);
            this.pnlToolBar.Controls.Add(this.btnImport);
            this.pnlToolBar.ForeColor = System.Drawing.Color.Black;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(525, 58);
            this.pnlToolBar.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSettings.BackgroundImage = global::HostManager.Properties.Resources.Settings_80;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(100)))));
            this.btnSettings.FlatAppearance.BorderSize = 20;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(100)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSettings.Location = new System.Drawing.Point(143, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(45, 50);
            this.btnSettings.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnSettings, "Set Hosts");
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.BackgroundImage = global::HostManager.Properties.Resources.Exit_80;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnExit.FlatAppearance.BorderSize = 6;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(464, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 50);
            this.btnExit.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnExit, "Exit");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExport.BackgroundImage = global::HostManager.Properties.Resources.Export3_80;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnExport.FlatAppearance.BorderSize = 2;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(78, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(45, 50);
            this.btnExport.TabIndex = 9;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnExport, "Export Mappings");
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.BackgroundImage = global::HostManager.Properties.Resources.Save_80;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(100)))));
            this.btnSave.FlatAppearance.BorderSize = 20;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(100)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(33)))));
            this.btnSave.Location = new System.Drawing.Point(399, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 50);
            this.btnSave.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSave, "Save Hosts File");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.DarkOrange;
            this.btnImport.BackgroundImage = global::HostManager.Properties.Resources.Import3b_80;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnImport.FlatAppearance.BorderSize = 2;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(13, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(45, 50);
            this.btnImport.TabIndex = 2;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnImport, "Import Mappings");
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pnlHostList
            // 
            this.pnlHostList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHostList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHostList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHostList.Controls.Add(this.pbListDel);
            this.pnlHostList.Controls.Add(this.pbListAdd);
            this.pnlHostList.Controls.Add(this.lnkReloadList);
            this.pnlHostList.Controls.Add(this.lnkEditHostText);
            this.pnlHostList.Controls.Add(this.lvMappings);
            this.pnlHostList.Location = new System.Drawing.Point(0, 58);
            this.pnlHostList.Name = "pnlHostList";
            this.pnlHostList.Size = new System.Drawing.Size(525, 448);
            this.pnlHostList.TabIndex = 8;
            // 
            // pbListDel
            // 
            this.pbListDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbListDel.Image = global::HostManager.Properties.Resources.Delete_16x16;
            this.pbListDel.Location = new System.Drawing.Point(489, 9);
            this.pbListDel.Name = "pbListDel";
            this.pbListDel.Size = new System.Drawing.Size(20, 22);
            this.pbListDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbListDel.TabIndex = 101;
            this.pbListDel.TabStop = false;
            this.pbListDel.Click += new System.EventHandler(this.pbListDel_Click);
            // 
            // pbListAdd
            // 
            this.pbListAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbListAdd.Image = global::HostManager.Properties.Resources.Add_16x16;
            this.pbListAdd.Location = new System.Drawing.Point(449, 9);
            this.pbListAdd.Name = "pbListAdd";
            this.pbListAdd.Size = new System.Drawing.Size(20, 22);
            this.pbListAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbListAdd.TabIndex = 100;
            this.pbListAdd.TabStop = false;
            this.pbListAdd.Click += new System.EventHandler(this.pbListAdd_Click);
            // 
            // lnkReloadList
            // 
            this.lnkReloadList.AutoSize = true;
            this.lnkReloadList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkReloadList.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReloadList.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkReloadList.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.lnkReloadList.Location = new System.Drawing.Point(13, 424);
            this.lnkReloadList.Name = "lnkReloadList";
            this.lnkReloadList.Size = new System.Drawing.Size(122, 14);
            this.lnkReloadList.TabIndex = 6;
            this.lnkReloadList.TabStop = true;
            this.lnkReloadList.Text = "Reload from Host file";
            this.lnkReloadList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReloadList_LinkClicked);
            // 
            // lnkEditHostText
            // 
            this.lnkEditHostText.AutoSize = true;
            this.lnkEditHostText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkEditHostText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEditHostText.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEditHostText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(153)))), ((int)(((byte)(83)))));
            this.lnkEditHostText.Location = new System.Drawing.Point(378, 424);
            this.lnkEditHostText.Name = "lnkEditHostText";
            this.lnkEditHostText.Size = new System.Drawing.Size(131, 14);
            this.lnkEditHostText.TabIndex = 5;
            this.lnkEditHostText.TabStop = true;
            this.lnkEditHostText.Text = "Edit hosts as plain text";
            this.lnkEditHostText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditHostText_LinkClicked);
            // 
            // lvMappings
            // 
            this.lvMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMappings.BackColor = System.Drawing.Color.Honeydew;
            this.lvMappings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMappings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMappings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvMappings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMappings.FullRowSelect = true;
            this.lvMappings.GridLines = true;
            this.lvMappings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMappings.Location = new System.Drawing.Point(13, 32);
            this.lvMappings.Name = "lvMappings";
            this.lvMappings.Size = new System.Drawing.Size(496, 387);
            this.lvMappings.TabIndex = 4;
            this.lvMappings.UseCompatibleStateImageBehavior = false;
            this.lvMappings.View = System.Windows.Forms.View.Details;
            this.lvMappings.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.lvMappings_ItemMouseHover);
            this.lvMappings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvMappings_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Domain or URL";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Notes";
            // 
            // mnuLineItemMenu
            // 
            this.mnuLineItemMenu.BackColor = System.Drawing.Color.Lavender;
            this.mnuLineItemMenu.Font = new System.Drawing.Font("Verdana", 8F);
            this.mnuLineItemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCommentItem,
            this.mnuUncommentItem,
            this.mnuAddItem,
            this.mnuEditItem});
            this.mnuLineItemMenu.Name = "mnuLineItemMenu";
            this.mnuLineItemMenu.ShowImageMargin = false;
            this.mnuLineItemMenu.Size = new System.Drawing.Size(185, 92);
            // 
            // mnuCommentItem
            // 
            this.mnuCommentItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuCommentItem.Name = "mnuCommentItem";
            this.mnuCommentItem.Size = new System.Drawing.Size(184, 22);
            this.mnuCommentItem.Text = "Comment Mapping(s)";
            this.mnuCommentItem.Click += new System.EventHandler(this.mnuCommentItem_Click);
            // 
            // mnuUncommentItem
            // 
            this.mnuUncommentItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuUncommentItem.Name = "mnuUncommentItem";
            this.mnuUncommentItem.Size = new System.Drawing.Size(184, 22);
            this.mnuUncommentItem.Text = "Uncomment Mapping(s)";
            this.mnuUncommentItem.Click += new System.EventHandler(this.mnuUncommentItem_Click);
            // 
            // mnuAddItem
            // 
            this.mnuAddItem.Name = "mnuAddItem";
            this.mnuAddItem.Size = new System.Drawing.Size(184, 22);
            this.mnuAddItem.Text = "Add Item";
            this.mnuAddItem.Click += new System.EventHandler(this.mnuAddItem_Click);
            // 
            // mnuEditItem
            // 
            this.mnuEditItem.Name = "mnuEditItem";
            this.mnuEditItem.Size = new System.Drawing.Size(184, 22);
            this.mnuEditItem.Text = "Edit Item";
            this.mnuEditItem.Click += new System.EventHandler(this.mnuEditItem_Click);
            // 
            // frmHostFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(525, 509);
            this.Controls.Add(this.pnlToolBar);
            this.Controls.Add(this.pnlHostList);
            this.Controls.Add(this.pnlHostsText);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHostFileManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Host File Manager";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmHostFileManager_Load);
            this.pnlHostsText.ResumeLayout(false);
            this.pnlHostsText.PerformLayout();
            this.pnlToolBar.ResumeLayout(false);
            this.pnlHostList.ResumeLayout(false);
            this.pnlHostList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListAdd)).EndInit();
            this.mnuLineItemMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlHostsText;
        private System.Windows.Forms.LinkLabel lnkEditHostList;
        private System.Windows.Forms.TextBox txtHostText;
        private System.Windows.Forms.Panel pnlHostList;
        private System.Windows.Forms.LinkLabel lnkEditHostText;
        private System.Windows.Forms.ListView lvMappings;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.LinkLabel lnkReloadList;
        private System.Windows.Forms.PictureBox pbListDel;
        private System.Windows.Forms.PictureBox pbListAdd;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel lnkReloadTest;
        private System.Windows.Forms.Panel pnlToolBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ContextMenuStrip mnuLineItemMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuCommentItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUncommentItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEditItem;
        private System.Windows.Forms.Button button1;
    }
}

