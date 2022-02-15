namespace Schedule_Database_Desktop_Version
{
    partial class frmMSOPicker
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
            this.cboMSOSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMSOPicker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboMSOSelector
            // 
            this.cboMSOSelector.FormattingEnabled = true;
            this.cboMSOSelector.Location = new System.Drawing.Point(39, 57);
            this.cboMSOSelector.Name = "cboMSOSelector";
            this.cboMSOSelector.Size = new System.Drawing.Size(333, 21);
            this.cboMSOSelector.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(297, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMSOPicker
            // 
            this.lblMSOPicker.AutoSize = true;
            this.lblMSOPicker.Location = new System.Drawing.Point(36, 20);
            this.lblMSOPicker.Name = "lblMSOPicker";
            this.lblMSOPicker.Size = new System.Drawing.Size(64, 13);
            this.lblMSOPicker.TabIndex = 3;
            this.lblMSOPicker.Text = "Select MSO";
            // 
            // frmMSOPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 169);
            this.Controls.Add(this.lblMSOPicker);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMSOSelector);
            this.Name = "frmMSOPicker";
            this.Text = "MSO Selector";
            this.Load += new System.EventHandler(this.frmMSOPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMSOSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMSOPicker;
    }
}