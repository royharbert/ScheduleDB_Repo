
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
            this.rdoProducts = new System.Windows.Forms.RadioButton();
            this.rdoMSO = new System.Windows.Forms.RadioButton();
            this.rdoUsers = new System.Windows.Forms.RadioButton();
            this.rdoRegions = new System.Windows.Forms.RadioButton();
            this.rdoStates = new System.Windows.Forms.RadioButton();
            this.rdoSales = new System.Windows.Forms.RadioButton();
            this.rdoCities = new System.Windows.Forms.RadioButton();
            this.rdoActivity = new System.Windows.Forms.RadioButton();
            this.rdoCustContact = new System.Windows.Forms.RadioButton();
            this.rdoCountries = new System.Windows.Forms.RadioButton();
            this.rdoManagers = new System.Windows.Forms.RadioButton();
            this.rdoLocations = new System.Windows.Forms.RadioButton();
            this.rdoHolidays = new System.Windows.Forms.RadioButton();
            this.rdoFE = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvModel
            // 
            this.dgvModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModel.Location = new System.Drawing.Point(-3, 12);
            this.dgvModel.Name = "dgvModel";
            this.dgvModel.Size = new System.Drawing.Size(1063, 573);
            this.dgvModel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoProducts);
            this.groupBox1.Controls.Add(this.rdoMSO);
            this.groupBox1.Controls.Add(this.rdoUsers);
            this.groupBox1.Controls.Add(this.rdoRegions);
            this.groupBox1.Controls.Add(this.rdoStates);
            this.groupBox1.Controls.Add(this.rdoSales);
            this.groupBox1.Controls.Add(this.rdoCities);
            this.groupBox1.Controls.Add(this.rdoActivity);
            this.groupBox1.Controls.Add(this.rdoCustContact);
            this.groupBox1.Controls.Add(this.rdoCountries);
            this.groupBox1.Controls.Add(this.rdoManagers);
            this.groupBox1.Controls.Add(this.rdoLocations);
            this.groupBox1.Controls.Add(this.rdoHolidays);
            this.groupBox1.Controls.Add(this.rdoFE);
            this.groupBox1.Location = new System.Drawing.Point(12, 591);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table to Update";
            // 
            // rdoProducts
            // 
            this.rdoProducts.AutoSize = true;
            this.rdoProducts.Location = new System.Drawing.Point(487, 42);
            this.rdoProducts.Name = "rdoProducts";
            this.rdoProducts.Size = new System.Drawing.Size(67, 17);
            this.rdoProducts.TabIndex = 13;
            this.rdoProducts.TabStop = true;
            this.rdoProducts.Tag = "";
            this.rdoProducts.Text = "Products";
            this.rdoProducts.UseVisualStyleBackColor = true;
            this.rdoProducts.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoMSO
            // 
            this.rdoMSO.AutoSize = true;
            this.rdoMSO.Location = new System.Drawing.Point(487, 19);
            this.rdoMSO.Name = "rdoMSO";
            this.rdoMSO.Size = new System.Drawing.Size(56, 17);
            this.rdoMSO.TabIndex = 12;
            this.rdoMSO.TabStop = true;
            this.rdoMSO.Text = "MSO\'s";
            this.rdoMSO.UseVisualStyleBackColor = true;
            this.rdoMSO.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoUsers
            // 
            this.rdoUsers.AutoSize = true;
            this.rdoUsers.Location = new System.Drawing.Point(680, 42);
            this.rdoUsers.Name = "rdoUsers";
            this.rdoUsers.Size = new System.Drawing.Size(52, 17);
            this.rdoUsers.TabIndex = 11;
            this.rdoUsers.TabStop = true;
            this.rdoUsers.Text = "Users";
            this.rdoUsers.UseVisualStyleBackColor = true;
            this.rdoUsers.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoRegions
            // 
            this.rdoRegions.AutoSize = true;
            this.rdoRegions.Location = new System.Drawing.Point(580, 19);
            this.rdoRegions.Name = "rdoRegions";
            this.rdoRegions.Size = new System.Drawing.Size(64, 17);
            this.rdoRegions.TabIndex = 10;
            this.rdoRegions.TabStop = true;
            this.rdoRegions.Text = "Regions";
            this.rdoRegions.UseVisualStyleBackColor = true;
            this.rdoRegions.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoStates
            // 
            this.rdoStates.AutoSize = true;
            this.rdoStates.Location = new System.Drawing.Point(680, 19);
            this.rdoStates.Name = "rdoStates";
            this.rdoStates.Size = new System.Drawing.Size(55, 17);
            this.rdoStates.TabIndex = 9;
            this.rdoStates.TabStop = true;
            this.rdoStates.Text = "States";
            this.rdoStates.UseVisualStyleBackColor = true;
            this.rdoStates.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoSales
            // 
            this.rdoSales.AutoSize = true;
            this.rdoSales.Location = new System.Drawing.Point(580, 42);
            this.rdoSales.Name = "rdoSales";
            this.rdoSales.Size = new System.Drawing.Size(88, 17);
            this.rdoSales.TabIndex = 8;
            this.rdoSales.TabStop = true;
            this.rdoSales.Text = "Salespersons";
            this.rdoSales.UseVisualStyleBackColor = true;
            this.rdoSales.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoCities
            // 
            this.rdoCities.AutoSize = true;
            this.rdoCities.Location = new System.Drawing.Point(6, 42);
            this.rdoCities.Name = "rdoCities";
            this.rdoCities.Size = new System.Drawing.Size(50, 17);
            this.rdoCities.TabIndex = 7;
            this.rdoCities.TabStop = true;
            this.rdoCities.Text = "Cities";
            this.rdoCities.UseVisualStyleBackColor = true;
            this.rdoCities.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoActivity
            // 
            this.rdoActivity.AutoSize = true;
            this.rdoActivity.Location = new System.Drawing.Point(6, 19);
            this.rdoActivity.Name = "rdoActivity";
            this.rdoActivity.Size = new System.Drawing.Size(59, 17);
            this.rdoActivity.TabIndex = 6;
            this.rdoActivity.TabStop = true;
            this.rdoActivity.Text = "Activity";
            this.rdoActivity.UseVisualStyleBackColor = true;
            this.rdoActivity.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoCustContact
            // 
            this.rdoCustContact.AutoSize = true;
            this.rdoCustContact.Location = new System.Drawing.Point(98, 42);
            this.rdoCustContact.Name = "rdoCustContact";
            this.rdoCustContact.Size = new System.Drawing.Size(109, 17);
            this.rdoCustContact.TabIndex = 5;
            this.rdoCustContact.TabStop = true;
            this.rdoCustContact.Tag = "";
            this.rdoCustContact.Text = "Customer Contact";
            this.rdoCustContact.UseVisualStyleBackColor = true;
            this.rdoCustContact.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoCountries
            // 
            this.rdoCountries.AutoSize = true;
            this.rdoCountries.Location = new System.Drawing.Point(98, 19);
            this.rdoCountries.Name = "rdoCountries";
            this.rdoCountries.Size = new System.Drawing.Size(69, 17);
            this.rdoCountries.TabIndex = 4;
            this.rdoCountries.TabStop = true;
            this.rdoCountries.Text = "Countries";
            this.rdoCountries.UseVisualStyleBackColor = true;
            this.rdoCountries.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoManagers
            // 
            this.rdoManagers.AutoSize = true;
            this.rdoManagers.Location = new System.Drawing.Point(362, 42);
            this.rdoManagers.Name = "rdoManagers";
            this.rdoManagers.Size = new System.Drawing.Size(72, 17);
            this.rdoManagers.TabIndex = 3;
            this.rdoManagers.TabStop = true;
            this.rdoManagers.Text = "Managers";
            this.rdoManagers.UseVisualStyleBackColor = true;
            this.rdoManagers.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoLocations
            // 
            this.rdoLocations.AutoSize = true;
            this.rdoLocations.Location = new System.Drawing.Point(227, 19);
            this.rdoLocations.Name = "rdoLocations";
            this.rdoLocations.Size = new System.Drawing.Size(118, 17);
            this.rdoLocations.TabIndex = 2;
            this.rdoLocations.TabStop = true;
            this.rdoLocations.Text = "Customer Locations";
            this.rdoLocations.UseVisualStyleBackColor = true;
            this.rdoLocations.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoHolidays
            // 
            this.rdoHolidays.AutoSize = true;
            this.rdoHolidays.Location = new System.Drawing.Point(362, 19);
            this.rdoHolidays.Name = "rdoHolidays";
            this.rdoHolidays.Size = new System.Drawing.Size(112, 17);
            this.rdoHolidays.TabIndex = 1;
            this.rdoHolidays.TabStop = true;
            this.rdoHolidays.Text = "Company Holidays";
            this.rdoHolidays.UseVisualStyleBackColor = true;
            this.rdoHolidays.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // rdoFE
            // 
            this.rdoFE.AutoSize = true;
            this.rdoFE.Location = new System.Drawing.Point(227, 42);
            this.rdoFE.Name = "rdoFE";
            this.rdoFE.Size = new System.Drawing.Size(97, 17);
            this.rdoFE.TabIndex = 0;
            this.rdoFE.TabStop = true;
            this.rdoFE.Text = "Field Engineers";
            this.rdoFE.UseVisualStyleBackColor = true;
            this.rdoFE.CheckedChanged += new System.EventHandler(this.rdoFE_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(797, 610);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(921, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmModelUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvModel);
            this.MaximumSize = new System.Drawing.Size(1080, 760);
            this.Name = "frmModelUpdate";
            this.Text = "frm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoHolidays;
        private System.Windows.Forms.RadioButton rdoFE;
        private System.Windows.Forms.RadioButton rdoCities;
        private System.Windows.Forms.RadioButton rdoActivity;
        private System.Windows.Forms.RadioButton rdoCustContact;
        private System.Windows.Forms.RadioButton rdoCountries;
        private System.Windows.Forms.RadioButton rdoManagers;
        private System.Windows.Forms.RadioButton rdoLocations;
        private System.Windows.Forms.RadioButton rdoProducts;
        private System.Windows.Forms.RadioButton rdoMSO;
        private System.Windows.Forms.RadioButton rdoUsers;
        private System.Windows.Forms.RadioButton rdoRegions;
        private System.Windows.Forms.RadioButton rdoStates;
        private System.Windows.Forms.RadioButton rdoSales;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
    }
}