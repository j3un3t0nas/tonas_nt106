namespace LAB02
{
    partial class Lab02_Bai02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab02_Bai02));
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.txtCharCount = new System.Windows.Forms.TextBox();
            this.grbFeatures = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.lbCharCount = new System.Windows.Forms.Label();
            this.lbWordCount = new System.Windows.Forms.Label();
            this.lbLineCount = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbBai02 = new System.Windows.Forms.Label();
            this.grbFeatures.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbData
            // 
            this.rtbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbData.Location = new System.Drawing.Point(3, 18);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(318, 219);
            this.rtbData.TabIndex = 1;
            this.rtbData.Text = "";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(94, 36);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(91, 22);
            this.txtSize.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(162, 384);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(559, 22);
            this.txtPath.TabIndex = 3;
            // 
            // txtLineCount
            // 
            this.txtLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineCount.Location = new System.Drawing.Point(94, 88);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.ReadOnly = true;
            this.txtLineCount.Size = new System.Drawing.Size(91, 22);
            this.txtLineCount.TabIndex = 4;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(162, 423);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(193, 22);
            this.txtFileName.TabIndex = 5;
            // 
            // txtWordCount
            // 
            this.txtWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordCount.Location = new System.Drawing.Point(94, 135);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.ReadOnly = true;
            this.txtWordCount.Size = new System.Drawing.Size(91, 22);
            this.txtWordCount.TabIndex = 6;
            // 
            // txtCharCount
            // 
            this.txtCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharCount.Location = new System.Drawing.Point(94, 184);
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.ReadOnly = true;
            this.txtCharCount.Size = new System.Drawing.Size(91, 22);
            this.txtCharCount.TabIndex = 7;
            // 
            // grbFeatures
            // 
            this.grbFeatures.Controls.Add(this.btnExit);
            this.grbFeatures.Controls.Add(this.btnRead);
            this.grbFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFeatures.Location = new System.Drawing.Point(622, 122);
            this.grbFeatures.Name = "grbFeatures";
            this.grbFeatures.Size = new System.Drawing.Size(132, 137);
            this.grbFeatures.TabIndex = 8;
            this.grbFeatures.TabStop = false;
            this.grbFeatures.Text = "Chức năng";
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 71);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 55);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRead
            // 
            this.btnRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(3, 18);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(126, 53);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "Đọc file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.rtbData);
            this.grbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutput.Location = new System.Drawing.Point(276, 122);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(324, 240);
            this.grbOutput.TabIndex = 9;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Nội dung";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.lbCharCount);
            this.grbInfo.Controls.Add(this.lbWordCount);
            this.grbInfo.Controls.Add(this.lbLineCount);
            this.grbInfo.Controls.Add(this.lbSize);
            this.grbInfo.Controls.Add(this.txtSize);
            this.grbInfo.Controls.Add(this.txtLineCount);
            this.grbInfo.Controls.Add(this.txtWordCount);
            this.grbInfo.Controls.Add(this.txtCharCount);
            this.grbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfo.Location = new System.Drawing.Point(49, 122);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(204, 240);
            this.grbInfo.TabIndex = 10;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin";
            // 
            // lbCharCount
            // 
            this.lbCharCount.AutoSize = true;
            this.lbCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharCount.Location = new System.Drawing.Point(6, 187);
            this.lbCharCount.Name = "lbCharCount";
            this.lbCharCount.Size = new System.Drawing.Size(63, 16);
            this.lbCharCount.TabIndex = 11;
            this.lbCharCount.Text = "Số ký tự : ";
            // 
            // lbWordCount
            // 
            this.lbWordCount.AutoSize = true;
            this.lbWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWordCount.Location = new System.Drawing.Point(6, 138);
            this.lbWordCount.Name = "lbWordCount";
            this.lbWordCount.Size = new System.Drawing.Size(46, 16);
            this.lbWordCount.TabIndex = 10;
            this.lbWordCount.Text = "Số từ : ";
            // 
            // lbLineCount
            // 
            this.lbLineCount.AutoSize = true;
            this.lbLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineCount.Location = new System.Drawing.Point(6, 88);
            this.lbLineCount.Name = "lbLineCount";
            this.lbLineCount.Size = new System.Drawing.Size(64, 16);
            this.lbLineCount.TabIndex = 9;
            this.lbLineCount.Text = "Số dòng :";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(6, 39);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(73, 16);
            this.lbSize.TabIndex = 8;
            this.lbSize.Text = "Kích thước :";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.Location = new System.Drawing.Point(75, 426);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(65, 16);
            this.lbFileName.TabIndex = 11;
            this.lbFileName.Text = "Tên File : ";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.Location = new System.Drawing.Point(75, 387);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(81, 16);
            this.lbPath.TabIndex = 12;
            this.lbPath.Text = "Đường dẫn : ";
            // 
            // lbBai02
            // 
            this.lbBai02.AutoSize = true;
            this.lbBai02.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBai02.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbBai02.Location = new System.Drawing.Point(169, 40);
            this.lbBai02.Name = "lbBai02";
            this.lbBai02.Size = new System.Drawing.Size(451, 37);
            this.lbBai02.TabIndex = 13;
            this.lbBai02.Text = "HIỂN THỊ THÔNG TIN FILE";
            // 
            // Lab02_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.lbBai02);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbFeatures);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab02_Bai02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab02_Bai02";
            this.grbFeatures.ResumeLayout(false);
            this.grbOutput.ResumeLayout(false);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.TextBox txtCharCount;
        private System.Windows.Forms.GroupBox grbFeatures;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lbCharCount;
        private System.Windows.Forms.Label lbWordCount;
        private System.Windows.Forms.Label lbLineCount;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbBai02;
    }
}