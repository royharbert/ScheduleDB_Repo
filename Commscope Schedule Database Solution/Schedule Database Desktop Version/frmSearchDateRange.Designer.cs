namespace Schedule_Database_Desktop_Version
{
    partial class frmSearchDateRange
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
            this.lblSelectDateRange = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDateRange = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDateRange = new System.Windows.Forms.DateTimePicker();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnSearchDateRange = new System.Windows.Forms.Button();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.rdoDateClosed = new System.Windows.Forms.RadioButton();
            this.rdoDateDue = new System.Windows.Forms.RadioButton();
            this.rdoDateCreated = new System.Windows.Forms.RadioButton();
            this.gbDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectDateRange
            // 
            this.lblSelectDateRange.AutoSize = true;
            this.lblSelectDateRange.Location = new System.Drawing.Point(57, 50);
            this.lblSelectDateRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectDateRange.Name = "lblSelectDateRange";
            this.lblSelectDateRange.Size = new System.Drawing.Size(131, 18);
            this.lblSelectDateRange.TabIndex = 28;
            this.lblSelectDateRange.Text = "Select Date Range";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(62, 158);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 18);
            this.lblEndDate.TabIndex = 27;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(57, 108);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 18);
            this.lblStartDate.TabIndex = 26;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpEndDateRange
            // 
            this.dtpEndDateRange.Location = new System.Drawing.Point(172, 158);
            this.dtpEndDateRange.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDateRange.Name = "dtpEndDateRange";
            this.dtpEndDateRange.Size = new System.Drawing.Size(298, 24);
            this.dtpEndDateRange.TabIndex = 24;
            // 
            // dtpStartDateRange
            // 
            this.dtpStartDateRange.Location = new System.Drawing.Point(172, 108);
            this.dtpStartDateRange.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDateRange.Name = "dtpStartDateRange";
            this.dtpStartDateRange.Size = new System.Drawing.Size(298, 24);
            this.dtpStartDateRange.TabIndex = 23;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(307, 217);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(143, 32);
            this.btnCloseForm.TabIndex = 22;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click_1);
            // 
            // btnSearchDateRange
            // 
            this.btnSearchDateRange.Location = new System.Drawing.Point(105, 217);
            this.btnSearchDateRange.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDateRange.Name = "btnSearchDateRange";
            this.btnSearchDateRange.Size = new System.Drawing.Size(148, 32);
            this.btnSearchDateRange.TabIndex = 21;
            this.btnSearchDateRange.Text = "Search";
            this.btnSearchDateRange.UseVisualStyleBackColor = true;
            this.btnSearchDateRange.Click += new System.EventHandler(this.btnSearchDateRange_Click);
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.rdoDateClosed);
            this.gbDate.Controls.Add(this.rdoDateDue);
            this.gbDate.Controls.Add(this.rdoDateCreated);
            this.gbDate.Location = new System.Drawing.Point(520, 50);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(263, 200);
            this.gbDate.TabIndex = 29;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date Type";
            // 
            // rdoDateClosed
            // 
            this.rdoDateClosed.AutoSize = true;
            this.rdoDateClosed.Location = new System.Drawing.Point(11, 145);
            this.rdoDateClosed.Name = "rdoDateClosed";
            this.rdoDateClosed.Size = new System.Drawing.Size(108, 22);
            this.rdoDateClosed.TabIndex = 2;
            this.rdoDateClosed.TabStop = true;
            this.rdoDateClosed.Text = "Date Closed";
            this.rdoDateClosed.UseVisualStyleBackColor = true;
            this.rdoDateClosed.CheckedChanged += new System.EventHandler(this.rdoDateClosed_CheckedChanged);
            // 
            // rdoDateDue
            // 
            this.rdoDateDue.AutoSize = true;
            this.rdoDateDue.Location = new System.Drawing.Point(11, 81);
            this.rdoDateDue.Name = "rdoDateDue";
            this.rdoDateDue.Size = new System.Drawing.Size(88, 22);
            this.rdoDateDue.TabIndex = 1;
            this.rdoDateDue.TabStop = true;
            this.rdoDateDue.Text = "Date Due";
            this.rdoDateDue.UseVisualStyleBackColor = true;
            this.rdoDateDue.CheckedChanged += new System.EventHandler(this.rdoDateDue_CheckedChanged);
            // 
            // rdoDateCreated
            // 
            this.rdoDateCreated.AutoSize = true;
            this.rdoDateCreated.Location = new System.Drawing.Point(11, 23);
            this.rdoDateCreated.Name = "rdoDateCreated";
            this.rdoDateCreated.Size = new System.Drawing.Size(113, 22);
            this.rdoDateCreated.TabIndex = 0;
            this.rdoDateCreated.TabStop = true;
            this.rdoDateCreated.Text = "Date Created";
            this.rdoDateCreated.UseVisualStyleBackColor = true;
            this.rdoDateCreated.CheckedChanged += new System.EventHandler(this.rdoDateCreated_CheckedChanged);
            // 
            // frmSearchDateRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 292);
            this.Controls.Add(this.gbDate);
            this.Controls.Add(this.lblSelectDateRange);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDateRange);
            this.Controls.Add(this.dtpStartDateRange);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnSearchDateRange);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearchDateRange";
            this.Text = "Search Date Range";
            this.Load += new System.EventHandler(this.frmSearchDateRange_Load);
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectDateRange;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDateRange;
        private System.Windows.Forms.DateTimePicker dtpStartDateRange;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnSearchDateRange;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.RadioButton rdoDateDue;
        private System.Windows.Forms.RadioButton rdoDateCreated;
        private System.Windows.Forms.RadioButton rdoDateClosed;
    }
}