
namespace Schedule_Database_Desktop_Version
{
    partial class frmMSOEdit
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
            this.components = new System.ComponentModel.Container();
            this.txt_AddMSO = new System.Windows.Forms.TextBox();
            this.lbl_AddNewMSO = new System.Windows.Forms.Label();
            this.lbl_MSOs = new System.Windows.Forms.Label();
            this.btn_AddMSO = new System.Windows.Forms.Button();
            this.btn_markInactive = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chk_showActive = new System.Windows.Forms.CheckBox();
            this.btn_markActive = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_editMSO = new System.Windows.Forms.Button();
            this.dgv_MSO = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MSO)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_AddMSO
            // 
            this.txt_AddMSO.Location = new System.Drawing.Point(35, 318);
            this.txt_AddMSO.Name = "txt_AddMSO";
            this.txt_AddMSO.Size = new System.Drawing.Size(307, 20);
            this.txt_AddMSO.TabIndex = 0;
            // 
            // lbl_AddNewMSO
            // 
            this.lbl_AddNewMSO.AutoSize = true;
            this.lbl_AddNewMSO.Location = new System.Drawing.Point(32, 289);
            this.lbl_AddNewMSO.Name = "lbl_AddNewMSO";
            this.lbl_AddNewMSO.Size = new System.Drawing.Size(78, 13);
            this.lbl_AddNewMSO.TabIndex = 3;
            this.lbl_AddNewMSO.Text = "Add New MSO";
            // 
            // lbl_MSOs
            // 
            this.lbl_MSOs.AutoSize = true;
            this.lbl_MSOs.Location = new System.Drawing.Point(32, 20);
            this.lbl_MSOs.Name = "lbl_MSOs";
            this.lbl_MSOs.Size = new System.Drawing.Size(96, 13);
            this.lbl_MSOs.TabIndex = 4;
            this.lbl_MSOs.Text = "Edit Existing MSOs";
            // 
            // btn_AddMSO
            // 
            this.btn_AddMSO.Location = new System.Drawing.Point(411, 312);
            this.btn_AddMSO.Name = "btn_AddMSO";
            this.btn_AddMSO.Size = new System.Drawing.Size(183, 23);
            this.btn_AddMSO.TabIndex = 5;
            this.btn_AddMSO.Text = "Create MSO";
            this.btn_AddMSO.UseVisualStyleBackColor = true;
            // 
            // btn_markInactive
            // 
            this.btn_markInactive.Location = new System.Drawing.Point(411, 83);
            this.btn_markInactive.Name = "btn_markInactive";
            this.btn_markInactive.Size = new System.Drawing.Size(183, 23);
            this.btn_markInactive.TabIndex = 6;
            this.btn_markInactive.Text = "Mark Inactive";
            this.btn_markInactive.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // chk_showActive
            // 
            this.chk_showActive.AutoSize = true;
            this.chk_showActive.Location = new System.Drawing.Point(112, 203);
            this.chk_showActive.Name = "chk_showActive";
            this.chk_showActive.Size = new System.Drawing.Size(139, 17);
            this.chk_showActive.TabIndex = 7;
            this.chk_showActive.Text = "Show active MSOs only";
            this.chk_showActive.UseVisualStyleBackColor = true;
            // 
            // btn_markActive
            // 
            this.btn_markActive.Location = new System.Drawing.Point(411, 112);
            this.btn_markActive.Name = "btn_markActive";
            this.btn_markActive.Size = new System.Drawing.Size(183, 23);
            this.btn_markActive.TabIndex = 8;
            this.btn_markActive.Text = "Mark Active";
            this.btn_markActive.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(469, 419);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(183, 23);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_editMSO
            // 
            this.btn_editMSO.Location = new System.Drawing.Point(411, 141);
            this.btn_editMSO.Name = "btn_editMSO";
            this.btn_editMSO.Size = new System.Drawing.Size(183, 23);
            this.btn_editMSO.TabIndex = 10;
            this.btn_editMSO.Text = "Edit MSO";
            this.btn_editMSO.UseVisualStyleBackColor = true;
            // 
            // dgv_MSO
            // 
            this.dgv_MSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MSO.Location = new System.Drawing.Point(35, 47);
            this.dgv_MSO.Name = "dgv_MSO";
            this.dgv_MSO.Size = new System.Drawing.Size(307, 150);
            this.dgv_MSO.TabIndex = 11;
            this.dgv_MSO.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MSO_CellEndEdit);
            this.dgv_MSO.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_MSO_RowHeaderMouseClick);
            // 
            // frmMSOEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 454);
            this.Controls.Add(this.dgv_MSO);
            this.Controls.Add(this.btn_editMSO);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_markActive);
            this.Controls.Add(this.chk_showActive);
            this.Controls.Add(this.btn_markInactive);
            this.Controls.Add(this.btn_AddMSO);
            this.Controls.Add(this.lbl_MSOs);
            this.Controls.Add(this.lbl_AddNewMSO);
            this.Controls.Add(this.txt_AddMSO);
            this.Name = "frmMSOEdit";
            this.Text = "frmMSOUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MSO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AddMSO;
        private System.Windows.Forms.Label lbl_AddNewMSO;
        private System.Windows.Forms.Label lbl_MSOs;
        private System.Windows.Forms.Button btn_AddMSO;
        private System.Windows.Forms.Button btn_markInactive;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox chk_showActive;
        private System.Windows.Forms.Button btn_markActive;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_editMSO;
        private System.Windows.Forms.DataGridView dgv_MSO;
    }
}