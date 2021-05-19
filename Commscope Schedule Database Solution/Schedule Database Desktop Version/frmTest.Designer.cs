
namespace Schedule_Database_Desktop_Version
{
    partial class frmTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSer = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.ListBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtFE1 = new System.Windows.Forms.TextBox();
            this.txtFE2 = new System.Windows.Forms.TextBox();
            this.txtFE3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Initialize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSer
            // 
            this.btnSer.Location = new System.Drawing.Point(132, 209);
            this.btnSer.Name = "btnSer";
            this.btnSer.Size = new System.Drawing.Size(147, 31);
            this.btnSer.TabIndex = 1;
            this.btnSer.Text = "Serialize";
            this.btnSer.UseVisualStyleBackColor = true;
            this.btnSer.Click += new System.EventHandler(this.btnSer_Click);
            // 
            // btnDes
            // 
            this.btnDes.Location = new System.Drawing.Point(132, 257);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(147, 31);
            this.btnDes.TabIndex = 2;
            this.btnDes.Text = "Deserialize";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.Location = new System.Drawing.Point(440, 118);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(210, 186);
            this.lbData.TabIndex = 3;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(440, 331);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(290, 222);
            this.txtData.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(70, 331);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(290, 222);
            this.txtResult.TabIndex = 5;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(132, 44);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(147, 31);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtFE1
            // 
            this.txtFE1.Location = new System.Drawing.Point(468, 34);
            this.txtFE1.Name = "txtFE1";
            this.txtFE1.Size = new System.Drawing.Size(168, 20);
            this.txtFE1.TabIndex = 7;
            // 
            // txtFE2
            // 
            this.txtFE2.Location = new System.Drawing.Point(468, 57);
            this.txtFE2.Name = "txtFE2";
            this.txtFE2.Size = new System.Drawing.Size(168, 20);
            this.txtFE2.TabIndex = 8;
            // 
            // txtFE3
            // 
            this.txtFE3.Location = new System.Drawing.Point(468, 79);
            this.txtFE3.Name = "txtFE3";
            this.txtFE3.Size = new System.Drawing.Size(168, 20);
            this.txtFE3.TabIndex = 9;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.txtFE3);
            this.Controls.Add(this.txtFE2);
            this.Controls.Add(this.txtFE1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btnDes);
            this.Controls.Add(this.btnSer);
            this.Controls.Add(this.button1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSer;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtFE1;
        private System.Windows.Forms.TextBox txtFE2;
        private System.Windows.Forms.TextBox txtFE3;
    }
}