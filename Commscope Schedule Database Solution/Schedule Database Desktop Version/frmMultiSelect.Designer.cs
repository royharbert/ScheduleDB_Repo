﻿
namespace Schedule_Database_Desktop_Version
{
    partial class frmMultiSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultiSelect));
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(29, 3);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.Size = new System.Drawing.Size(1850, 650);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentDoubleClick);            
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(188, 680);
            this.txtCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(79, 20);
            this.txtCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 683);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Records found";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(470, 680);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(156, 36);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmMultiSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 753);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.dgvResults);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMultiSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Results";
            this.Load += new System.EventHandler(this.frmMultiSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
    }
}