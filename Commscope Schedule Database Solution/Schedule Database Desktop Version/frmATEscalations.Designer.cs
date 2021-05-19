
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
            this.cbo_FELead = new System.Windows.Forms.ComboBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Attachments = new System.Windows.Forms.Label();
            this.grp_OptionalFields = new System.Windows.Forms.GroupBox();
            this.cbo_PartNumber1 = new System.Windows.Forms.ComboBox();
            this.cbo_PartNumber2 = new System.Windows.Forms.ComboBox();
            this.cbo_PartNumber3 = new System.Windows.Forms.ComboBox();
            this.grp_OptionalFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_MSO
            // 
            this.cbo_MSO.FormattingEnabled = true;
            this.cbo_MSO.Location = new System.Drawing.Point(130, 40);
            this.cbo_MSO.Name = "cbo_MSO";
            this.cbo_MSO.Size = new System.Drawing.Size(200, 21);
            this.cbo_MSO.TabIndex = 0;
            // 
            // cbo_Status
            // 
            this.cbo_Status.FormattingEnabled = true;
            this.cbo_Status.Location = new System.Drawing.Point(130, 109);
            this.cbo_Status.Name = "cbo_Status";
            this.cbo_Status.Size = new System.Drawing.Size(200, 21);
            this.cbo_Status.TabIndex = 1;
            // 
            // cbo_Type
            // 
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(130, 77);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(200, 21);
            this.cbo_Type.TabIndex = 2;
            // 
            // lbl_MSO
            // 
            this.lbl_MSO.AutoSize = true;
            this.lbl_MSO.Location = new System.Drawing.Point(27, 43);
            this.lbl_MSO.Name = "lbl_MSO";
            this.lbl_MSO.Size = new System.Drawing.Size(31, 13);
            this.lbl_MSO.TabIndex = 3;
            this.lbl_MSO.Text = "MSO";
            // 
            // lbl_ATProdApp
            // 
            this.lbl_ATProdApp.AutoSize = true;
            this.lbl_ATProdApp.Location = new System.Drawing.Point(27, 80);
            this.lbl_ATProdApp.Name = "lbl_ATProdApp";
            this.lbl_ATProdApp.Size = new System.Drawing.Size(31, 13);
            this.lbl_ATProdApp.TabIndex = 4;
            this.lbl_ATProdApp.Text = "Type";
            // 
            // lbl_EscalationStatus
            // 
            this.lbl_EscalationStatus.AutoSize = true;
            this.lbl_EscalationStatus.Location = new System.Drawing.Point(27, 112);
            this.lbl_EscalationStatus.Name = "lbl_EscalationStatus";
            this.lbl_EscalationStatus.Size = new System.Drawing.Size(37, 13);
            this.lbl_EscalationStatus.TabIndex = 5;
            this.lbl_EscalationStatus.Text = "Status";
            // 
            // lbl_PartNumbers
            // 
            this.lbl_PartNumbers.AutoSize = true;
            this.lbl_PartNumbers.Location = new System.Drawing.Point(27, 236);
            this.lbl_PartNumbers.Name = "lbl_PartNumbers";
            this.lbl_PartNumbers.Size = new System.Drawing.Size(77, 13);
            this.lbl_PartNumbers.TabIndex = 6;
            this.lbl_PartNumbers.Text = "Part Number(s)";
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(130, 149);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(200, 20);
            this.txt_Qty.TabIndex = 8;
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.AutoSize = true;
            this.lbl_Qty.Location = new System.Drawing.Point(27, 152);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(46, 13);
            this.lbl_Qty.TabIndex = 9;
            this.lbl_Qty.Text = "Quantity";
            // 
            // cbo_FELead
            // 
            this.cbo_FELead.FormattingEnabled = true;
            this.cbo_FELead.Location = new System.Drawing.Point(130, 184);
            this.cbo_FELead.Name = "cbo_FELead";
            this.cbo_FELead.Size = new System.Drawing.Size(200, 21);
            this.cbo_FELead.TabIndex = 10;
            // 
            // lbl_FELead
            // 
            this.lbl_FELead.AutoSize = true;
            this.lbl_FELead.Location = new System.Drawing.Point(27, 187);
            this.lbl_FELead.Name = "lbl_FELead";
            this.lbl_FELead.Size = new System.Drawing.Size(31, 13);
            this.lbl_FELead.TabIndex = 11;
            this.lbl_FELead.Text = "Lead";
            // 
            // dtp_DateReported
            // 
            this.dtp_DateReported.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateReported.Location = new System.Drawing.Point(130, 338);
            this.dtp_DateReported.Name = "dtp_DateReported";
            this.dtp_DateReported.Size = new System.Drawing.Size(200, 20);
            this.dtp_DateReported.TabIndex = 12;
            // 
            // dtp_DateResolved
            // 
            this.dtp_DateResolved.CustomFormat = " ";
            this.dtp_DateResolved.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateResolved.Location = new System.Drawing.Point(130, 364);
            this.dtp_DateResolved.Name = "dtp_DateResolved";
            this.dtp_DateResolved.Size = new System.Drawing.Size(200, 20);
            this.dtp_DateResolved.TabIndex = 13;
            // 
            // lbl_DateReported
            // 
            this.lbl_DateReported.AutoSize = true;
            this.lbl_DateReported.Location = new System.Drawing.Point(27, 338);
            this.lbl_DateReported.Name = "lbl_DateReported";
            this.lbl_DateReported.Size = new System.Drawing.Size(77, 13);
            this.lbl_DateReported.TabIndex = 14;
            this.lbl_DateReported.Text = "Date Reported";
            // 
            // lbl_DateResolved
            // 
            this.lbl_DateResolved.AutoSize = true;
            this.lbl_DateResolved.Location = new System.Drawing.Point(27, 364);
            this.lbl_DateResolved.Name = "lbl_DateResolved";
            this.lbl_DateResolved.Size = new System.Drawing.Size(78, 13);
            this.lbl_DateResolved.TabIndex = 15;
            this.lbl_DateResolved.Text = "Date Resolved";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(388, 21);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Description.Size = new System.Drawing.Size(391, 186);
            this.txt_Description.TabIndex = 16;
            // 
            // txt_Resolution
            // 
            this.txt_Resolution.Location = new System.Drawing.Point(388, 242);
            this.txt_Resolution.Multiline = true;
            this.txt_Resolution.Name = "txt_Resolution";
            this.txt_Resolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Resolution.Size = new System.Drawing.Size(391, 186);
            this.txt_Resolution.TabIndex = 17;
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(14, 38);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Comments.Size = new System.Drawing.Size(384, 106);
            this.txt_Comments.TabIndex = 18;
            // 
            // txt_CTRNumber
            // 
            this.txt_CTRNumber.Location = new System.Drawing.Point(159, 161);
            this.txt_CTRNumber.Name = "txt_CTRNumber";
            this.txt_CTRNumber.Size = new System.Drawing.Size(162, 20);
            this.txt_CTRNumber.TabIndex = 19;
            // 
            // txt_PSNumber
            // 
            this.txt_PSNumber.Location = new System.Drawing.Point(159, 193);
            this.txt_PSNumber.Name = "txt_PSNumber";
            this.txt_PSNumber.Size = new System.Drawing.Size(162, 20);
            this.txt_PSNumber.TabIndex = 20;
            // 
            // lbl_OptionalFields
            // 
            this.lbl_OptionalFields.AutoSize = true;
            this.lbl_OptionalFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionalFields.Location = new System.Drawing.Point(384, 447);
            this.lbl_OptionalFields.Name = "lbl_OptionalFields";
            this.lbl_OptionalFields.Size = new System.Drawing.Size(117, 17);
            this.lbl_OptionalFields.TabIndex = 21;
            this.lbl_OptionalFields.Text = "Optional Fields";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(384, 4);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(388, 226);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(57, 13);
            this.lblResolution.TabIndex = 23;
            this.lblResolution.Text = "Resolution";
            // 
            // lbl_CTRNumber
            // 
            this.lbl_CTRNumber.AutoSize = true;
            this.lbl_CTRNumber.Location = new System.Drawing.Point(43, 168);
            this.lbl_CTRNumber.Name = "lbl_CTRNumber";
            this.lbl_CTRNumber.Size = new System.Drawing.Size(69, 13);
            this.lbl_CTRNumber.TabIndex = 24;
            this.lbl_CTRNumber.Text = "CTR Number";
            // 
            // lbl_PSNumber
            // 
            this.lbl_PSNumber.AutoSize = true;
            this.lbl_PSNumber.Location = new System.Drawing.Point(43, 197);
            this.lbl_PSNumber.Name = "lbl_PSNumber";
            this.lbl_PSNumber.Size = new System.Drawing.Size(102, 13);
            this.lbl_PSNumber.TabIndex = 27;
            this.lbl_PSNumber.Text = "People Soft Number";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(24, 22);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 28;
            this.lblComments.Text = "Comments";
            // 
            // lbl_RequiredFields
            // 
            this.lbl_RequiredFields.AutoSize = true;
            this.lbl_RequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RequiredFields.Location = new System.Drawing.Point(12, 4);
            this.lbl_RequiredFields.Name = "lbl_RequiredFields";
            this.lbl_RequiredFields.Size = new System.Drawing.Size(119, 16);
            this.lbl_RequiredFields.TabIndex = 29;
            this.lbl_RequiredFields.Text = "Required Fields";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(555, 704);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 45);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(681, 704);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(108, 45);
            this.btn_Close.TabIndex = 30;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_AddAttachment
            // 
            this.btn_AddAttachment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AddAttachment.Location = new System.Drawing.Point(50, 568);
            this.btn_AddAttachment.Name = "btn_AddAttachment";
            this.btn_AddAttachment.Size = new System.Drawing.Size(129, 35);
            this.btn_AddAttachment.TabIndex = 33;
            this.btn_AddAttachment.Text = "Add Attachments";
            this.btn_AddAttachment.UseVisualStyleBackColor = false;
            // 
            // btn_RemoveAttachment
            // 
            this.btn_RemoveAttachment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_RemoveAttachment.Location = new System.Drawing.Point(185, 568);
            this.btn_RemoveAttachment.Name = "btn_RemoveAttachment";
            this.btn_RemoveAttachment.Size = new System.Drawing.Size(129, 35);
            this.btn_RemoveAttachment.TabIndex = 34;
            this.btn_RemoveAttachment.Text = "Remove Attachment";
            this.btn_RemoveAttachment.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 427);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(325, 135);
            this.textBox1.TabIndex = 35;
            // 
            // lbl_Attachments
            // 
            this.lbl_Attachments.AutoSize = true;
            this.lbl_Attachments.Location = new System.Drawing.Point(27, 411);
            this.lbl_Attachments.Name = "lbl_Attachments";
            this.lbl_Attachments.Size = new System.Drawing.Size(66, 13);
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
            this.grp_OptionalFields.Location = new System.Drawing.Point(377, 447);
            this.grp_OptionalFields.Name = "grp_OptionalFields";
            this.grp_OptionalFields.Size = new System.Drawing.Size(412, 242);
            this.grp_OptionalFields.TabIndex = 37;
            this.grp_OptionalFields.TabStop = false;
            // 
            // cbo_PartNumber1
            // 
            this.cbo_PartNumber1.FormattingEnabled = true;
            this.cbo_PartNumber1.Location = new System.Drawing.Point(130, 236);
            this.cbo_PartNumber1.Name = "cbo_PartNumber1";
            this.cbo_PartNumber1.Size = new System.Drawing.Size(200, 21);
            this.cbo_PartNumber1.TabIndex = 38;
            // 
            // cbo_PartNumber2
            // 
            this.cbo_PartNumber2.FormattingEnabled = true;
            this.cbo_PartNumber2.Location = new System.Drawing.Point(130, 263);
            this.cbo_PartNumber2.Name = "cbo_PartNumber2";
            this.cbo_PartNumber2.Size = new System.Drawing.Size(200, 21);
            this.cbo_PartNumber2.TabIndex = 39;
            this.cbo_PartNumber2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbo_PartNumber3
            // 
            this.cbo_PartNumber3.FormattingEnabled = true;
            this.cbo_PartNumber3.Location = new System.Drawing.Point(130, 290);
            this.cbo_PartNumber3.Name = "cbo_PartNumber3";
            this.cbo_PartNumber3.Size = new System.Drawing.Size(200, 21);
            this.cbo_PartNumber3.TabIndex = 40;
            // 
            // FrmATEscalations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 761);
            this.Controls.Add(this.cbo_PartNumber3);
            this.Controls.Add(this.cbo_PartNumber2);
            this.Controls.Add(this.cbo_PartNumber1);
            this.Controls.Add(this.lbl_Attachments);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_RemoveAttachment);
            this.Controls.Add(this.btn_AddAttachment);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_RequiredFields);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lbl_OptionalFields);
            this.Controls.Add(this.txt_Resolution);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.lbl_DateResolved);
            this.Controls.Add(this.lbl_DateReported);
            this.Controls.Add(this.dtp_DateResolved);
            this.Controls.Add(this.dtp_DateReported);
            this.Controls.Add(this.lbl_FELead);
            this.Controls.Add(this.cbo_FELead);
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
            this.Name = "FrmATEscalations";
            this.Text = "AT Escalations";
            this.grp_OptionalFields.ResumeLayout(false);
            this.grp_OptionalFields.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbo_FELead;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Attachments;
        private System.Windows.Forms.GroupBox grp_OptionalFields;
        private System.Windows.Forms.ComboBox cbo_PartNumber1;
        private System.Windows.Forms.ComboBox cbo_PartNumber2;
        private System.Windows.Forms.ComboBox cbo_PartNumber3;
    }
}