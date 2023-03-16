
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAMDI_Parent));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPreferredScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateHolidayListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTEscalationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEscalationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEscalationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItemsByDateDueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEscalationsByDueDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsByDueDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holidaysListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sandboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incompleteByDateDueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLive = new System.Windows.Forms.PictureBox();
            this.pbSandbox = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSandbox)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aTEscalationsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.databaseModeToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1234, 28);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.setPreferredScreenToolStripMenuItem,
            this.updateHolidayListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Tag = "0";
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.loginToolStripMenuItem.Tag = "0";
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.logoutToolStripMenuItem.Tag = "1";
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.changePasswordToolStripMenuItem.Tag = "1";
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // setPreferredScreenToolStripMenuItem
            // 
            this.setPreferredScreenToolStripMenuItem.Name = "setPreferredScreenToolStripMenuItem";
            this.setPreferredScreenToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.setPreferredScreenToolStripMenuItem.Tag = "1";
            this.setPreferredScreenToolStripMenuItem.Text = "Set Preferred Screen";
            this.setPreferredScreenToolStripMenuItem.Click += new System.EventHandler(this.setPreferredScreenToolStripMenuItem_Click);
            // 
            // updateHolidayListToolStripMenuItem
            // 
            this.updateHolidayListToolStripMenuItem.Name = "updateHolidayListToolStripMenuItem";
            this.updateHolidayListToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.updateHolidayListToolStripMenuItem.Tag = "3";
            this.updateHolidayListToolStripMenuItem.Text = "Update Holiday List";
            this.updateHolidayListToolStripMenuItem.Click += new System.EventHandler(this.updateHolidayListToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.exitToolStripMenuItem.Tag = "0";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aTEscalationsToolStripMenuItem
            // 
            this.aTEscalationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEscalationToolStripMenuItem,
            this.searchEscalationToolStripMenuItem,
            this.deleteRecordToolStripMenuItem});
            this.aTEscalationsToolStripMenuItem.Name = "aTEscalationsToolStripMenuItem";
            this.aTEscalationsToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.aTEscalationsToolStripMenuItem.Tag = "2";
            this.aTEscalationsToolStripMenuItem.Text = "Escalations/Requests";
            // 
            // addEscalationToolStripMenuItem
            // 
            this.addEscalationToolStripMenuItem.Name = "addEscalationToolStripMenuItem";
            this.addEscalationToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.addEscalationToolStripMenuItem.Tag = "2";
            this.addEscalationToolStripMenuItem.Text = "Add New";
            this.addEscalationToolStripMenuItem.Click += new System.EventHandler(this.addEscalationToolStripMenuItem_Click);
            // 
            // searchEscalationToolStripMenuItem
            // 
            this.searchEscalationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem});
            this.searchEscalationToolStripMenuItem.Name = "searchEscalationToolStripMenuItem";
            this.searchEscalationToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.searchEscalationToolStripMenuItem.Tag = "1";
            this.searchEscalationToolStripMenuItem.Text = "Search";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.deleteRecordToolStripMenuItem.Tag = "1";
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openItemsByDateDueToolStripMenuItem,
            this.openEscalationsByDueDateToolStripMenuItem,
            this.requestsByDueDateToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Tag = "3";
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // openItemsByDateDueToolStripMenuItem
            // 
            this.openItemsByDateDueToolStripMenuItem.Name = "openItemsByDateDueToolStripMenuItem";
            this.openItemsByDateDueToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.openItemsByDateDueToolStripMenuItem.Tag = "3";
            this.openItemsByDateDueToolStripMenuItem.Text = "All Open Items by Date Due";
            this.openItemsByDateDueToolStripMenuItem.Click += new System.EventHandler(this.openItemsByDateDueToolStripMenuItem_Click);
            // 
            // openEscalationsByDueDateToolStripMenuItem
            // 
            this.openEscalationsByDueDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closedToolStripMenuItem});
            this.openEscalationsByDueDateToolStripMenuItem.Name = "openEscalationsByDueDateToolStripMenuItem";
            this.openEscalationsByDueDateToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.openEscalationsByDueDateToolStripMenuItem.Tag = "3";
            this.openEscalationsByDueDateToolStripMenuItem.Text = "Escalations by Due Date";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.openToolStripMenuItem.Tag = "3";
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closedToolStripMenuItem
            // 
            this.closedToolStripMenuItem.Name = "closedToolStripMenuItem";
            this.closedToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.closedToolStripMenuItem.Text = "Closed";
            this.closedToolStripMenuItem.Click += new System.EventHandler(this.closedToolStripMenuItem_Click);
            // 
            // requestsByDueDateToolStripMenuItem
            // 
            this.requestsByDueDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.closedToolStripMenuItem1});
            this.requestsByDueDateToolStripMenuItem.Name = "requestsByDueDateToolStripMenuItem";
            this.requestsByDueDateToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.requestsByDueDateToolStripMenuItem.Tag = "3";
            this.requestsByDueDateToolStripMenuItem.Text = "Requests by Due Date";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(123, 24);
            this.openToolStripMenuItem1.Tag = "3";
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // closedToolStripMenuItem1
            // 
            this.closedToolStripMenuItem1.Name = "closedToolStripMenuItem1";
            this.closedToolStripMenuItem1.Size = new System.Drawing.Size(123, 24);
            this.closedToolStripMenuItem1.Tag = "3";
            this.closedToolStripMenuItem1.Text = "Closed";
            this.closedToolStripMenuItem1.Click += new System.EventHandler(this.closedToolStripMenuItem1_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holidaysListToolStripMenuItem,
            this.adminMaintenanceToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.maintenanceToolStripMenuItem.Tag = "3";
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // holidaysListToolStripMenuItem
            // 
            this.holidaysListToolStripMenuItem.Name = "holidaysListToolStripMenuItem";
            this.holidaysListToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.holidaysListToolStripMenuItem.Tag = "3";
            this.holidaysListToolStripMenuItem.Text = "Holidays List";
            this.holidaysListToolStripMenuItem.Click += new System.EventHandler(this.holidaysListToolStripMenuItem_Click);
            // 
            // adminMaintenanceToolStripMenuItem
            // 
            this.adminMaintenanceToolStripMenuItem.Name = "adminMaintenanceToolStripMenuItem";
            this.adminMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.adminMaintenanceToolStripMenuItem.Tag = "3";
            this.adminMaintenanceToolStripMenuItem.Text = "User Maintenance";
            this.adminMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.adminMaintenanceToolStripMenuItem_Click);
            // 
            // databaseModeToolStripMenuItem
            // 
            this.databaseModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveToolStripMenuItem,
            this.sandboxToolStripMenuItem});
            this.databaseModeToolStripMenuItem.Name = "databaseModeToolStripMenuItem";
            this.databaseModeToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.databaseModeToolStripMenuItem.Tag = "3";
            this.databaseModeToolStripMenuItem.Text = "Database Mode";
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.liveToolStripMenuItem.Tag = "3";
            this.liveToolStripMenuItem.Text = "Live";
            this.liveToolStripMenuItem.Click += new System.EventHandler(this.liveToolStripMenuItem_Click);
            // 
            // sandboxToolStripMenuItem
            // 
            this.sandboxToolStripMenuItem.Name = "sandboxToolStripMenuItem";
            this.sandboxToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.sandboxToolStripMenuItem.Tag = "3";
            this.sandboxToolStripMenuItem.Text = "Sandbox";
            this.sandboxToolStripMenuItem.Click += new System.EventHandler(this.sandboxToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.dashboardToolStripMenuItem.Tag = "1";
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // incompleteByDateDueToolStripMenuItem
            // 
            this.incompleteByDateDueToolStripMenuItem.Name = "incompleteByDateDueToolStripMenuItem";
            this.incompleteByDateDueToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // pbLive
            // 
            this.pbLive.BackgroundImage = global::Schedule_Database_Desktop_Version.Properties.Resources.NH2000;
            this.pbLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLive.Image = global::Schedule_Database_Desktop_Version.Properties.Resources.LiveImg;
            this.pbLive.Location = new System.Drawing.Point(0, 28);
            this.pbLive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLive.Name = "pbLive";
            this.pbLive.Size = new System.Drawing.Size(1234, 658);
            this.pbLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLive.TabIndex = 6;
            this.pbLive.TabStop = false;
            // 
            // pbSandbox
            // 
            this.pbSandbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSandbox.Image = global::Schedule_Database_Desktop_Version.Properties.Resources.childhood_gdc5593de0_1280;
            this.pbSandbox.Location = new System.Drawing.Point(0, 28);
            this.pbSandbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSandbox.Name = "pbSandbox";
            this.pbSandbox.Size = new System.Drawing.Size(1234, 658);
            this.pbSandbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSandbox.TabIndex = 4;
            this.pbSandbox.TabStop = false;
            // 
            // frmAMDI_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 686);
            this.Controls.Add(this.pbLive);
            this.Controls.Add(this.pbSandbox);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAMDI_Parent";
            this.RightToLeftLayout = true;
            this.Text = "Commscope Lab Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAMDI_Parent_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSandbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sandboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPreferredScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTEscalationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEscalationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEscalationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incompleteByDateDueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openItemsByDateDueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateHolidayListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holidaysListToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbSandbox;
        private System.Windows.Forms.ToolStripMenuItem adminMaintenanceToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLive;
        private System.Windows.Forms.ToolStripMenuItem openEscalationsByDueDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsByDueDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
    }
}