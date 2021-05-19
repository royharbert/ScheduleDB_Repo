
namespace Schedule_Database_Desktop_Version
{
    partial class frmAMDI_Parent
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPreferredScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativeOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fEUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salespersonUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sandboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateRangeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fEToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTEscalationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEscalationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEscalationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEscalationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionToolStripMenuItem,
            this.administrativeOperationsToolStripMenuItem,
            this.databaseModeToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.aTEscalationsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1869, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.setPreferredScreenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Tag = "0";
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loginToolStripMenuItem.Tag = "0";
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.logoutToolStripMenuItem.Tag = "1";
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // setPreferredScreenToolStripMenuItem
            // 
            this.setPreferredScreenToolStripMenuItem.Name = "setPreferredScreenToolStripMenuItem";
            this.setPreferredScreenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.setPreferredScreenToolStripMenuItem.Tag = "1";
            this.setPreferredScreenToolStripMenuItem.Text = "Set Preferred Screen";
            this.setPreferredScreenToolStripMenuItem.Click += new System.EventHandler(this.setPreferredScreenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Tag = "0";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRequestToolStripMenuItem,
            this.editRequestToolStripMenuItem,
            this.deleteRequestToolStripMenuItem,
            this.restoreRequestToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.functionToolStripMenuItem.Tag = "1";
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // newRequestToolStripMenuItem
            // 
            this.newRequestToolStripMenuItem.Name = "newRequestToolStripMenuItem";
            this.newRequestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newRequestToolStripMenuItem.Tag = "2";
            this.newRequestToolStripMenuItem.Text = "New Request";
            this.newRequestToolStripMenuItem.Click += new System.EventHandler(this.newRequestToolStripMenuItem_Click);
            // 
            // editRequestToolStripMenuItem
            // 
            this.editRequestToolStripMenuItem.Name = "editRequestToolStripMenuItem";
            this.editRequestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editRequestToolStripMenuItem.Tag = "1";
            this.editRequestToolStripMenuItem.Text = "Edit Request";
            this.editRequestToolStripMenuItem.Click += new System.EventHandler(this.editRequestToolStripMenuItem_Click);
            // 
            // deleteRequestToolStripMenuItem
            // 
            this.deleteRequestToolStripMenuItem.Name = "deleteRequestToolStripMenuItem";
            this.deleteRequestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteRequestToolStripMenuItem.Tag = "2";
            this.deleteRequestToolStripMenuItem.Text = "Delete Request";
            // 
            // restoreRequestToolStripMenuItem
            // 
            this.restoreRequestToolStripMenuItem.Name = "restoreRequestToolStripMenuItem";
            this.restoreRequestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.restoreRequestToolStripMenuItem.Tag = "2";
            this.restoreRequestToolStripMenuItem.Text = "Restore Request";
            // 
            // administrativeOperationsToolStripMenuItem
            // 
            this.administrativeOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fEUpdateToolStripMenuItem,
            this.salespersonUpdateToolStripMenuItem,
            this.addCustomerContactToolStripMenuItem,
            this.addCustomerLocationToolStripMenuItem});
            this.administrativeOperationsToolStripMenuItem.Name = "administrativeOperationsToolStripMenuItem";
            this.administrativeOperationsToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.administrativeOperationsToolStripMenuItem.Tag = "2";
            this.administrativeOperationsToolStripMenuItem.Text = "Administrative Operations";
            // 
            // fEUpdateToolStripMenuItem
            // 
            this.fEUpdateToolStripMenuItem.Name = "fEUpdateToolStripMenuItem";
            this.fEUpdateToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fEUpdateToolStripMenuItem.Tag = "2";
            this.fEUpdateToolStripMenuItem.Text = "FE Update";
            this.fEUpdateToolStripMenuItem.Click += new System.EventHandler(this.fEUpdateToolStripMenuItem_Click);
            // 
            // salespersonUpdateToolStripMenuItem
            // 
            this.salespersonUpdateToolStripMenuItem.Name = "salespersonUpdateToolStripMenuItem";
            this.salespersonUpdateToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.salespersonUpdateToolStripMenuItem.Tag = "2";
            this.salespersonUpdateToolStripMenuItem.Text = "Salesperson Update";
            // 
            // addCustomerContactToolStripMenuItem
            // 
            this.addCustomerContactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewContactToolStripMenuItem,
            this.searchContactToolStripMenuItem,
            this.deleteContactToolStripMenuItem});
            this.addCustomerContactToolStripMenuItem.Name = "addCustomerContactToolStripMenuItem";
            this.addCustomerContactToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addCustomerContactToolStripMenuItem.Tag = "2";
            this.addCustomerContactToolStripMenuItem.Text = "Customer Contact";
            // 
            // addNewContactToolStripMenuItem
            // 
            this.addNewContactToolStripMenuItem.Name = "addNewContactToolStripMenuItem";
            this.addNewContactToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addNewContactToolStripMenuItem.Tag = "2";
            this.addNewContactToolStripMenuItem.Text = "Add New Contact";
            this.addNewContactToolStripMenuItem.Click += new System.EventHandler(this.addNewContactToolStripMenuItem_Click);
            // 
            // searchContactToolStripMenuItem
            // 
            this.searchContactToolStripMenuItem.Name = "searchContactToolStripMenuItem";
            this.searchContactToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchContactToolStripMenuItem.Tag = "2";
            this.searchContactToolStripMenuItem.Text = "Search Contact";
            this.searchContactToolStripMenuItem.Click += new System.EventHandler(this.searchContactToolStripMenuItem_Click);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteContactToolStripMenuItem.Text = "Delete Contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.deleteContactToolStripMenuItem_Click);
            // 
            // addCustomerLocationToolStripMenuItem
            // 
            this.addCustomerLocationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocationToolStripMenuItem,
            this.searchLocationToolStripMenuItem});
            this.addCustomerLocationToolStripMenuItem.Name = "addCustomerLocationToolStripMenuItem";
            this.addCustomerLocationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addCustomerLocationToolStripMenuItem.Tag = "2";
            this.addCustomerLocationToolStripMenuItem.Text = "Customer Location";
            // 
            // addLocationToolStripMenuItem
            // 
            this.addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            this.addLocationToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addLocationToolStripMenuItem.Tag = "2";
            this.addLocationToolStripMenuItem.Text = "Add Location";
            this.addLocationToolStripMenuItem.Click += new System.EventHandler(this.addLocationToolStripMenuItem_Click);
            // 
            // searchLocationToolStripMenuItem
            // 
            this.searchLocationToolStripMenuItem.Name = "searchLocationToolStripMenuItem";
            this.searchLocationToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.searchLocationToolStripMenuItem.Tag = "2";
            this.searchLocationToolStripMenuItem.Text = "Search Location";
            this.searchLocationToolStripMenuItem.Click += new System.EventHandler(this.searchLocationToolStripMenuItem_Click);
            // 
            // databaseModeToolStripMenuItem
            // 
            this.databaseModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveToolStripMenuItem,
            this.sandboxToolStripMenuItem});
            this.databaseModeToolStripMenuItem.Name = "databaseModeToolStripMenuItem";
            this.databaseModeToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.databaseModeToolStripMenuItem.Tag = "3";
            this.databaseModeToolStripMenuItem.Text = "Database Mode";
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.liveToolStripMenuItem.Tag = "3";
            this.liveToolStripMenuItem.Text = "Live";
            this.liveToolStripMenuItem.Click += new System.EventHandler(this.liveToolStripMenuItem_Click);
            // 
            // sandboxToolStripMenuItem
            // 
            this.sandboxToolStripMenuItem.Name = "sandboxToolStripMenuItem";
            this.sandboxToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sandboxToolStripMenuItem.Tag = "3";
            this.sandboxToolStripMenuItem.Text = "Sandbox";
            this.sandboxToolStripMenuItem.Click += new System.EventHandler(this.sandboxToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateRangeReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Tag = "3";
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // dateRangeReportToolStripMenuItem
            // 
            this.dateRangeReportToolStripMenuItem.Name = "dateRangeReportToolStripMenuItem";
            this.dateRangeReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateRangeReportToolStripMenuItem.Tag = "3";
            this.dateRangeReportToolStripMenuItem.Text = "Date Range Report";
            this.dateRangeReportToolStripMenuItem.Click += new System.EventHandler(this.dateRangeReportToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fEToXMLToolStripMenuItem,
            this.productsToXMLToolStripMenuItem,
            this.activityToINTToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Tag = "4";
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // fEToXMLToolStripMenuItem
            // 
            this.fEToXMLToolStripMenuItem.Name = "fEToXMLToolStripMenuItem";
            this.fEToXMLToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.fEToXMLToolStripMenuItem.Tag = "4";
            this.fEToXMLToolStripMenuItem.Text = "FE to XML";
            this.fEToXMLToolStripMenuItem.Click += new System.EventHandler(this.fEToXMLToolStripMenuItem_Click);
            // 
            // productsToXMLToolStripMenuItem
            // 
            this.productsToXMLToolStripMenuItem.Name = "productsToXMLToolStripMenuItem";
            this.productsToXMLToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.productsToXMLToolStripMenuItem.Tag = "4";
            this.productsToXMLToolStripMenuItem.Text = "Products to XML";
            this.productsToXMLToolStripMenuItem.Click += new System.EventHandler(this.productsToXMLToolStripMenuItem_Click);
            // 
            // activityToINTToolStripMenuItem
            // 
            this.activityToINTToolStripMenuItem.Name = "activityToINTToolStripMenuItem";
            this.activityToINTToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.activityToINTToolStripMenuItem.Tag = "4";
            this.activityToINTToolStripMenuItem.Text = "Activity to INT";
            this.activityToINTToolStripMenuItem.Click += new System.EventHandler(this.activityToINTToolStripMenuItem_Click);
            // 
            // aTEscalationsToolStripMenuItem
            // 
            this.aTEscalationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEscalationToolStripMenuItem,
            this.searchEscalationToolStripMenuItem,
            this.deleteEscalationToolStripMenuItem});
            this.aTEscalationsToolStripMenuItem.Name = "aTEscalationsToolStripMenuItem";
            this.aTEscalationsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.aTEscalationsToolStripMenuItem.Tag = "2";
            this.aTEscalationsToolStripMenuItem.Text = "AT Escalations";
            // 
            // addEscalationToolStripMenuItem
            // 
            this.addEscalationToolStripMenuItem.Name = "addEscalationToolStripMenuItem";
            this.addEscalationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEscalationToolStripMenuItem.Tag = "2";
            this.addEscalationToolStripMenuItem.Text = "Add Escalation";
            this.addEscalationToolStripMenuItem.Click += new System.EventHandler(this.addEscalationToolStripMenuItem_Click);
            // 
            // searchEscalationToolStripMenuItem
            // 
            this.searchEscalationToolStripMenuItem.Name = "searchEscalationToolStripMenuItem";
            this.searchEscalationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchEscalationToolStripMenuItem.Tag = "2";
            this.searchEscalationToolStripMenuItem.Text = "Search Escalation";
            this.searchEscalationToolStripMenuItem.Click += new System.EventHandler(this.searchEscalationToolStripMenuItem_Click_1);
            // 
            // deleteEscalationToolStripMenuItem
            // 
            this.deleteEscalationToolStripMenuItem.Name = "deleteEscalationToolStripMenuItem";
            this.deleteEscalationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteEscalationToolStripMenuItem.Tag = "2";
            this.deleteEscalationToolStripMenuItem.Text = "Delete Escalation";
            this.deleteEscalationToolStripMenuItem.Click += new System.EventHandler(this.deleteEscalationToolStripMenuItem_Click);
            // 
            // frmAMDI_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1869, 898);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAMDI_Parent";
            this.Text = "Commscope Schedule Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sandboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativeOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fEUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fEToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salespersonUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPreferredScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateRangeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTEscalationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEscalationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEscalationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEscalationToolStripMenuItem;
    }
}