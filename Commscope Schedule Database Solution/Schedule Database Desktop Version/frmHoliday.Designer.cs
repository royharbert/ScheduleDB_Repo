namespace Schedule_Database_Desktop_Version
{
    partial class frmHoliday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoliday));
            this.dgvHolidays = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHoliday = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNewHoliday = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolidays)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHolidays
            // 
            this.dgvHolidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHolidays.Location = new System.Drawing.Point(22, 41);
            this.dgvHolidays.Name = "dgvHolidays";
            this.dgvHolidays.RowHeadersWidth = 62;
            this.dgvHolidays.Size = new System.Drawing.Size(385, 339);
            this.dgvHolidays.TabIndex = 0;
            this.dgvHolidays.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHolidays_CellClick);
            this.dgvHolidays.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHolidays_CellEndEdit);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSave.Location = new System.Drawing.Point(22, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 39);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClose.Location = new System.Drawing.Point(230, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Holiday Name";
            // 
            // dtpHoliday
            // 
            this.dtpHoliday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpHoliday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHoliday.Location = new System.Drawing.Point(115, 63);
            this.dtpHoliday.Name = "dtpHoliday";
            this.dtpHoliday.Size = new System.Drawing.Size(161, 23);
            this.dtpHoliday.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Holiday Date";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.Location = new System.Drawing.Point(115, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 23);
            this.txtName.TabIndex = 6;
            // 
            // btnNewHoliday
            // 
            this.btnNewHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNewHoliday.Location = new System.Drawing.Point(519, 251);
            this.btnNewHoliday.Name = "btnNewHoliday";
            this.btnNewHoliday.Size = new System.Drawing.Size(177, 39);
            this.btnNewHoliday.TabIndex = 7;
            this.btnNewHoliday.Text = "Save New Holiday";
            this.btnNewHoliday.UseVisualStyleBackColor = true;
            this.btnNewHoliday.Click += new System.EventHandler(this.btnNewHoliday_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAddNew.Location = new System.Drawing.Point(126, 455);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(177, 39);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Add New Holiday";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.14337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.85663F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpHoliday, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(429, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 100);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // frmHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnNewHoliday);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvHolidays);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoliday";
            this.Tag = "";
            this.Text = "Holiday List";
            this.Load += new System.EventHandler(this.frmHoliday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolidays)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHolidays;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHoliday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNewHoliday;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}