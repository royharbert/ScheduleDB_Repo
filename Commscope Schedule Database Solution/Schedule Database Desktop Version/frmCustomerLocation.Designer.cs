
namespace Schedule_Database_Desktop_Version
{
    partial class frmCustomerLocation
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
            this.txtLocID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMSO = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLocID
            // 
            this.txtLocID.Location = new System.Drawing.Point(26, 27);
            this.txtLocID.Name = "txtLocID";
            this.txtLocID.Size = new System.Drawing.Size(78, 20);
            this.txtLocID.TabIndex = 80;
            this.txtLocID.Tag = "ID";
            this.txtLocID.Visible = false;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(37, 344);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 18);
            this.label20.TabIndex = 78;
            this.label20.Text = "Region";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRegion
            // 
            this.cboRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(140, 341);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(205, 21);
            this.cboRegion.TabIndex = 71;
            this.cboRegion.Tag = "Region";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(37, 315);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 18);
            this.label19.TabIndex = 77;
            this.label19.Text = "Postal Code";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPostalCode.Location = new System.Drawing.Point(140, 313);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(206, 20);
            this.txtPostalCode.TabIndex = 70;
            this.txtPostalCode.Tag = "PostalCode";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(38, 286);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 18);
            this.label18.TabIndex = 76;
            this.label18.Text = "Country";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCountry
            // 
            this.cboCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(141, 283);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(205, 21);
            this.cboCountry.TabIndex = 69;
            this.cboCountry.Tag = "Country";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(38, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 18);
            this.label17.TabIndex = 75;
            this.label17.Text = "State";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboState
            // 
            this.cboState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(141, 251);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(205, 21);
            this.cboState.TabIndex = 68;
            this.cboState.Tag = "State";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(38, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 18);
            this.label16.TabIndex = 74;
            this.label16.Text = "City";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCity
            // 
            this.cboCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(141, 219);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(205, 21);
            this.cboCity.TabIndex = 67;
            this.cboCity.Tag = "City";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(38, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 18);
            this.label15.TabIndex = 73;
            this.label15.Text = "Address";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(141, 129);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(206, 78);
            this.txtAddress.TabIndex = 66;
            this.txtAddress.Tag = "Address";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(38, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 18);
            this.label14.TabIndex = 72;
            this.label14.Text = "Site Name";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(141, 95);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(206, 20);
            this.txtSiteName.TabIndex = 65;
            this.txtSiteName.Tag = "SiteName";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(157, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 23);
            this.btnDelete.TabIndex = 83;
            this.btnDelete.Text = "Delete  Location";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 23);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "Update  Location";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 85;
            this.label1.Text = "MSO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboMSO
            // 
            this.cboMSO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMSO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMSO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMSO.FormattingEnabled = true;
            this.cboMSO.Location = new System.Drawing.Point(142, 58);
            this.cboMSO.Name = "cboMSO";
            this.cboMSO.Size = new System.Drawing.Size(205, 21);
            this.cboMSO.TabIndex = 84;
            this.cboMSO.Tag = "City";
            // 
            // frmCustomerLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMSO);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLocID);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSiteName);
            this.Name = "frmCustomerLocation";
            this.Text = "Customer Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMSO;
    }
}