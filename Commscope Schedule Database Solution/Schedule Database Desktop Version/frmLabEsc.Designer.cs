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
            this.cboEntryAdmin = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpClosedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
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
            this.rdoATEsc = new System.Windows.Forms.RadioButton();
            this.rdoLabReq = new System.Windows.Forms.RadioButton();
            this.grpRecordType = new System.Windows.Forms.GroupBox();
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
            this.dtpContextMenu.SuspendLayout();
            this.grpRecordType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecordID
            // 
            this.txtRecordID.Location = new System.Drawing.Point(420, 28);
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.Size = new System.Drawing.Size(396, 20);
            this.txtRecordID.TabIndex = 0;
            this.txtRecordID.Tag = "EscID";
            this.txtRecordID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboMSO
            // 
            this.cboMSO.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboMSO.FormattingEnabled = true;
            this.cboMSO.Location = new System.Drawing.Point(87, 81);
            this.cboMSO.Name = "cboMSO";
            this.cboMSO.Size = new System.Drawing.Size(273, 21);
            this.cboMSO.TabIndex = 2;
            this.cboMSO.Tag = "MSO|MSO|MSOModel";
            this.cboMSO.SelectedIndexChanged += new System.EventHandler(this.cboMSO_SelectedIndexChanged);
            // 
            // cboSeverity
            // 
            this.cboSeverity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboSeverity.FormattingEnabled = true;
            this.cboSeverity.Location = new System.Drawing.Point(87, 229);
            this.cboSeverity.Name = "cboSeverity";
            this.cboSeverity.Size = new System.Drawing.Size(273, 21);
            this.cboSeverity.TabIndex = 3;
            this.cboSeverity.Tag = "Severity";
            // 
            // txtEndUser
            // 
            this.txtEndUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtEndUser.Location = new System.Drawing.Point(87, 111);
            this.txtEndUser.Name = "txtEndUser";
            this.txtEndUser.Size = new System.Drawing.Size(273, 20);
            this.txtEndUser.TabIndex = 6;
            this.txtEndUser.Tag = "EndUser|EndUser";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "MSO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(48, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "State";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(57, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "City";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(25, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "End User";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(35, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Country";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(34, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Severity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEscNum
            // 
            this.txtEscNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtEscNum.Location = new System.Drawing.Point(87, 465);
            this.txtEscNum.Name = "txtEscNum";
            this.txtEscNum.Size = new System.Drawing.Size(273, 20);
            this.txtEscNum.TabIndex = 14;
            this.txtEscNum.Tag = "EscNum";
            // 
            // txtPSNum
            // 
            this.txtPSNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPSNum.Location = new System.Drawing.Point(87, 407);
            this.txtPSNum.Name = "txtPSNum";
            this.txtPSNum.Size = new System.Drawing.Size(273, 20);
            this.txtPSNum.TabIndex = 15;
            this.txtPSNum.Tag = "PSNumber";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(4, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "CTR Number";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(19, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Requestor";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCountry
            // 
            this.cboCountry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(87, 201);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(273, 21);
            this.cboCountry.TabIndex = 18;
            this.cboCountry.Tag = "Country|Country";
            // 
            // cboState
            // 
            this.cboState.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(87, 170);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(273, 21);
            this.cboState.TabIndex = 19;
            this.cboState.Tag = "StateStated";
            // 
            // cboRequestor
            // 
            this.cboRequestor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboRequestor.FormattingEnabled = true;
            this.cboRequestor.Location = new System.Drawing.Point(87, 259);
            this.cboRequestor.Name = "cboRequestor";
            this.cboRequestor.Size = new System.Drawing.Size(273, 21);
            this.cboRequestor.TabIndex = 20;
            this.cboRequestor.Tag = "Requestor";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(8, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Esc Number";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboEntryAdmin
            // 
            this.cboEntryAdmin.FormattingEnabled = true;
            this.cboEntryAdmin.Location = new System.Drawing.Point(462, 590);
            this.cboEntryAdmin.Name = "cboEntryAdmin";
            this.cboEntryAdmin.Size = new System.Drawing.Size(273, 21);
            this.cboEntryAdmin.TabIndex = 23;
            this.cboEntryAdmin.Tag = "EntryAdmin";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(383, 596);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Entry Admin";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpStartDate.ContextMenuStrip = this.dtpContextMenu;
            this.dtpStartDate.Location = new System.Drawing.Point(87, 494);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(273, 20);
            this.dtpStartDate.TabIndex = 25;
            this.dtpStartDate.Tag = "DateOpened";
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
            this.dtpClosedDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpClosedDate.ContextMenuStrip = this.dtpContextMenu;
            this.dtpClosedDate.Location = new System.Drawing.Point(87, 552);
            this.dtpClosedDate.Name = "dtpClosedDate";
            this.dtpClosedDate.Size = new System.Drawing.Size(273, 20);
            this.dtpClosedDate.TabIndex = 26;
            this.dtpClosedDate.Tag = "DateCompleted";
            this.dtpClosedDate.ValueChanged += new System.EventHandler(this.dtpClosedDate_ValueChanged);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpDueDate.ContextMenuStrip = this.dtpContextMenu;
            this.dtpDueDate.Location = new System.Drawing.Point(87, 523);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(273, 20);
            this.dtpDueDate.TabIndex = 27;
            this.dtpDueDate.Tag = "DueDate";
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(9, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Date Closed";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(24, 523);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Due Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(3, 494);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Date Opened";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtEmail.Location = new System.Drawing.Point(87, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 20);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.Tag = "EMail";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(44, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Email";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(48, 348);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "Lead";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label17.Location = new System.Drawing.Point(370, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 15);
            this.label17.TabIndex = 34;
            this.label17.Text = "Product(s)";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(32, 375);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 15);
            this.label18.TabIndex = 35;
            this.label18.Text = "Quantity";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Location = new System.Drawing.Point(42, 321);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 15);
            this.label19.TabIndex = 36;
            this.label19.Text = "Status";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label20.Location = new System.Drawing.Point(852, 285);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 15);
            this.label20.TabIndex = 37;
            this.label20.Text = "Comments / Resolution";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label21.Location = new System.Drawing.Point(867, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 15);
            this.label21.TabIndex = 38;
            this.label21.Text = "Description";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label22.Location = new System.Drawing.Point(852, 538);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 15);
            this.label22.TabIndex = 39;
            this.label22.Text = "Resolution Type";
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(85, 318);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(273, 21);
            this.cboStatus.TabIndex = 41;
            this.cboStatus.Tag = "Status";
            // 
            // cboLead
            // 
            this.cboLead.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboLead.FormattingEnabled = true;
            this.cboLead.Location = new System.Drawing.Point(87, 348);
            this.cboLead.Name = "cboLead";
            this.cboLead.Size = new System.Drawing.Size(273, 21);
            this.cboLead.TabIndex = 42;
            this.cboLead.Tag = "LeadAssigned";
            // 
            // txtQty
            // 
            this.txtQty.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtQty.Location = new System.Drawing.Point(87, 375);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(273, 20);
            this.txtQty.TabIndex = 43;
            this.txtQty.Tag = "Quantity";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(373, 81);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(457, 186);
            this.lstProducts.TabIndex = 44;
            this.lstProducts.Tag = "Product";
            // 
            // rtxDescription
            // 
            this.rtxDescription.Location = new System.Drawing.Point(852, 46);
            this.rtxDescription.Name = "rtxDescription";
            this.rtxDescription.Size = new System.Drawing.Size(424, 233);
            this.rtxDescription.TabIndex = 45;
            this.rtxDescription.Tag = "Description";
            this.rtxDescription.Text = "";
            // 
            // rtxComments
            // 
            this.rtxComments.Location = new System.Drawing.Point(852, 303);
            this.rtxComments.Name = "rtxComments";
            this.rtxComments.Size = new System.Drawing.Size(424, 228);
            this.rtxComments.TabIndex = 46;
            this.rtxComments.Tag = "Comments";
            this.rtxComments.Text = "";
            // 
            // rdoATEsc
            // 
            this.rdoATEsc.AutoSize = true;
            this.rdoATEsc.Location = new System.Drawing.Point(22, 19);
            this.rdoATEsc.Name = "rdoATEsc";
            this.rdoATEsc.Size = new System.Drawing.Size(91, 17);
            this.rdoATEsc.TabIndex = 48;
            this.rdoATEsc.TabStop = true;
            this.rdoATEsc.Text = "AT Escalation";
            this.rdoATEsc.UseVisualStyleBackColor = true;
            this.rdoATEsc.CheckedChanged += new System.EventHandler(this.rdoATEsc_CheckedChanged);
            // 
            // rdoLabReq
            // 
            this.rdoLabReq.AutoSize = true;
            this.rdoLabReq.Location = new System.Drawing.Point(146, 19);
            this.rdoLabReq.Name = "rdoLabReq";
            this.rdoLabReq.Size = new System.Drawing.Size(86, 17);
            this.rdoLabReq.TabIndex = 49;
            this.rdoLabReq.TabStop = true;
            this.rdoLabReq.Text = "Lab Request";
            this.rdoLabReq.UseVisualStyleBackColor = true;
            this.rdoLabReq.CheckedChanged += new System.EventHandler(this.rdoLabReq_CheckedChanged);
            // 
            // grpRecordType
            // 
            this.grpRecordType.Controls.Add(this.rdoATEsc);
            this.grpRecordType.Controls.Add(this.rdoLabReq);
            this.grpRecordType.Location = new System.Drawing.Point(111, 28);
            this.grpRecordType.Name = "grpRecordType";
            this.grpRecordType.Size = new System.Drawing.Size(273, 52);
            this.grpRecordType.TabIndex = 50;
            this.grpRecordType.TabStop = false;
            this.grpRecordType.Text = "Record Type";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label23.Location = new System.Drawing.Point(12, 409);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 15);
            this.label23.TabIndex = 52;
            this.label23.Text = "PS Number";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCTRNum
            // 
            this.txtCTRNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCTRNum.Location = new System.Drawing.Point(87, 436);
            this.txtCTRNum.Name = "txtCTRNum";
            this.txtCTRNum.Size = new System.Drawing.Size(273, 20);
            this.txtCTRNum.TabIndex = 51;
            this.txtCTRNum.Tag = "CTRNum";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(984, 590);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 43);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(1151, 590);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 43);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvAttachments
            // 
            this.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttachments.Location = new System.Drawing.Point(373, 303);
            this.dgvAttachments.Name = "dgvAttachments";
            this.dgvAttachments.Size = new System.Drawing.Size(457, 228);
            this.dgvAttachments.TabIndex = 55;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label24.Location = new System.Drawing.Point(370, 285);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 15);
            this.label24.TabIndex = 56;
            this.label24.Text = "Attachments";
            // 
            // btnRemoveAttach
            // 
            this.btnRemoveAttach.Location = new System.Drawing.Point(609, 549);
            this.btnRemoveAttach.Name = "btnRemoveAttach";
            this.btnRemoveAttach.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAttach.TabIndex = 58;
            this.btnRemoveAttach.Text = "Remove";
            this.btnRemoveAttach.UseVisualStyleBackColor = true;
            // 
            // btnAddAttach
            // 
            this.btnAddAttach.Location = new System.Drawing.Point(501, 549);
            this.btnAddAttach.Name = "btnAddAttach";
            this.btnAddAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAddAttach.TabIndex = 57;
            this.btnAddAttach.Text = "Add";
            this.btnAddAttach.UseVisualStyleBackColor = true;
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(85, 140);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(275, 21);
            this.cboCity.TabIndex = 60;
            // 
            // cboResolution
            // 
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Location = new System.Drawing.Point(971, 538);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(284, 21);
            this.cboResolution.TabIndex = 61;
            // 
            // frmLabEsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 665);
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
            this.Controls.Add(this.grpRecordType);
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
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpClosedDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboEntryAdmin);
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
            this.Name = "frmLabEsc";
            this.Text = "frmLabEsc";
            this.Load += new System.EventHandler(this.frmLabEsc_Load);
            this.dtpContextMenu.ResumeLayout(false);
            this.grpRecordType.ResumeLayout(false);
            this.grpRecordType.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboEntryAdmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpClosedDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
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
        private System.Windows.Forms.RadioButton rdoATEsc;
        private System.Windows.Forms.RadioButton rdoLabReq;
        private System.Windows.Forms.GroupBox grpRecordType;
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
    }
}