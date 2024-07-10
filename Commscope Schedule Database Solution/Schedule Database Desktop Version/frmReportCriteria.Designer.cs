namespace Schedule_Database_Desktop_Version
{
    partial class frmReportCriteria
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
            this.btnInProcess = new System.Windows.Forms.Button();
            this.btnClosed = new System.Windows.Forms.Button();
            this.btnCanceled = new System.Windows.Forms.Button();
            this.btnAllRecords = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInProcess
            // 
            this.btnInProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInProcess.Location = new System.Drawing.Point(78, 28);
            this.btnInProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInProcess.Name = "btnInProcess";
            this.btnInProcess.Size = new System.Drawing.Size(112, 39);
            this.btnInProcess.TabIndex = 0;
            this.btnInProcess.Text = "In process";
            this.btnInProcess.UseVisualStyleBackColor = true;
            // 
            // btnClosed
            // 
            this.btnClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosed.Location = new System.Drawing.Point(78, 76);
            this.btnClosed.Margin = new System.Windows.Forms.Padding(4);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(112, 39);
            this.btnClosed.TabIndex = 1;
            this.btnClosed.Text = "Closed";
            this.btnClosed.UseVisualStyleBackColor = true;
            // 
            // btnCanceled
            // 
            this.btnCanceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanceled.Location = new System.Drawing.Point(78, 124);
            this.btnCanceled.Margin = new System.Windows.Forms.Padding(4);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(112, 39);
            this.btnCanceled.TabIndex = 2;
            this.btnCanceled.Text = "Canceled";
            this.btnCanceled.UseVisualStyleBackColor = true;
            // 
            // btnAllRecords
            // 
            this.btnAllRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRecords.Location = new System.Drawing.Point(78, 172);
            this.btnAllRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllRecords.Name = "btnAllRecords";
            this.btnAllRecords.Size = new System.Drawing.Size(112, 39);
            this.btnAllRecords.TabIndex = 3;
            this.btnAllRecords.Text = "All Records";
            this.btnAllRecords.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(13, 247);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(112, 39);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(144, 247);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmReportCriteria
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(271, 299);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnAllRecords);
            this.Controls.Add(this.btnCanceled);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.btnInProcess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReportCriteria";
            this.Text = "Report Ctiteeria";
            this.Load += new System.EventHandler(this.frmReportCriteria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInProcess;
        private System.Windows.Forms.Button btnClosed;
        private System.Windows.Forms.Button btnCanceled;
        private System.Windows.Forms.Button btnAllRecords;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnCancel;
    }
}