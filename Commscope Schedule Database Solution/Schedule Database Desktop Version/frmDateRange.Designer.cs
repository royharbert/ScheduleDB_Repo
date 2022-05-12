
namespace Schedule_Database_Desktop_Version
{
    partial class frmDateRange
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
            this.btnSearchDateRange = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.dtpStartDateRange = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDateRange = new System.Windows.Forms.DateTimePicker();
            this.rdbOrderByStartDate = new System.Windows.Forms.RadioButton();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblSelectDateRange = new System.Windows.Forms.Label();
            this.rdbOrderByFE = new System.Windows.Forms.RadioButton();
            this.rdbOrderByRegion = new System.Windows.Forms.RadioButton();
            this.rdbOrderByMSO = new System.Windows.Forms.RadioButton();
            this.rdbOrderByRequestID = new System.Windows.Forms.RadioButton();
            this.rdbOrderByProduct = new System.Windows.Forms.RadioButton();
            this.rdbOrderByActivity = new System.Windows.Forms.RadioButton();
            this.rdbOrderByEndDate = new System.Windows.Forms.RadioButton();
            this.rdbOrderByCustReqDate = new System.Windows.Forms.RadioButton();
            this.gbxDateRangeOrderBy = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnSearchDateRange
            // 
            this.btnSearchDateRange.Location = new System.Drawing.Point(371, 73);
            this.btnSearchDateRange.Name = "btnSearchDateRange";
            this.btnSearchDateRange.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDateRange.TabIndex = 0;
            this.btnSearchDateRange.Text = "Search";
            this.btnSearchDateRange.UseVisualStyleBackColor = true;
            this.btnSearchDateRange.Click += new System.EventHandler(this.btnSearchDateRange_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(371, 109);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // dtpStartDateRange
            // 
            this.dtpStartDateRange.Location = new System.Drawing.Point(107, 73);
            this.dtpStartDateRange.Name = "dtpStartDateRange";
            this.dtpStartDateRange.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDateRange.TabIndex = 2;
            // 
            // dtpEndDateRange
            // 
            this.dtpEndDateRange.Location = new System.Drawing.Point(107, 109);
            this.dtpEndDateRange.Name = "dtpEndDateRange";
            this.dtpEndDateRange.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDateRange.TabIndex = 3;
            // 
            // rdbOrderByStartDate
            // 
            this.rdbOrderByStartDate.AutoSize = true;
            this.rdbOrderByStartDate.Checked = true;
            this.rdbOrderByStartDate.Location = new System.Drawing.Point(33, 181);
            this.rdbOrderByStartDate.Name = "rdbOrderByStartDate";
            this.rdbOrderByStartDate.Size = new System.Drawing.Size(73, 17);
            this.rdbOrderByStartDate.TabIndex = 4;
            this.rdbOrderByStartDate.TabStop = true;
            this.rdbOrderByStartDate.Tag = "StartDate";
            this.rdbOrderByStartDate.Text = "Start Date";
            this.rdbOrderByStartDate.UseVisualStyleBackColor = true;
            this.rdbOrderByStartDate.CheckedChanged += new System.EventHandler(this.rdbOrderByStartDate_CheckedChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(30, 73);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(33, 109);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date";
            // 
            // lblSelectDateRange
            // 
            this.lblSelectDateRange.AutoSize = true;
            this.lblSelectDateRange.Location = new System.Drawing.Point(30, 31);
            this.lblSelectDateRange.Name = "lblSelectDateRange";
            this.lblSelectDateRange.Size = new System.Drawing.Size(98, 13);
            this.lblSelectDateRange.TabIndex = 9;
            this.lblSelectDateRange.Text = "Select Date Range";
            // 
            // rdbOrderByFE
            // 
            this.rdbOrderByFE.AutoSize = true;
            this.rdbOrderByFE.Location = new System.Drawing.Point(181, 227);
            this.rdbOrderByFE.Name = "rdbOrderByFE";
            this.rdbOrderByFE.Size = new System.Drawing.Size(92, 17);
            this.rdbOrderByFE.TabIndex = 11;
            this.rdbOrderByFE.Tag = "FE";
            this.rdbOrderByFE.Text = "Field Engineer";
            this.rdbOrderByFE.UseVisualStyleBackColor = true;
            this.rdbOrderByFE.CheckedChanged += new System.EventHandler(this.rdbOrderByFE_CheckedChanged);
            // 
            // rdbOrderByRegion
            // 
            this.rdbOrderByRegion.AutoSize = true;
            this.rdbOrderByRegion.Location = new System.Drawing.Point(181, 181);
            this.rdbOrderByRegion.Name = "rdbOrderByRegion";
            this.rdbOrderByRegion.Size = new System.Drawing.Size(59, 17);
            this.rdbOrderByRegion.TabIndex = 12;
            this.rdbOrderByRegion.Tag = "Region";
            this.rdbOrderByRegion.Text = "Region";
            this.rdbOrderByRegion.UseVisualStyleBackColor = true;
            this.rdbOrderByRegion.CheckedChanged += new System.EventHandler(this.rdbOrderByRegion_CheckedChanged);
            // 
            // rdbOrderByMSO
            // 
            this.rdbOrderByMSO.AutoSize = true;
            this.rdbOrderByMSO.Location = new System.Drawing.Point(181, 204);
            this.rdbOrderByMSO.Name = "rdbOrderByMSO";
            this.rdbOrderByMSO.Size = new System.Drawing.Size(49, 17);
            this.rdbOrderByMSO.TabIndex = 13;
            this.rdbOrderByMSO.Tag = "MSO_ID";
            this.rdbOrderByMSO.Text = "MSO";
            this.rdbOrderByMSO.UseVisualStyleBackColor = true;
            this.rdbOrderByMSO.CheckedChanged += new System.EventHandler(this.rdbOrderByMSO_CheckedChanged);
            // 
            // rdbOrderByRequestID
            // 
            this.rdbOrderByRequestID.AutoSize = true;
            this.rdbOrderByRequestID.Location = new System.Drawing.Point(291, 204);
            this.rdbOrderByRequestID.Name = "rdbOrderByRequestID";
            this.rdbOrderByRequestID.Size = new System.Drawing.Size(79, 17);
            this.rdbOrderByRequestID.TabIndex = 14;
            this.rdbOrderByRequestID.Tag = "RequestID";
            this.rdbOrderByRequestID.Text = "Request ID";
            this.rdbOrderByRequestID.UseVisualStyleBackColor = true;
            this.rdbOrderByRequestID.CheckedChanged += new System.EventHandler(this.rdbOrderByRequestID_CheckedChanged);
            // 
            // rdbOrderByProduct
            // 
            this.rdbOrderByProduct.AutoSize = true;
            this.rdbOrderByProduct.Location = new System.Drawing.Point(291, 227);
            this.rdbOrderByProduct.Name = "rdbOrderByProduct";
            this.rdbOrderByProduct.Size = new System.Drawing.Size(62, 17);
            this.rdbOrderByProduct.TabIndex = 15;
            this.rdbOrderByProduct.Tag = "Product";
            this.rdbOrderByProduct.Text = "Product";
            this.rdbOrderByProduct.UseVisualStyleBackColor = true;
            this.rdbOrderByProduct.CheckedChanged += new System.EventHandler(this.rdbOrderByProduct_CheckedChanged);
            // 
            // rdbOrderByActivity
            // 
            this.rdbOrderByActivity.AutoSize = true;
            this.rdbOrderByActivity.Location = new System.Drawing.Point(291, 181);
            this.rdbOrderByActivity.Name = "rdbOrderByActivity";
            this.rdbOrderByActivity.Size = new System.Drawing.Size(59, 17);
            this.rdbOrderByActivity.TabIndex = 17;
            this.rdbOrderByActivity.Tag = "Activity";
            this.rdbOrderByActivity.Text = "Activity";
            this.rdbOrderByActivity.UseVisualStyleBackColor = true;
            this.rdbOrderByActivity.CheckedChanged += new System.EventHandler(this.rdbOrderByActivity_CheckedChanged);
            // 
            // rdbOrderByEndDate
            // 
            this.rdbOrderByEndDate.AutoSize = true;
            this.rdbOrderByEndDate.Location = new System.Drawing.Point(33, 204);
            this.rdbOrderByEndDate.Name = "rdbOrderByEndDate";
            this.rdbOrderByEndDate.Size = new System.Drawing.Size(70, 17);
            this.rdbOrderByEndDate.TabIndex = 18;
            this.rdbOrderByEndDate.Tag = "EndDate";
            this.rdbOrderByEndDate.Text = "End Date";
            this.rdbOrderByEndDate.UseVisualStyleBackColor = true;
            this.rdbOrderByEndDate.CheckedChanged += new System.EventHandler(this.rdbOrderByEndDate_CheckedChanged);
            // 
            // rdbOrderByCustReqDate
            // 
            this.rdbOrderByCustReqDate.AutoSize = true;
            this.rdbOrderByCustReqDate.Location = new System.Drawing.Point(33, 227);
            this.rdbOrderByCustReqDate.Name = "rdbOrderByCustReqDate";
            this.rdbOrderByCustReqDate.Size = new System.Drawing.Size(138, 17);
            this.rdbOrderByCustReqDate.TabIndex = 19;
            this.rdbOrderByCustReqDate.Tag = "CustReqDate";
            this.rdbOrderByCustReqDate.Text = "Customer Request Date";
            this.rdbOrderByCustReqDate.UseVisualStyleBackColor = true;
            this.rdbOrderByCustReqDate.CheckedChanged += new System.EventHandler(this.rdbOrderByCustReqDate_CheckedChanged);
            // 
            // gbxDateRangeOrderBy
            // 
            this.gbxDateRangeOrderBy.Location = new System.Drawing.Point(30, 154);
            this.gbxDateRangeOrderBy.Name = "gbxDateRangeOrderBy";
            this.gbxDateRangeOrderBy.Size = new System.Drawing.Size(340, 100);
            this.gbxDateRangeOrderBy.TabIndex = 20;
            this.gbxDateRangeOrderBy.TabStop = false;
            this.gbxDateRangeOrderBy.Text = "Order By";
            // 
            // frmDateRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 151);
            this.Controls.Add(this.rdbOrderByCustReqDate);
            this.Controls.Add(this.rdbOrderByEndDate);
            this.Controls.Add(this.rdbOrderByStartDate);
            this.Controls.Add(this.rdbOrderByActivity);
            this.Controls.Add(this.rdbOrderByProduct);
            this.Controls.Add(this.rdbOrderByRequestID);
            this.Controls.Add(this.rdbOrderByMSO);
            this.Controls.Add(this.rdbOrderByRegion);
            this.Controls.Add(this.rdbOrderByFE);
            this.Controls.Add(this.lblSelectDateRange);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDateRange);
            this.Controls.Add(this.dtpStartDateRange);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnSearchDateRange);
            this.Controls.Add(this.gbxDateRangeOrderBy);
            this.Name = "frmDateRange";
            this.Text = "frmDateRange";
            this.Load += new System.EventHandler(this.frmDateRange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDateRange;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.DateTimePicker dtpStartDateRange;
        private System.Windows.Forms.DateTimePicker dtpEndDateRange;
        private System.Windows.Forms.RadioButton rdbOrderByStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblSelectDateRange;
        private System.Windows.Forms.RadioButton rdbOrderByFE;
        private System.Windows.Forms.RadioButton rdbOrderByRegion;
        private System.Windows.Forms.RadioButton rdbOrderByMSO;
        private System.Windows.Forms.RadioButton rdbOrderByRequestID;
        private System.Windows.Forms.RadioButton rdbOrderByProduct;
        private System.Windows.Forms.RadioButton rdbOrderByActivity;
        private System.Windows.Forms.RadioButton rdbOrderByEndDate;
        private System.Windows.Forms.RadioButton rdbOrderByCustReqDate;
        private System.Windows.Forms.GroupBox gbxDateRangeOrderBy;
    }
}