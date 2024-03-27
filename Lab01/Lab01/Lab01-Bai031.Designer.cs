namespace Lab01
{
    partial class Lab01_Bai031
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai031));
            this.lbBa03 = new System.Windows.Forms.Label();
            this.lbInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBa03
            // 
            this.lbBa03.AutoSize = true;
            this.lbBa03.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBa03.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbBa03.Location = new System.Drawing.Point(128, 42);
            this.lbBa03.Name = "lbBa03";
            this.lbBa03.Size = new System.Drawing.Size(328, 37);
            this.lbBa03.TabIndex = 13;
            this.lbBa03.Text = "ĐỌC SỐ NÂNG CAO";
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(54, 130);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(114, 16);
            this.lbInput.TabIndex = 14;
            this.lbInput.Text = "Nhập số nguyên : ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(186, 130);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(338, 22);
            this.txtInput.TabIndex = 15;
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(54, 168);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(52, 16);
            this.lbOutput.TabIndex = 16;
            this.lbOutput.Text = "Kết quả";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(120, 165);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(404, 47);
            this.txtOutput.TabIndex = 17;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(93, 235);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 18;
            this.btnExec.Text = "Đọc";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(262, 235);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab01_Bai031
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 320);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.lbBa03);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab01_Bai031";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab01_Bai031";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBa03;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
    }
}