namespace AccBear.FormatDocuments
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnInputDir = new System.Windows.Forms.Button();
            this.txtInputDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFormatDoc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // txtFont
            // 
            this.txtFont.Enabled = false;
            this.txtFont.Location = new System.Drawing.Point(96, 40);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(289, 20);
            this.txtFont.TabIndex = 1;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(391, 38);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(35, 23);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnInputDir
            // 
            this.btnInputDir.Location = new System.Drawing.Point(391, 80);
            this.btnInputDir.Name = "btnInputDir";
            this.btnInputDir.Size = new System.Drawing.Size(35, 23);
            this.btnInputDir.TabIndex = 5;
            this.btnInputDir.Text = "...";
            this.btnInputDir.UseVisualStyleBackColor = true;
            this.btnInputDir.Click += new System.EventHandler(this.btnInputDir_Click);
            // 
            // txtInputDir
            // 
            this.txtInputDir.Enabled = false;
            this.txtInputDir.Location = new System.Drawing.Point(96, 82);
            this.txtInputDir.Name = "txtInputDir";
            this.txtInputDir.Size = new System.Drawing.Size(289, 20);
            this.txtInputDir.TabIndex = 4;
            this.txtInputDir.Text = "D:\\Temp\\ACC\\Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input dir";
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.Location = new System.Drawing.Point(391, 124);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(35, 23);
            this.btnOutputDir.TabIndex = 8;
            this.btnOutputDir.Text = "...";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Enabled = false;
            this.txtOutputDir.Location = new System.Drawing.Point(96, 126);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(289, 20);
            this.txtOutputDir.TabIndex = 7;
            this.txtOutputDir.Text = "D:\\Temp\\ACC\\Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output dir";
            // 
            // btnFormatDoc
            // 
            this.btnFormatDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormatDoc.Location = new System.Drawing.Point(96, 197);
            this.btnFormatDoc.Name = "btnFormatDoc";
            this.btnFormatDoc.Size = new System.Drawing.Size(289, 39);
            this.btnFormatDoc.TabIndex = 9;
            this.btnFormatDoc.Text = "Format Documents";
            this.btnFormatDoc.UseVisualStyleBackColor = true;
            this.btnFormatDoc.Click += new System.EventHandler(this.btnFormatDoc_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(396, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.btnFormatDoc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 304);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFormatDoc);
            this.Controls.Add(this.btnOutputDir);
            this.Controls.Add(this.txtOutputDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInputDir);
            this.Controls.Add(this.txtInputDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnInputDir;
        private System.Windows.Forms.TextBox txtInputDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutputDir;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFormatDoc;
        private System.Windows.Forms.Button btnClose;
    }
}