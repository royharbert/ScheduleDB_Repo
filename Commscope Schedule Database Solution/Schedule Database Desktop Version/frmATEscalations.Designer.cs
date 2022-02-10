
namespace Schedule_Database_Desktop_Version
{
    partial class FrmATEscalations
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
            this.cbo_MSO = new System.Windows.Forms.ComboBox();
            this.cbo_Status = new System.Windows.Forms.ComboBox();
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.lbl_MSO = new System.Windows.Forms.Label();
            this.lbl_ATProdApp = new System.Windows.Forms.Label();
            this.lbl_EscalationStatus = new System.Windows.Forms.Label();
            this.lbl_PartNumbers = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.lbl_FELead = new System.Windows.Forms.Label();
            this.dtp_DateReported = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateResolved = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateReported = new System.Windows.Forms.Label();
            this.lbl_DateResolved = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_Resolution = new System.Windows.Forms.TextBox();
            this.txt_Comments = new System.Windows.Forms.TextBox();
            this.txt_CTRNumber = new System.Windows.Forms.TextBox();
            this.txt_PSNumber = new System.Windows.Forms.TextBox();
            this.lbl_OptionalFields = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.lbl_CTRNumber = new System.Windows.Forms.Label();
            this.lbl_PSNumber = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.lbl_RequiredFields = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_AddAttachment = new System.Windows.Forms.Button();
            this.btn_RemoveAttachment = new System.Windows.Forms.Button();
            this.lbl_Attachments = new System.Windows.Forms.Label();
            this.grp_OptionalFields = new System.Windows.Forms.GroupBox();
            this.lst_FELead = new System.Windows.Forms.ListBox();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.dgvAttachments = new System.Windows.Forms.DataGridView();
            this.lst_PartNumber = new System.Windows.Forms.ListBox();
            this.grp_OptionalFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_MSO
            // 
            this.cbo_MSO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_MSO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_MSO.FormattingEnabled = true;
            this.cbo_MSO.Location = new System.Drawing.Point(173, 56);
            this.cbo_MSO.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MSO.Name = "cbo_MSO";
            this.cbo_MSO.Size = new System.Drawing.Size(265, 24);
            this.cbo_MSO.TabIndex = 0;
            this.cbo_MSO.Tag = "U";
            this.cbo_MSO.SelectedIndexChanged += new System.EventHandler(this.cbo_MSO_SelectedIndexChanged);
            // 
            // cbo_Status
            // 
            this.cbo_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_Status.FormattingEnabled = true;
            this.cbo_Status.Location = new System.Drawing.Point(173, 120);
            this.cbo_Status.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Status.Name = "cbo_Status";
            this.cbo_Status.Size = new System.Drawing.Size(265, 24);
            this.cbo_Status.TabIndex = 2;
            this.cbo_Status.Tag = "L";
            this.cbo_Status.SelectedIndexChanged += new System.EventHandler(this.cbo_MSO_SelectedIndexChanged);
            // 
            // cbo_Type
            // 
            this.cbo_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(173, 88);
            this.cbo_Type.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(265, 24);
            this.cbo_Type.TabIndex = 1;
            this.cbo_Type.Tag = "L";
            this.cbo_Type.SelectedIndexChanged += new System.EventHandler(this.cbo_MSO_SelectedIndexChanged);
            // 
            // lbl_MSO
            // 
            this.lbl_MSO.AutoSize = true;
            this.lbl_MSO.Location = new System.Drawing.Point(36, 60);
            this.lbl_MSO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MSO.Name = "lbl_MSO";
            this.lbl_MSO.Size = new System.Drawing.Size(39, 17);
            this.lbl_MSO.TabIndex = 3;
            this.lbl_MSO.Text = "MSO";
            // 
            // lbl_ATProdApp
            // 
            this.lbl_ATProdApp.AutoSize = true;
            this.lbl_ATProdApp.Location = new System.Drawing.Point(36, 92);
            this.lbl_ATProdApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ATProdApp.Name = "lbl_ATProdApp";
            this.lbl_ATProdApp.Size = new System.Drawing.Size(40, 17);
            this.lbl_ATProdApp.TabIndex = 4;
            this.lbl_ATProdApp.Text = "Type";
            // 
            // lbl_EscalationStatus
            // 
            this.lbl_EscalationStatus.AutoSize = true;
            this.lbl_EscalationStatus.Location = new System.Drawing.Point(36, 123);
            this.lbl_EscalationStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EscalationStatus.Name = "lbl_EscalationStatus";
            this.lbl_EscalationStatus.Size = new System.Drawing.Size(48, 17);
            this.lbl_EscalationStatus.TabIndex = 5;
            this.lbl_EscalationStatus.Text = "Status";
            // 
            // lbl_PartNumbers
            // 
            this.lbl_PartNumbers.AutoSize = true;
            this.lbl_PartNumbers.Location = new System.Drawing.Point(36, 308);
            this.lbl_PartNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PartNumbers.Name = "lbl_PartNumbers";
            this.lbl_PartNumbers.Size = new System.Drawing.Size(88, 17);
            this.lbl_PartNumbers.TabIndex = 6;
            this.lbl_PartNumbers.Text = "Part Number";
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(173, 152);
            this.txt_Qty.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(265, 23);
            this.txt_Qty.TabIndex = 3;
            this.txt_Qty.Tag = "L";
            this.txt_Qty.TextChanged += new System.EventHandler(this.cbo_MSO_SelectedIndexChanged);
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.AutoSize = true;
            this.lbl_Qty.Location = new System.Drawing.Point(36, 156);
            this.lbl_Qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(61, 17);
            this.lbl_Qty.TabIndex = 9;
            this.lbl_Qty.Text = "Quantity";
            // 
            // lbl_FELead
            // 
            this.lbl_FELead.AutoSize = true;
            this.lbl_FELead.Location = new System.Drawing.Point(36, 209);
            this.lbl_FELead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FELead.Name = "lbl_FELead";
            this.lbl_FELead.Size = new System.Drawing.Size(57, 17);
            this.lbl_FELead.TabIndex = 11;
            this.lbl_FELead.Text = "Lead(s)";
            // 
            // dtp_DateReported
            // 
            this.dtp_DateReported.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateReported.Location = new System.Drawing.Point(173, 366);
            this.dtp_DateReported.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DateReported.Name = "dtp_DateReported";
            this.dtp_DateReported.Size = new System.Drawing.Size(265, 23);
            this.dtp_DateReported.TabIndex = 6;
            this.dtp_DateReported.Tag = "L";
            // 
            // dtp_DateResolved
            // 
            this.dtp_DateResolved.CustomFormat = " ";
            this.dtp_DateResolved.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateResolved.Location = new System.Drawing.Point(173, 397);
            this.dtp_DateResolved.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DateResolved.Name = "dtp_DateResolved";
            this.dtp_DateResolved.Size = new System.Drawing.Size(265, 23);
            this.dtp_DateResolved.TabIndex = 13;
            this.dtp_DateResolved.TabStop = false;
            this.dtp_DateResolved.Tag = "L";
            this.dtp_DateResolved.ValueChanged += new System.EventHandler(this.dtp_DateResolved_ValueChanged_1);
            // 
            // lbl_DateReported
            // 
            this.lbl_DateReported.AutoSize = true;
            this.lbl_DateReported.Location = new System.Drawing.Point(36, 366);
            this.lbl_DateReported.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateReported.Name = "lbl_DateReported";
            this.lbl_DateReported.Size = new System.Drawing.Size(101, 17);
            this.lbl_DateReported.TabIndex = 14;
            this.lbl_DateReported.Text = "Date Reported";
            // 
            // lbl_DateResolved
            // 
            this.lbl_DateResolved.AutoSize = true;
            this.lbl_DateResolved.Location = new System.Drawing.Point(36, 398);
            this.lbl_DateResolved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateResolved.Name = "lbl_DateResolved";
            this.lbl_DateResolved.Size = new System.Drawing.Size(101, 17);
            this.lbl_DateResolved.TabIndex = 15;
            this.lbl_DateResolved.Text = "Date Resolved";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(511, 78);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Description.Size = new System.Drawing.Size(493, 192);
            this.txt_Description.TabIndex = 7;
            this.txt_Description.Tag = "L";
            this.txt_Description.TextChanged += new System.EventHandler(this.cbo_MSO_SelectedIndexChanged);
            // 
            // txt_Resolution
            // 
            this.txt_Resolution.Location = new System.Drawing.Point(511, 301);
            this.txt_Resolution.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Resolution.Multiline = true;
            this.txt_Resolution.Name = "txt_Resolution";
            this.txt_Resolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Resolution.Size = new System.Drawing.Size(493, 187);
            this.txt_Resolution.TabIndex = 8;
            this.txt_Resolution.Tag = "L";
            this.txt_Resolution.TextChanged += new System.EventHandler(this.cbo_MSO_SelectedIndexChanged);
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(19, 47);
            this.txt_Comments.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Comments.Size = new System.Drawing.Size(421, 191);
            this.txt_Comments.TabIndex = 12;
            this.txt_Comments.Tag = "L";
            this.txt_Comments.TextChanged += new System.EventHandler(this.cbo_MSO_SelectedIndexChanged);
            // 
            // txt_CTRNumber
            // 
            this.txt_CTRNumber.Location = new System.Drawing.Point(212, 262);
            this.txt_CTRNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CTRNumber.Name = "txt_CTRNumber";
            this.txt_CTRNumber.Size = new System.Drawing.Size(215, 23);
            this.txt_CTRNumber.TabIndex = 13;
            this.txt_CTRNumber.Tag = "L";
            this.txt_CTRNumber.TextChanged += new System.EventHandler(this.cbo_MSO_SelectedIndexChanged);
            // 
            // txt_PSNumber
            // 
            this.txt_PSNumber.Location = new System.Drawing.Point(212, 302);
            this.txt_PSNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PSNumber.Name = "txt_PSNumber";
            this.txt_PSNumber.Size = new System.Drawing.Size(215, 23);
            this.txt_PSNumber.TabIndex = 14;
            this.txt_PSNumber.Tag = "L";
            this.txt_PSNumber.TextChanged += new System.EventHandler(this.cbo_MSO_SelectedIndexChanged);
            // 
            // lbl_OptionalFields
            // 
            this.lbl_OptionalFields.AutoSize = true;
            this.lbl_OptionalFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionalFields.Location = new System.Drawing.Point(7, 0);
            this.lbl_OptionalFields.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionalFields.Name = "lbl_OptionalFields";
            this.lbl_OptionalFields.Size = new System.Drawing.Size(117, 17);
            this.lbl_OptionalFields.TabIndex = 21;
            this.lbl_OptionalFields.Text = "Optional Fields";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(508, 56);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(508, 275);
            this.lblResolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(75, 17);
            this.lblResolution.TabIndex = 23;
            this.lblResolution.Text = "Resolution";
            // 
            // lbl_CTRNumber
            // 
            this.lbl_CTRNumber.AutoSize = true;
            this.lbl_CTRNumber.Location = new System.Drawing.Point(57, 271);
            this.lbl_CTRNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CTRNumber.Name = "lbl_CTRNumber";
            this.lbl_CTRNumber.Size = new System.Drawing.Size(90, 17);
            this.lbl_CTRNumber.TabIndex = 24;
            this.lbl_CTRNumber.Text = "CTR Number";
            // 
            // lbl_PSNumber
            // 
            this.lbl_PSNumber.AutoSize = true;
            this.lbl_PSNumber.Location = new System.Drawing.Point(57, 306);
            this.lbl_PSNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PSNumber.Name = "lbl_PSNumber";
            this.lbl_PSNumber.Size = new System.Drawing.Size(135, 17);
            this.lbl_PSNumber.TabIndex = 27;
            this.lbl_PSNumber.Text = "People Soft Number";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(32, 27);
            this.lblComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(74, 17);
            this.lblComments.TabIndex = 28;
            this.lblComments.Text = "Comments";
            // 
            // lbl_RequiredFields
            // 
            this.lbl_RequiredFields.AutoSize = true;
            this.lbl_RequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RequiredFields.Location = new System.Drawing.Point(17, 42);
            this.lbl_RequiredFields.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RequiredFields.Name = "lbl_RequiredFields";
            this.lbl_RequiredFields.Size = new System.Drawing.Size(118, 16);
            this.lbl_RequiredFields.TabIndex = 29;
            this.lbl_RequiredFields.Text = "Required Fields";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(570, 742);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(144, 36);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(762, 742);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(144, 36);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_AddAttachment
            // 
            this.btn_AddAttachment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AddAttachment.Location = new System.Drawing.Point(599, 690);
            this.btn_AddAttachment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddAttachment.Name = "btn_AddAttachment";
            this.btn_AddAttachment.Size = new System.Drawing.Size(72, 28);
            this.btn_AddAttachment.TabIndex = 10;
            this.btn_AddAttachment.Text = "Add";
            this.btn_AddAttachment.UseVisualStyleBackColor = false;
            this.btn_AddAttachment.Click += new System.EventHandler(this.btn_AddAttachment_Click);
            // 
            // btn_RemoveAttachment
            // 
            this.btn_RemoveAttachment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_RemoveAttachment.Location = new System.Drawing.Point(834, 690);
            this.btn_RemoveAttachment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RemoveAttachment.Name = "btn_RemoveAttachment";
            this.btn_RemoveAttachment.Size = new System.Drawing.Size(72, 28);
            this.btn_RemoveAttachment.TabIndex = 34;
            this.btn_RemoveAttachment.Text = "Remove";
            this.btn_RemoveAttachment.UseVisualStyleBackColor = false;
            this.btn_RemoveAttachment.Click += new System.EventHandler(this.btn_RemoveAttachment_Click);
            // 
            // lbl_Attachments
            // 
            this.lbl_Attachments.AutoSize = true;
            this.lbl_Attachments.Location = new System.Drawing.Point(508, 501);
            this.lbl_Attachments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Attachments.Name = "lbl_Attachments";
            this.lbl_Attachments.Size = new System.Drawing.Size(86, 17);
            this.lbl_Attachments.TabIndex = 36;
            this.lbl_Attachments.Text = "Attachments";
            // 
            // grp_OptionalFields
            // 
            this.grp_OptionalFields.BackColor = System.Drawing.SystemColors.Menu;
            this.grp_OptionalFields.Controls.Add(this.txt_Comments);
            this.grp_OptionalFields.Controls.Add(this.lblComments);
            this.grp_OptionalFields.Controls.Add(this.txt_CTRNumber);
            this.grp_OptionalFields.Controls.Add(this.txt_PSNumber);
            this.grp_OptionalFields.Controls.Add(this.lbl_CTRNumber);
            this.grp_OptionalFields.Controls.Add(this.lbl_PSNumber);
            this.grp_OptionalFields.Controls.Add(this.lbl_OptionalFields);
            this.grp_OptionalFields.Location = new System.Drawing.Point(20, 444);
            this.grp_OptionalFields.Margin = new System.Windows.Forms.Padding(4);
            this.grp_OptionalFields.Name = "grp_OptionalFields";
            this.grp_OptionalFields.Padding = new System.Windows.Forms.Padding(4);
            this.grp_OptionalFields.Size = new System.Drawing.Size(463, 334);
            this.grp_OptionalFields.TabIndex = 37;
            this.grp_OptionalFields.TabStop = false;
            this.grp_OptionalFields.Tag = "L";
            // 
            // lst_FELead
            // 
            this.lst_FELead.FormattingEnabled = true;
            this.lst_FELead.ItemHeight = 16;
            this.lst_FELead.Location = new System.Drawing.Point(173, 182);
            this.lst_FELead.Name = "lst_FELead";
            this.lst_FELead.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_FELead.Size = new System.Drawing.Size(265, 84);
            this.lst_FELead.TabIndex = 4;
            this.lst_FELead.Tag = "L";
            this.lst_FELead.SelectedIndexChanged += new System.EventHandler(this.cbo_MSO_SelectedIndexChanged);
            // 
            // txtEID
            // 
            this.txtEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEID.Location = new System.Drawing.Point(356, 12);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(291, 26);
            this.txtEID.TabIndex = 40;
            this.txtEID.TabStop = false;
            this.txtEID.Tag = "L";
            this.txtEID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEID.TextChanged += new System.EventHandler(this.txtEID_TextChanged);
            // 
            // dgvAttachments
            // 
            this.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttachments.Location = new System.Drawing.Point(511, 522);
            this.dgvAttachments.Name = "dgvAttachments";
            this.dgvAttachments.Size = new System.Drawing.Size(493, 161);
            this.dgvAttachments.TabIndex = 11;
            this.dgvAttachments.TabStop = false;
            this.dgvAttachments.Tag = "L";
            this.dgvAttachments.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttachments_RowHeaderMouseClick);
            // 
            // lst_PartNumber
            // 
            this.lst_PartNumber.FormattingEnabled = true;
            this.lst_PartNumber.ItemHeight = 16;
            this.lst_PartNumber.Location = new System.Drawing.Point(173, 275);
            this.lst_PartNumber.Name = "lst_PartNumber";
            this.lst_PartNumber.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_PartNumber.Size = new System.Drawing.Size(265, 84);
            this.lst_PartNumber.TabIndex = 41;
            this.lst_PartNumber.Tag = "L";
            this.lst_PartNumber.Leave += new System.EventHandler(this.lst_PartNumber_Leave);
            // 
            // FrmATEscalations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 824);
            this.Controls.Add(this.lst_PartNumber);
            this.Controls.Add(this.dgvAttachments);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.lst_FELead);
            this.Controls.Add(this.lbl_Attachments);
            this.Controls.Add(this.btn_RemoveAttachment);
            this.Controls.Add(this.btn_AddAttachment);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_RequiredFields);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txt_Resolution);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.lbl_DateResolved);
            this.Controls.Add(this.lbl_DateReported);
            this.Controls.Add(this.dtp_DateResolved);
            this.Controls.Add(this.dtp_DateReported);
            this.Controls.Add(this.lbl_FELead);
            this.Controls.Add(this.lbl_Qty);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.lbl_PartNumbers);
            this.Controls.Add(this.lbl_EscalationStatus);
            this.Controls.Add(this.lbl_ATProdApp);
            this.Controls.Add(this.lbl_MSO);
            this.Controls.Add(this.cbo_Type);
            this.Controls.Add(this.cbo_Status);
            this.Controls.Add(this.cbo_MSO);
            this.Controls.Add(this.grp_OptionalFields);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmATEscalations";
            this.Text = "AT Escalations";
            this.Activated += new System.EventHandler(this.FrmATEscalations_Activated);
            this.Shown += new System.EventHandler(this.FrmATEscalations_Shown);
            this.grp_OptionalFields.ResumeLayout(false);
            this.grp_OptionalFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_MSO;
        private System.Windows.Forms.ComboBox cbo_Status;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.Label lbl_MSO;
        private System.Windows.Forms.Label lbl_ATProdApp;
        private System.Windows.Forms.Label lbl_EscalationStatus;
        private System.Windows.Forms.Label lbl_PartNumbers;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label lbl_Qty;
        private System.Windows.Forms.Label lbl_FELead;
        private System.Windows.Forms.DateTimePicker dtp_DateReported;
        private System.Windows.Forms.DateTimePicker dtp_DateResolved;
        private System.Windows.Forms.Label lbl_DateReported;
        private System.Windows.Forms.Label lbl_DateResolved;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_Resolution;
        private System.Windows.Forms.TextBox txt_Comments;
        private System.Windows.Forms.TextBox txt_CTRNumber;
        private System.Windows.Forms.TextBox txt_PSNumber;
        private System.Windows.Forms.Label lbl_OptionalFields;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Label lbl_CTRNumber;
        private System.Windows.Forms.Label lbl_PSNumber;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lbl_RequiredFields;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_AddAttachment;
        private System.Windows.Forms.Button btn_RemoveAttachment;
        private System.Windows.Forms.Label lbl_Attachments;
        private System.Windows.Forms.GroupBox grp_OptionalFields;
        public System.Windows.Forms.ListBox lst_FELead;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.DataGridView dgvAttachments;
        public System.Windows.Forms.ListBox lst_PartNumber;
    }
}