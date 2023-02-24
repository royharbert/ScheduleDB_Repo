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
            this.dtpContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecordID
            // 
            this.txtRecordID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRecordID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecordID.Location = new System.Drawing.Point(499, 21);
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.Size = new System.Drawing.Size(396, 19);
            this.txtRecordID.TabIndex = 200;
            this.txtRecordID.TabStop = false;
            this.txtRecordID.Tag = "EscID";
            this.txtRecordID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboMSO
            // 
            this.cboMSO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMSO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboMSO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMSO.FormattingEnabled = true;
            this.cboMSO.Location = new System.Drawing.Point(117, 89);
            this.cboMSO.Name = "cboMSO";
            this.cboMSO.Size = new System.Drawing.Size(273, 21);
            this.cboMSO.TabIndex = 0;
            this.cboMSO.Tag = "MSO";
            this.cboMSO.SelectedIndexChanged += new System.EventHandler(this.cboMSO_SelectedIndexChanged);
            // 
            // cboSeverity
            // 
            this.cboSeverity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSeverity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSeverity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSeverity.FormattingEnabled = true;
            this.cboSeverity.Location = new System.Drawing.Point(117, 228);
            this.cboSeverity.Name = "cboSeverity";
            this.cboSeverity.Size = new System.Drawing.Size(273, 21);
            this.cboSeverity.TabIndex = 5;
            this.cboSeverity.Tag = "Severity";
            this.cboSeverity.SelectedIndexChanged += new System.EventHandler(this.cboSeverity_SelectedIndexChanged);
            this.cboSeverity.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // txtEndUser
            // 
            this.txtEndUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndUser.Location = new System.Drawing.Point(117, 117);
            this.txtEndUser.Name = "txtEndUser";
            this.txtEndUser.Size = new System.Drawing.Size(273, 20);
            this.txtEndUser.TabIndex = 1;
            this.txtEndUser.Tag = "EndUser";
            this.txtEndUser.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(70, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 200;
            this.label1.Text = "MSO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(70, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 200;
            this.label2.Text = "State";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(79, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 200;
            this.label3.Text = "City";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 200;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(43, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 200;
            this.label5.Text = "End User";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(53, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 200;
            this.label6.Text = "Country";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(52, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 200;
            this.label7.Text = "Severity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEscNum
            // 
            this.txtEscNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEscNum.Location = new System.Drawing.Point(117, 421);
            this.txtEscNum.Name = "txtEscNum";
            this.txtEscNum.Size = new System.Drawing.Size(273, 20);
            this.txtEscNum.TabIndex = 13;
            this.txtEscNum.Tag = "EscNum";
            this.txtEscNum.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // txtPSNum
            // 
            this.txtPSNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPSNum.Location = new System.Drawing.Point(117, 367);
            this.txtPSNum.Name = "txtPSNum";
            this.txtPSNum.Size = new System.Drawing.Size(273, 20);
            this.txtPSNum.TabIndex = 11;
            this.txtPSNum.Tag = "PSNumber";
            this.txtPSNum.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(22, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 200;
            this.label8.Text = "CTR Number";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(37, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 200;
            this.label9.Text = "Requestor";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCountry
            // 
            this.cboCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(117, 200);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(273, 21);
            this.cboCountry.TabIndex = 4;
            this.cboCountry.Tag = "Country";
            this.cboCountry.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // cboState
            // 
            this.cboState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(117, 172);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(273, 21);
            this.cboState.TabIndex = 3;
            this.cboState.Tag = "State";
            this.cboState.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // cboRequestor
            // 
            this.cboRequestor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRequestor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboRequestor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRequestor.FormattingEnabled = true;
            this.cboRequestor.Location = new System.Drawing.Point(117, 256);
            this.cboRequestor.Name = "cboRequestor";
            this.cboRequestor.Size = new System.Drawing.Size(273, 21);
            this.cboRequestor.TabIndex = 6;
            this.cboRequestor.Tag = "Requestor";
            this.cboRequestor.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            this.cboRequestor.Leave += new System.EventHandler(this.cboRequestor_Leave);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(26, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Esc Number";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStartDate.ContextMenuStrip = this.dtpContextMenu;
            this.dtpStartDate.Location = new System.Drawing.Point(117, 448);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(273, 20);
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
            this.dtpClosedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpClosedDate.ContextMenuStrip = this.dtpContextMenu;
            this.dtpClosedDate.Location = new System.Drawing.Point(117, 502);
            this.dtpClosedDate.Name = "dtpClosedDate";
            this.dtpClosedDate.Size = new System.Drawing.Size(273, 20);
            this.dtpClosedDate.TabIndex = 16;
            this.dtpClosedDate.Tag = "DateCompleted";
            this.dtpClosedDate.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            this.dtpClosedDate.ValueChanged += new System.EventHandler(this.dtpClosedDate_ValueChanged);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDueDate.ContextMenuStrip = this.dtpContextMenu;
            this.dtpDueDate.Location = new System.Drawing.Point(117, 475);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(273, 20);
            this.dtpDueDate.TabIndex = 15;
            this.dtpDueDate.Tag = "DueDate";
            this.dtpDueDate.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(27, 507);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Date Closed";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(42, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Due Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(21, 453);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Date Opened";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEntryAdmin
            // 
            this.txtEntryAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEntryAdmin.Location = new System.Drawing.Point(117, 528);
            this.txtEntryAdmin.Name = "txtEntryAdmin";
            this.txtEntryAdmin.Size = new System.Drawing.Size(273, 20);
            this.txtEntryAdmin.TabIndex = 7;
            this.txtEntryAdmin.TabStop = false;
            this.txtEntryAdmin.Tag = "EntryAdmin";
            this.txtEntryAdmin.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(29, 534);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Entry Admin";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(66, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "Lead";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label17.Location = new System.Drawing.Point(426, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Product(s)";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(50, 343);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 15);
            this.label18.TabIndex = 35;
            this.label18.Text = "Quantity";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Location = new System.Drawing.Point(60, 287);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 15);
            this.label19.TabIndex = 36;
            this.label19.Text = "Status";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label20.Location = new System.Drawing.Point(1006, 283);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 15);
            this.label20.TabIndex = 37;
            this.label20.Text = "Comments / Resolution";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label21.Location = new System.Drawing.Point(1006, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 15);
            this.label21.TabIndex = 38;
            this.label21.Text = "Description";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label22.Location = new System.Drawing.Point(1006, 536);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 15);
            this.label22.TabIndex = 39;
            this.label22.Text = "Resolution Type";
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(117, 284);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(273, 21);
            this.cboStatus.TabIndex = 8;
            this.cboStatus.Tag = "Status";
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            this.cboStatus.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // cboLead
            // 
            this.cboLead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboLead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLead.FormattingEnabled = true;
            this.cboLead.Location = new System.Drawing.Point(117, 312);
            this.cboLead.Name = "cboLead";
            this.cboLead.Size = new System.Drawing.Size(273, 21);
            this.cboLead.TabIndex = 9;
            this.cboLead.Tag = "LeadAssigned";
            this.cboLead.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            this.cboLead.Leave += new System.EventHandler(this.cboLead_Leave);
            // 
            // txtQty
            // 
            this.txtQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQty.Location = new System.Drawing.Point(117, 340);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(273, 20);
            this.txtQty.TabIndex = 10;
            this.txtQty.Tag = "Quantity";
            this.txtQty.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // lstProducts
            // 
            this.lstProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(422, 79);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(556, 147);
            this.lstProducts.TabIndex = 17;
            this.lstProducts.Tag = "Product";
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // rtxDescription
            // 
            this.rtxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxDescription.Location = new System.Drawing.Point(1006, 44);
            this.rtxDescription.Name = "rtxDescription";
            this.rtxDescription.Size = new System.Drawing.Size(424, 233);
            this.rtxDescription.TabIndex = 45;
            this.rtxDescription.Tag = "Description";
            this.rtxDescription.Text = "";
            this.rtxDescription.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // rtxComments
            // 
            this.rtxComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxComments.Location = new System.Drawing.Point(1006, 301);
            this.rtxComments.Name = "rtxComments";
            this.rtxComments.Size = new System.Drawing.Size(424, 228);
            this.rtxComments.TabIndex = 46;
            this.rtxComments.Tag = "Comments";
            this.rtxComments.Text = "";
            this.rtxComments.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label23.Location = new System.Drawing.Point(-12, 371);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 16);
            this.label23.TabIndex = 52;
            this.label23.Text = "365 Number";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCTRNum
            // 
            this.txtCTRNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCTRNum.Location = new System.Drawing.Point(117, 394);
            this.txtCTRNum.Name = "txtCTRNum";
            this.txtCTRNum.Size = new System.Drawing.Size(273, 20);
            this.txtCTRNum.TabIndex = 12;
            this.txtCTRNum.Tag = "CTRNum";
            this.txtCTRNum.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(1089, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 43);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(1256, 608);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 43);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvAttachments
            // 
            this.dgvAttachments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttachments.Location = new System.Drawing.Point(429, 291);
            this.dgvAttachments.Name = "dgvAttachments";
            this.dgvAttachments.RowHeadersWidth = 62;
            this.dgvAttachments.Size = new System.Drawing.Size(549, 228);
            this.dgvAttachments.TabIndex = 18;
            this.dgvAttachments.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttachments_RowHeaderMouseClick);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label24.Location = new System.Drawing.Point(426, 273);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 15);
            this.label24.TabIndex = 56;
            this.label24.Text = "Attachments";
            // 
            // btnRemoveAttach
            // 
            this.btnRemoveAttach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveAttach.Location = new System.Drawing.Point(743, 537);
            this.btnRemoveAttach.Name = "btnRemoveAttach";
            this.btnRemoveAttach.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAttach.TabIndex = 58;
            this.btnRemoveAttach.Text = "Remove";
            this.btnRemoveAttach.UseVisualStyleBackColor = true;
            this.btnRemoveAttach.Click += new System.EventHandler(this.btnRemoveAttach_Click);
            // 
            // btnAddAttach
            // 
            this.btnAddAttach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAttach.Location = new System.Drawing.Point(635, 537);
            this.btnAddAttach.Name = "btnAddAttach";
            this.btnAddAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAddAttach.TabIndex = 57;
            this.btnAddAttach.Text = "Add";
            this.btnAddAttach.UseVisualStyleBackColor = true;
            this.btnAddAttach.Click += new System.EventHandler(this.btnAddAttach_Click);
            // 
            // cboCity
            // 
            this.cboCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(117, 144);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(273, 21);
            this.cboCity.TabIndex = 2;
            this.cboCity.Tag = "City";
            this.cboCity.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // cboResolution
            // 
            this.cboResolution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Location = new System.Drawing.Point(1006, 561);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(424, 21);
            this.cboResolution.TabIndex = 61;
            this.cboResolution.Tag = "Resolution";
            this.cboResolution.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(133, 610);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(64, 20);
            this.txtID.TabIndex = 63;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.txtRecordID_TextChanged);
            // 
            // cboRecType
            // 
            this.cboRecType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRecType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboRecType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRecType.FormattingEnabled = true;
            this.cboRecType.Location = new System.Drawing.Point(117, 61);
            this.cboRecType.Name = "cboRecType";
            this.cboRecType.Size = new System.Drawing.Size(273, 21);
            this.cboRecType.TabIndex = 201;
            this.cboRecType.Tag = "RecordType";
            this.cboRecType.SelectedIndexChanged += new System.EventHandler(this.cboRecType_SelectedIndexChanged_1);
            // 
            // lblRecordType
            // 
            this.lblRecordType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecordType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRecordType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRecordType.Location = new System.Drawing.Point(25, 63);
            this.lblRecordType.Name = "lblRecordType";
            this.lblRecordType.Size = new System.Drawing.Size(76, 15);
            this.lblRecordType.TabIndex = 202;
            this.lblRecordType.Text = "Record Type";
            this.lblRecordType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewProduct.Location = new System.Drawing.Point(666, 232);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(95, 23);
            this.btnNewProduct.TabIndex = 203;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // frmLabEsc
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1437, 679);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.lblRecordType);
            this.Controls.Add(this.cboRecType);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cboResolution);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.btnRemoveAttach);
            this.Controls.Add(this.btnAddAttach);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dgvAttachments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtCTRNum);
            this.Controls.Add(this.rtxComments);
            this.Controls.Add(this.rtxDescription);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.cboLead);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEntryAdmin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpClosedDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboRequestor);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPSNum);
            this.Controls.Add(this.txtEscNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndUser);
            this.Controls.Add(this.cboSeverity);
            this.Controls.Add(this.cboMSO);
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
    }
}