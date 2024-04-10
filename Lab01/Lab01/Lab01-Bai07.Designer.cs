namespace Lab01
{
    partial class Lab01_Bai07
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai07));
            this.lbInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lbBai7 = new System.Windows.Forms.Label();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(119, 127);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(193, 16);
            this.lbInput.TabIndex = 0;
            this.lbInput.Text = "Nhập họ tên và điểm các môn : ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(318, 124);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(351, 22);
            this.txtInput.TabIndex = 1;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(138, 364);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(100, 47);
            this.btnExec.TabIndex = 2;
            this.btnExec.Text = "Thực thi";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(354, 364);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 47);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(554, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.txtOutput);
            this.gbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOutput.Location = new System.Drawing.Point(116, 152);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(559, 206);
            this.gbOutput.TabIndex = 5;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "KẾT QUẢ ";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(6, 21);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(547, 179);
            this.txtOutput.TabIndex = 0;
            // 
            // lbBai7
            // 
            this.lbBai7.AutoSize = true;
            this.lbBai7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBai7.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbBai7.Location = new System.Drawing.Point(197, 45);
            this.lbBai7.Name = "lbBai7";
            this.lbBai7.Size = new System.Drawing.Size(388, 37);
            this.lbBai7.TabIndex = 11;
            this.lbBai7.Text = "BẢNG ĐIỂM SINH VIÊN";
            // 
            // Lab01_Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBai7);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lbInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab01_Bai07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab01_Bai07";
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lbBai7;
    }
}