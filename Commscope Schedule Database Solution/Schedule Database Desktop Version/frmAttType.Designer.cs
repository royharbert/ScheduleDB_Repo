
namespace Schedule_Database_Desktop_Version
{
    partial class frmAttType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttType));
            this.gbxAttType = new System.Windows.Forms.GroupBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.rdoWRE = new System.Windows.Forms.RadioButton();
            this.rdoTripRpt = new System.Windows.Forms.RadioButton();
            this.rdoCRM = new System.Windows.Forms.RadioButton();
            this.rdoDocCovid = new System.Windows.Forms.RadioButton();
            this.gbxAttType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAttType
            // 
            this.gbxAttType.Controls.Add(this.txtOther);
            this.gbxAttType.Controls.Add(this.rdoOther);
            this.gbxAttType.Controls.Add(this.btnCancel);
            this.gbxAttType.Controls.Add(this.btnOK);
            this.gbxAttType.Controls.Add(this.rdoWRE);
            this.gbxAttType.Controls.Add(this.rdoTripRpt);
            this.gbxAttType.Controls.Add(this.rdoCRM);
            this.gbxAttType.Controls.Add(this.rdoDocCovid);
            this.gbxAttType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxAttType.Location = new System.Drawing.Point(12, 12);
            this.gbxAttType.Name = "gbxAttType";
            this.gbxAttType.Size = new System.Drawing.Size(255, 451);
            this.gbxAttType.TabIndex = 1;
            this.gbxAttType.TabStop = false;
            this.gbxAttType.Text = "Attachment Type";
            // 
            // txtOther
            // 
            this.txtOther.Enabled = false;
            this.txtOther.Location = new System.Drawing.Point(29, 244);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(203, 29);
            this.txtOther.TabIndex = 18;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(35, 206);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(75, 28);
            this.rdoOther.TabIndex = 17;
            this.rdoOther.TabStop = true;
            this.rdoOther.Tag = "Other";
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.rdoOther_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(17, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(218, 45);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOK.Location = new System.Drawing.Point(17, 349);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(218, 45);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rdoWRE
            // 
            this.rdoWRE.AutoSize = true;
            this.rdoWRE.Location = new System.Drawing.Point(34, 138);
            this.rdoWRE.Name = "rdoWRE";
            this.rdoWRE.Size = new System.Drawing.Size(204, 28);
            this.rdoWRE.TabIndex = 4;
            this.rdoWRE.TabStop = true;
            this.rdoWRE.Tag = "Product Specification";
            this.rdoWRE.Text = "Product Specification";
            this.rdoWRE.UseVisualStyleBackColor = true;
            this.rdoWRE.CheckedChanged += new System.EventHandler(this.rdoWRE_CheckedChanged);
            // 
            // rdoTripRpt
            // 
            this.rdoTripRpt.AutoSize = true;
            this.rdoTripRpt.Location = new System.Drawing.Point(34, 104);
            this.rdoTripRpt.Name = "rdoTripRpt";
            this.rdoTripRpt.Size = new System.Drawing.Size(101, 28);
            this.rdoTripRpt.TabIndex = 3;
            this.rdoTripRpt.TabStop = true;
            this.rdoTripRpt.Tag = "Lab Data";
            this.rdoTripRpt.Text = "Lab Data";
            this.rdoTripRpt.UseVisualStyleBackColor = true;
            this.rdoTripRpt.CheckedChanged += new System.EventHandler(this.rdoTripRpt_CheckedChanged);
            // 
            // rdoCRM
            // 
            this.rdoCRM.AutoSize = true;
            this.rdoCRM.Location = new System.Drawing.Point(34, 70);
            this.rdoCRM.Name = "rdoCRM";
            this.rdoCRM.Size = new System.Drawing.Size(120, 28);
            this.rdoCRM.TabIndex = 2;
            this.rdoCRM.TabStop = true;
            this.rdoCRM.Tag = "Lab Report";
            this.rdoCRM.Text = "Lab Report";
            this.rdoCRM.UseVisualStyleBackColor = true;
            this.rdoCRM.CheckedChanged += new System.EventHandler(this.rdoCRM_CheckedChanged);
            // 
            // rdoDocCovid
            // 
            this.rdoDocCovid.AutoSize = true;
            this.rdoDocCovid.Location = new System.Drawing.Point(34, 36);
            this.rdoDocCovid.Name = "rdoDocCovid";
            this.rdoDocCovid.Size = new System.Drawing.Size(81, 28);
            this.rdoDocCovid.TabIndex = 1;
            this.rdoDocCovid.TabStop = true;
            this.rdoDocCovid.Tag = "E-Mail";
            this.rdoDocCovid.Text = "E-Mail";
            this.rdoDocCovid.UseVisualStyleBackColor = true;
            this.rdoDocCovid.CheckedChanged += new System.EventHandler(this.rdoDocCovid_CheckedChanged);
            // 
            // frmAttType
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(279, 484);
            this.Controls.Add(this.gbxAttType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAttType";
            this.Text = "Attachments";
            this.Load += new System.EventHandler(this.frmAttType_Load);
            this.gbxAttType.ResumeLayout(false);
            this.gbxAttType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAttType;
        private System.Windows.Forms.RadioButton rdoWRE;
        private System.Windows.Forms.RadioButton rdoTripRpt;
        private System.Windows.Forms.RadioButton rdoCRM;
        private System.Windows.Forms.RadioButton rdoDocCovid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.TextBox txtOther;
    }
}