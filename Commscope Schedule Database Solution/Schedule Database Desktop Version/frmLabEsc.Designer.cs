using System;

namespace Schedule_Database_Desktop_Version
{
    partial class frmLabEsc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLabEsc));
            this.txtRecordID = new System.Windows.Forms.TextBox();
            this.cboMSO = new System.Windows.Forms.ComboBox();
            this.cboSeverity = new System.Windows.Forms.ComboBox();
            this.txtEndUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEscNum = new System.Windows.Forms.TextBox();
            this.txtPSNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.cboRequestor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpClosedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEntryAdmin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboLead = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.rtxDescription = new System.Windows.Forms.RichTextBox();
            this.rtxComments = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCTRNum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvAttachments = new System.Windows.Forms.DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.btnRemoveAttach = new System.Windows.Forms.Button();
            this.btnAddAttach = new System.Windows.Forms.Button();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboRecType = new System.Windows.Forms.ComboBox();
            this.lblRecordType = new System.Windows.Forms.Label();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.cboApplication = new System.Windows.Forms.ComboBox();
            this.lblArch = new System.Windows.Forms.Label();
            this.cboArchitecture = new System.Windows.Forms.ComboBox();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ckFilter = new System.Windows.Forms.CheckBox();
            this.dtpContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
            this.tlpLeft.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRecordID
            // 
            this.txtRecordID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtRecordID.Location = new System.Drawing.Point(459, 21);
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.ReadOnly = true;
            this.txtRecordID.Size = new System.Drawing.Size(396, 22);
            this.txtRecordID.TabIndex = 200;
            this.txtRecordID.TabStop = false;
            this.txtRecordID.Tag = "EscID";
            this.txtRecordID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboMSO
            // 
            this.cboMSO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboMSO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMSO.BackColor = System.Drawing.Color.Gold;
            this.cboMSO.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboMSO.FormattingEnabled = true;
            this.cboMSO.Location = new System.Drawing.Point(133, 35);
            this.cboMSO.Name = "cboMSO";
            this.cboMSO.Size = new System.Drawing.Size(271, 26);
            this.cboMSO.TabIndex = 0;
            this.cboMSO.Tag = "MSO";
            this.cboMSO.SelectedIndexChanged += new System.EventHandler(this.cboMSO_SelectedIndexChanged);
            // 
            // cboSeverity
            // 
            this.cboSeverity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSeverity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSeverity.BackColor = System.Drawing.Color.Gold;
            this.cboSeverity.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboSeverity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboSeverity.FormattingEnabled = true;
            this.cboSeverity.Location = new System.Drawing.Point(133, 195);
            this.cboSeverity.Name = "cboSeverity";
            this.cboSeverity.Size = new System.Drawing.Size(271, 26);
            this.cboSeverity.TabIndex = 5;
            this.cboSeverity.Tag = "Severity";
            this.cboSeverity.SelectedIndexChanged += new System.EventHandler(this.cboSeverity_SelectedIndexChanged);
            this.cboSeverity.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // txtEndUser
            // 
            this.txtEndUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEndUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEndUser.Location = new System.Drawing.Point(133, 67);
            this.txtEndUser.Name = "txtEndUser";
            this.txtEndUser.Size = new System.Drawing.Size(271, 24);
            this.txtEndUser.TabIndex = 1;
            this.txtEndUser.Tag = "EndUser";
            this.txtEndUser.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 200;
            this.label1.Text = "MSO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(3, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 200;
            this.label2.Text = "State";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 200;
            this.label3.Text = "City";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 200;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(3, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 27);
            this.label5.TabIndex = 200;
            this.label5.Text = "End User";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(3, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 200;
            this.label6.Text = "Country";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(3, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 200;
            this.label7.Text = "Severity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEscNum
            // 
            this.txtEscNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEscNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEscNum.Location = new System.Drawing.Point(133, 451);
            this.txtEscNum.Name = "txtEscNum";
            this.txtEscNum.Size = new System.Drawing.Size(271, 24);
            this.txtEscNum.TabIndex = 13;
            this.txtEscNum.Tag = "EscNum";
            this.txtEscNum.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // txtPSNum
            // 
            this.txtPSNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPSNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPSNum.Location = new System.Drawing.Point(133, 387);
            this.txtPSNum.Name = "txtPSNum";
            this.txtPSNum.Size = new System.Drawing.Size(271, 24);
            this.txtPSNum.TabIndex = 11;
            this.txtPSNum.Tag = "PSNumber";
            this.txtPSNum.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(3, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 27);
            this.label8.TabIndex = 200;
            this.label8.Text = "CTR Number";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(3, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 27);
            this.label9.TabIndex = 200;
            this.label9.Text = "Requestor";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCountry
            // 
            this.cboCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(133, 163);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(271, 26);
            this.cboCountry.TabIndex = 4;
            this.cboCountry.Tag = "Country";
            this.cboCountry.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // cboState
            // 
            this.cboState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboState.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(133, 131);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(271, 26);
            this.cboState.TabIndex = 3;
            this.cboState.Tag = "State";
            this.cboState.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // cboRequestor
            // 
            this.cboRequestor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboRequestor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRequestor.BackColor = System.Drawing.Color.Gold;
            this.cboRequestor.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboRequestor.FormattingEnabled = true;
            this.cboRequestor.Location = new System.Drawing.Point(133, 227);
            this.cboRequestor.Name = "cboRequestor";
            this.cboRequestor.Size = new System.Drawing.Size(271, 26);
            this.cboRequestor.TabIndex = 6;
            this.cboRequestor.Tag = "Requestor";
            this.cboRequestor.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            this.cboRequestor.Leave += new System.EventHandler(this.cboRequestor_Leave);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(3, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 27);
            this.label10.TabIndex = 21;
            this.label10.Text = "Esc Number";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.ContextMenuStrip = this.dtpContextMenu;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpStartDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpStartDate.Location = new System.Drawing.Point(133, 515);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpStartDate.Size = new System.Drawing.Size(270, 24);
            this.dtpStartDate.TabIndex = 14;
            this.dtpStartDate.Tag = "DateOpened";
            this.dtpStartDate.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpContextMenu
            // 
            this.dtpContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dtpContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDateToolStripMenuItem});
            this.dtpContextMenu.Name = "dtpContextMenu";
            this.dtpContextMenu.Size = new System.Drawing.Size(129, 26);
            // 
            // clearDateToolStripMenuItem
            // 
            this.clearDateToolStripMenuItem.Name = "clearDateToolStripMenuItem";
            this.clearDateToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clearDateToolStripMenuItem.Text = "Clear Date";
            this.clearDateToolStripMenuItem.Click += new System.EventHandler(this.clearDateToolStripMenuItem_Click);
            // 
            // dtpClosedDate
            // 
            this.dtpClosedDate.ContextMenuStrip = this.dtpContextMenu;
            this.dtpClosedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpClosedDate.Location = new System.Drawing.Point(133, 579);
            this.dtpClosedDate.Name = "dtpClosedDate";
            this.dtpClosedDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpClosedDate.Size = new System.Drawing.Size(270, 24);
            this.dtpClosedDate.TabIndex = 16;
            this.dtpClosedDate.Tag = "DateCompleted";
            this.dtpClosedDate.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            this.dtpClosedDate.ValueChanged += new System.EventHandler(this.dtpClosedDate_ValueChanged);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.ContextMenuStrip = this.dtpContextMenu;
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpDueDate.Location = new System.Drawing.Point(133, 547);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDueDate.Size = new System.Drawing.Size(270, 24);
            this.dtpDueDate.TabIndex = 15;
            this.dtpDueDate.Tag = "DueDate";
            this.dtpDueDate.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(3, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 27);
            this.label12.TabIndex = 28;
            this.label12.Text = "Date Closed";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(3, 549);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 27);
            this.label13.TabIndex = 29;
            this.label13.Text = "Due Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(3, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 27);
            this.label14.TabIndex = 30;
            this.label14.Text = "Date Opened";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEntryAdmin
            // 
            this.txtEntryAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntryAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEntryAdmin.Location = new System.Drawing.Point(134, 611);
            this.txtEntryAdmin.Name = "txtEntryAdmin";
            this.txtEntryAdmin.Size = new System.Drawing.Size(270, 24);
            this.txtEntryAdmin.TabIndex = 7;
            this.txtEntryAdmin.TabStop = false;
            this.txtEntryAdmin.Tag = "EntryAdmin";
            this.txtEntryAdmin.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(3, 613);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 27);
            this.label15.TabIndex = 32;
            this.label15.Text = "Entry Admin";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(3, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 27);
            this.label16.TabIndex = 33;
            this.label16.Text = "Lead";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label17.Location = new System.Drawing.Point(456, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Product(s)";
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(3, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 27);
            this.label18.TabIndex = 35;
            this.label18.Text = "Quantity";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Location = new System.Drawing.Point(3, 293);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 27);
            this.label19.TabIndex = 36;
            this.label19.Text = "Status";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(903, 306);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(174, 20);
            this.label20.TabIndex = 37;
            this.label20.Text = "Comments / Resolution";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(903, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 20);
            this.label21.TabIndex = 38;
            this.label21.Text = "Description";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label22.Location = new System.Drawing.Point(904, 614);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 18);
            this.label22.TabIndex = 39;
            this.label22.Text = "Resolution Type";
            // 
            // cboStatus
            // 
            this.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(133, 291);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(271, 26);
            this.cboStatus.TabIndex = 8;
            this.cboStatus.Tag = "Status";
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            this.cboStatus.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // cboLead
            // 
            this.cboLead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboLead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLead.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboLead.FormattingEnabled = true;
            this.cboLead.Location = new System.Drawing.Point(133, 323);
            this.cboLead.Name = "cboLead";
            this.cboLead.Size = new System.Drawing.Size(271, 26);
            this.cboLead.TabIndex = 9;
            this.cboLead.Tag = "LeadAssigned";
            this.cboLead.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            this.cboLead.Leave += new System.EventHandler(this.cboLead_Leave);
            // 
            // txtQty
            // 
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtQty.Location = new System.Drawing.Point(133, 355);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(271, 24);
            this.txtQty.TabIndex = 10;
            this.txtQty.Tag = "Quantity";
            this.txtQty.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // lstProducts
            // 
            this.lstProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 18;
            this.lstProducts.Location = new System.Drawing.Point(439, 79);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(437, 202);
            this.lstProducts.TabIndex = 17;
            this.lstProducts.Tag = "Product";
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // rtxDescription
            // 
            this.rtxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rtxDescription.Location = new System.Drawing.Point(899, 33);
            this.rtxDescription.Name = "rtxDescription";
            this.rtxDescription.Size = new System.Drawing.Size(470, 259);
            this.rtxDescription.TabIndex = 45;
            this.rtxDescription.Tag = "Description";
            this.rtxDescription.Text = "";
            this.rtxDescription.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            this.rtxDescription.Enter += new System.EventHandler(this.rtxDescription_Enter);
            this.rtxDescription.Leave += new System.EventHandler(this.rtxDescription_Leave);
            // 
            // rtxComments
            // 
            this.rtxComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rtxComments.Location = new System.Drawing.Point(899, 326);
            this.rtxComments.Name = "rtxComments";
            this.rtxComments.Size = new System.Drawing.Size(470, 284);
            this.rtxComments.TabIndex = 46;
            this.rtxComments.Tag = "Comments";
            this.rtxComments.Text = "";
            this.rtxComments.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            this.rtxComments.Enter += new System.EventHandler(this.rtxComments_Enter);
            this.rtxComments.Leave += new System.EventHandler(this.rtxComments_Leave);
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label23.Location = new System.Drawing.Point(3, 389);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(124, 27);
            this.label23.TabIndex = 52;
            this.label23.Text = "365 Number";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCTRNum
            // 
            this.txtCTRNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCTRNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCTRNum.Location = new System.Drawing.Point(133, 419);
            this.txtCTRNum.Name = "txtCTRNum";
            this.txtCTRNum.Size = new System.Drawing.Size(271, 24);
            this.txtCTRNum.TabIndex = 12;
            this.txtCTRNum.Tag = "CTRNum";
            this.txtCTRNum.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(1006, 684);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 45);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(1202, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 45);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvAttachments
            // 
            this.dgvAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttachments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttachments.Location = new System.Drawing.Point(439, 337);
            this.dgvAttachments.Name = "dgvAttachments";
            this.dgvAttachments.RowHeadersWidth = 62;
            this.dgvAttachments.Size = new System.Drawing.Size(437, 243);
            this.dgvAttachments.TabIndex = 18;
            this.dgvAttachments.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttachments_RowHeaderMouseClick);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label24.Location = new System.Drawing.Point(454, 314);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 18);
            this.label24.TabIndex = 56;
            this.label24.Text = "Attachments";
            // 
            // btnRemoveAttach
            // 
            this.btnRemoveAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAttach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRemoveAttach.Location = new System.Drawing.Point(679, 586);
            this.btnRemoveAttach.Name = "btnRemoveAttach";
            this.btnRemoveAttach.Size = new System.Drawing.Size(136, 29);
            this.btnRemoveAttach.TabIndex = 58;
            this.btnRemoveAttach.Text = "Remove";
            this.btnRemoveAttach.UseVisualStyleBackColor = true;
            this.btnRemoveAttach.Click += new System.EventHandler(this.btnRemoveAttach_Click);
            // 
            // btnAddAttach
            // 
            this.btnAddAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAttach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAddAttach.Location = new System.Drawing.Point(502, 586);
            this.btnAddAttach.Name = "btnAddAttach";
            this.btnAddAttach.Size = new System.Drawing.Size(136, 29);
            this.btnAddAttach.TabIndex = 57;
            this.btnAddAttach.Text = "Add";
            this.btnAddAttach.UseVisualStyleBackColor = true;
            this.btnAddAttach.Click += new System.EventHandler(this.btnAddAttach_Click);
            // 
            // cboCity
            // 
            this.cboCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCity.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(133, 99);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(271, 26);
            this.cboCity.TabIndex = 2;
            this.cboCity.Tag = "City";
            this.cboCity.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // cboResolution
            // 
            this.cboResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Location = new System.Drawing.Point(899, 635);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(470, 26);
            this.cboResolution.TabIndex = 61;
            this.cboResolution.Tag = "Resolution";
            this.cboResolution.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtID.Location = new System.Drawing.Point(56, 694);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(64, 24);
            this.txtID.TabIndex = 63;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // cboRecType
            // 
            this.cboRecType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboRecType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRecType.BackColor = System.Drawing.Color.Gold;
            this.cboRecType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboRecType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboRecType.FormattingEnabled = true;
            this.cboRecType.Location = new System.Drawing.Point(133, 3);
            this.cboRecType.Name = "cboRecType";
            this.cboRecType.Size = new System.Drawing.Size(271, 26);
            this.cboRecType.TabIndex = 201;
            this.cboRecType.Tag = "RecordType";
            this.cboRecType.SelectedIndexChanged += new System.EventHandler(this.cboRecType_SelectedIndexChanged_1);
            // 
            // lblRecordType
            // 
            this.lblRecordType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRecordType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRecordType.Location = new System.Drawing.Point(3, 5);
            this.lblRecordType.Name = "lblRecordType";
            this.lblRecordType.Size = new System.Drawing.Size(124, 27);
            this.lblRecordType.TabIndex = 202;
            this.lblRecordType.Text = "Record Type";
            this.lblRecordType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNewProduct.Location = new System.Drawing.Point(585, 287);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(142, 29);
            this.btnNewProduct.TabIndex = 203;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(3, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 32);
            this.label11.TabIndex = 205;
            this.label11.Text = "Prod/App";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpLeft
            // 
            this.tlpLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLeft.ColumnCount = 2;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.18673F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.81327F));
            this.tlpLeft.Controls.Add(this.lblRecordType, 0, 0);
            this.tlpLeft.Controls.Add(this.label1, 0, 1);
            this.tlpLeft.Controls.Add(this.label5, 0, 2);
            this.tlpLeft.Controls.Add(this.cboRecType, 1, 0);
            this.tlpLeft.Controls.Add(this.label3, 0, 3);
            this.tlpLeft.Controls.Add(this.cboCity, 1, 3);
            this.tlpLeft.Controls.Add(this.label2, 0, 4);
            this.tlpLeft.Controls.Add(this.label6, 0, 5);
            this.tlpLeft.Controls.Add(this.label7, 0, 6);
            this.tlpLeft.Controls.Add(this.txtCTRNum, 1, 13);
            this.tlpLeft.Controls.Add(this.label9, 0, 7);
            this.tlpLeft.Controls.Add(this.label16, 0, 10);
            this.tlpLeft.Controls.Add(this.label18, 0, 11);
            this.tlpLeft.Controls.Add(this.label23, 0, 12);
            this.tlpLeft.Controls.Add(this.txtQty, 1, 11);
            this.tlpLeft.Controls.Add(this.label8, 0, 13);
            this.tlpLeft.Controls.Add(this.cboLead, 1, 10);
            this.tlpLeft.Controls.Add(this.lblArch, 0, 15);
            this.tlpLeft.Controls.Add(this.label11, 0, 8);
            this.tlpLeft.Controls.Add(this.label10, 0, 14);
            this.tlpLeft.Controls.Add(this.cboStatus, 1, 9);
            this.tlpLeft.Controls.Add(this.txtEscNum, 1, 14);
            this.tlpLeft.Controls.Add(this.txtPSNum, 1, 12);
            this.tlpLeft.Controls.Add(this.label19, 0, 9);
            this.tlpLeft.Controls.Add(this.cboMSO, 1, 1);
            this.tlpLeft.Controls.Add(this.txtEndUser, 1, 2);
            this.tlpLeft.Controls.Add(this.cboState, 1, 4);
            this.tlpLeft.Controls.Add(this.cboCountry, 1, 5);
            this.tlpLeft.Controls.Add(this.cboSeverity, 1, 6);
            this.tlpLeft.Controls.Add(this.cboRequestor, 1, 7);
            this.tlpLeft.Controls.Add(this.cboApplication, 1, 8);
            this.tlpLeft.Controls.Add(this.label15, 0, 19);
            this.tlpLeft.Controls.Add(this.label12, 0, 18);
            this.tlpLeft.Controls.Add(this.label13, 0, 17);
            this.tlpLeft.Controls.Add(this.label14, 0, 16);
            this.tlpLeft.Controls.Add(this.cboArchitecture, 1, 15);
            this.tlpLeft.Controls.Add(this.dtpStartDate, 1, 16);
            this.tlpLeft.Controls.Add(this.dtpDueDate, 1, 17);
            this.tlpLeft.Controls.Add(this.dtpClosedDate, 1, 18);
            this.tlpLeft.Controls.Add(this.txtEntryAdmin, 1, 19);
            this.tlpLeft.Location = new System.Drawing.Point(12, 33);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 20;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeft.Size = new System.Drawing.Size(407, 640);
            this.tlpLeft.TabIndex = 207;
            // 
            // cboApplication
            // 
            this.cboApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboApplication.FormattingEnabled = true;
            this.cboApplication.Location = new System.Drawing.Point(133, 259);
            this.cboApplication.Name = "cboApplication";
            this.cboApplication.Size = new System.Drawing.Size(269, 26);
            this.cboApplication.TabIndex = 210;
            this.cboApplication.Tag = "Application";
            // 
            // lblArch
            // 
            this.lblArch.AutoSize = true;
            this.lblArch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblArch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblArch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblArch.Location = new System.Drawing.Point(41, 480);
            this.lblArch.Name = "lblArch";
            this.lblArch.Size = new System.Drawing.Size(86, 32);
            this.lblArch.TabIndex = 208;
            this.lblArch.Text = "Architecture";
            this.lblArch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboArchitecture
            // 
            this.cboArchitecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArchitecture.FormattingEnabled = true;
            this.cboArchitecture.Location = new System.Drawing.Point(133, 483);
            this.cboArchitecture.Name = "cboArchitecture";
            this.cboArchitecture.Size = new System.Drawing.Size(269, 26);
            this.cboArchitecture.TabIndex = 211;
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.ckFilter);
            this.gbDateRange.Controls.Add(this.label26);
            this.gbDateRange.Controls.Add(this.label25);
            this.gbDateRange.Controls.Add(this.dtpEnd);
            this.gbDateRange.Controls.Add(this.dtpStart);
            this.gbDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDateRange.Location = new System.Drawing.Point(439, 630);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(437, 88);
            this.gbDateRange.TabIndex = 208;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "Optional Date Range Filter";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(166, 28);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(259, 24);
            this.dtpStart.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(166, 58);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(259, 24);
            this.dtpEnd.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(88, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 18);
            this.label25.TabIndex = 2;
            this.label25.Text = "Start Date";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(93, 62);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 18);
            this.label26.TabIndex = 3;
            this.label26.Text = "End Date";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckFilter
            // 
            this.ckFilter.AutoSize = true;
            this.ckFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFilter.Location = new System.Drawing.Point(6, 37);
            this.ckFilter.Name = "ckFilter";
            this.ckFilter.Size = new System.Drawing.Size(83, 22);
            this.ckFilter.TabIndex = 4;
            this.ckFilter.Text = "Filter On";
            this.ckFilter.UseVisualStyleBackColor = true;
            // 
            // frmLabEsc
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1409, 741);
            this.Controls.Add(this.gbDateRange);
            this.Controls.Add(this.tlpLeft);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cboResolution);
            this.Controls.Add(this.btnRemoveAttach);
            this.Controls.Add(this.btnAddAttach);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dgvAttachments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxComments);
            this.Controls.Add(this.rtxDescription);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRecordID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLabEsc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lab Requests/Escalation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLabEsc_FormClosing);
            this.Load += new System.EventHandler(this.frmLabEsc_Load);
            this.dtpContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).EndInit();
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeft.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecordID;
        private System.Windows.Forms.ComboBox cboMSO;
        private System.Windows.Forms.ComboBox cboSeverity;
        private System.Windows.Forms.TextBox txtEndUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEscNum;
        private System.Windows.Forms.TextBox txtPSNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.ComboBox cboRequestor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpClosedDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEntryAdmin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboLead;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.RichTextBox rtxDescription;
        private System.Windows.Forms.RichTextBox rtxComments;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtCTRNum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvAttachments;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnRemoveAttach;
        private System.Windows.Forms.Button btnAddAttach;
        private System.Windows.Forms.ContextMenuStrip dtpContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearDateToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.ComboBox cboResolution;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboRecType;
        private System.Windows.Forms.Label lblRecordType;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.ComboBox cboApplication;
        private System.Windows.Forms.Label lblArch;
        private System.Windows.Forms.ComboBox cboArchitecture;
        private System.Windows.Forms.GroupBox gbDateRange;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.CheckBox ckFilter;
    }
}