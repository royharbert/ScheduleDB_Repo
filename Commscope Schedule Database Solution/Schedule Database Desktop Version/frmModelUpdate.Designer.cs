
namespace Schedule_Database_Desktop_Version
{
    partial class frmModelUpdate
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
            this.dgvModel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFE = new System.Windows.Forms.RadioButton();
            this.rdoUser = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvModel
            // 
            this.dgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModel.Location = new System.Drawing.Point(14, 28);
            this.dgvModel.Name = "dgvModel";
            this.dgvModel.Size = new System.Drawing.Size(780, 260);
            this.dgvModel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoUser);
            this.groupBox1.Controls.Add(this.rdoFE);
            this.groupBox1.Location = new System.Drawing.Point(55, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdoFE
            // 
            this.rdoFE.AutoSize = true;
            this.rdoFE.Location = new System.Drawing.Point(17, 16);
            this.rdoFE.Name = "rdoFE";
            this.rdoFE.Size = new System.Drawing.Size(38, 17);
            this.rdoFE.TabIndex = 0;
            this.rdoFE.TabStop = true;
            this.rdoFE.Text = "FE";
            this.rdoFE.UseVisualStyleBackColor = true;
            this.rdoFE.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoUser
            // 
            this.rdoUser.AutoSize = true;
            this.rdoUser.Location = new System.Drawing.Point(17, 39);
            this.rdoUser.Name = "rdoUser";
            this.rdoUser.Size = new System.Drawing.Size(52, 17);
            this.rdoUser.TabIndex = 1;
            this.rdoUser.TabStop = true;
            this.rdoUser.Text = "Users";
            this.rdoUser.UseVisualStyleBackColor = true;
            this.rdoUser.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // frmModelUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvModel);
            this.Name = "frmModelUpdate";
            this.Text = "frm";
            this.Load += new System.EventHandler(this.frmModelUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoUser;
        private System.Windows.Forms.RadioButton rdoFE;
    }
}