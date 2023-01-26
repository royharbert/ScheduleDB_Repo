
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
            this.aTEscalationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEscalationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEscalationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sandboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aTEscalationsToolStripMenuItem,
            this.databaseModeToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1508, 24);
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
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Tag = "0";
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Tag = "1";
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // setPreferredScreenToolStripMenuItem
            // 
            this.setPreferredScreenToolStripMenuItem.Name = "setPreferredScreenToolStripMenuItem";
            this.setPreferredScreenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setPreferredScreenToolStripMenuItem.Tag = "1";
            this.setPreferredScreenToolStripMenuItem.Text = "Set Preferred Screen";
            this.setPreferredScreenToolStripMenuItem.Click += new System.EventHandler(this.setPreferredScreenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Tag = "0";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aTEscalationsToolStripMenuItem
            // 
            this.aTEscalationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEscalationToolStripMenuItem,
            this.searchEscalationToolStripMenuItem});
            this.aTEscalationsToolStripMenuItem.Name = "aTEscalationsToolStripMenuItem";
            this.aTEscalationsToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.aTEscalationsToolStripMenuItem.Tag = "2";
            this.aTEscalationsToolStripMenuItem.Text = "Escalations/Requests";
            // 
            // addEscalationToolStripMenuItem
            // 
            this.addEscalationToolStripMenuItem.Name = "addEscalationToolStripMenuItem";
            this.addEscalationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEscalationToolStripMenuItem.Tag = "2";
            this.addEscalationToolStripMenuItem.Text = "Add New";
            this.addEscalationToolStripMenuItem.Click += new System.EventHandler(this.addEscalationToolStripMenuItem_Click);
            // 
            // searchEscalationToolStripMenuItem
            // 
            this.searchEscalationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem});
            this.searchEscalationToolStripMenuItem.Name = "searchEscalationToolStripMenuItem";
            this.searchEscalationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchEscalationToolStripMenuItem.Tag = "1";
            this.searchEscalationToolStripMenuItem.Text = "Search";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
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
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.liveToolStripMenuItem.Tag = "3";
            this.liveToolStripMenuItem.Text = "Live";
            this.liveToolStripMenuItem.Click += new System.EventHandler(this.liveToolStripMenuItem_Click);
            // 
            // sandboxToolStripMenuItem
            // 
            this.sandboxToolStripMenuItem.Name = "sandboxToolStripMenuItem";
            this.sandboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sandboxToolStripMenuItem.Tag = "3";
            this.sandboxToolStripMenuItem.Text = "Sandbox";
            this.sandboxToolStripMenuItem.Click += new System.EventHandler(this.sandboxToolStripMenuItem_Click);
            // 
            // frmAMDI_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1508, 898);
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
    }
}