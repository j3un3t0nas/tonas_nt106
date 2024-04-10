namespace Lab01
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
            this.txtSoThu1 = new System.Windows.Forms.TextBox();
            this.lbSoThu1 = new System.Windows.Forms.Label();
            this.lbSoThu2 = new System.Windows.Forms.Label();
            this.lbSoThu3 = new System.Windows.Forms.Label();
            this.txtSoThu2 = new System.Windows.Forms.TextBox();
            this.txtSoThu3 = new System.Windows.Forms.TextBox();
            this.txtMaxNum = new System.Windows.Forms.TextBox();
            this.txtMinNum = new System.Windows.Forms.TextBox();
            this.lbMaxNum = new System.Windows.Forms.Label();
            this.lbMinNum = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lbBai02 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoThu1
            // 
            this.txtSoThu1.Location = new System.Drawing.Point(171, 122);
            this.txtSoThu1.Name = "txtSoThu1";
            this.txtSoThu1.Size = new System.Drawing.Size(100, 22);
            this.txtSoThu1.TabIndex = 0;
            // 
            // lbSoThu1
            // 
            this.lbSoThu1.AutoSize = true;
            this.lbSoThu1.Location = new System.Drawing.Point(60, 128);
            this.lbSoThu1.Name = "lbSoThu1";
            this.lbSoThu1.Size = new System.Drawing.Size(81, 16);
            this.lbSoThu1.TabIndex = 3;
            this.lbSoThu1.Text = "Số Thứ Nhất";
            // 
            // lbSoThu2
            // 
            this.lbSoThu2.AutoSize = true;
            this.lbSoThu2.Location = new System.Drawing.Point(60, 178);
            this.lbSoThu2.Name = "lbSoThu2";
            this.lbSoThu2.Size = new System.Drawing.Size(74, 16);
            this.lbSoThu2.TabIndex = 4;
            this.lbSoThu2.Text = "Số Thứ Hai";
            // 
            // lbSoThu3
            // 
            this.lbSoThu3.AutoSize = true;
            this.lbSoThu3.Location = new System.Drawing.Point(60, 228);
            this.lbSoThu3.Name = "lbSoThu3";
            this.lbSoThu3.Size = new System.Drawing.Size(70, 16);
            this.lbSoThu3.TabIndex = 5;
            this.lbSoThu3.Text = "Số Thứ Ba";
            // 
            // txtSoThu2
            // 
            this.txtSoThu2.Location = new System.Drawing.Point(171, 172);
            this.txtSoThu2.Name = "txtSoThu2";
            this.txtSoThu2.Size = new System.Drawing.Size(100, 22);
            this.txtSoThu2.TabIndex = 6;
            // 
            // txtSoThu3
            // 
            this.txtSoThu3.Location = new System.Drawing.Point(171, 222);
            this.txtSoThu3.Name = "txtSoThu3";
            this.txtSoThu3.Size = new System.Drawing.Size(100, 22);
            this.txtSoThu3.TabIndex = 7;
            // 
            // txtMaxNum
            // 
            this.txtMaxNum.Location = new System.Drawing.Point(399, 143);
            this.txtMaxNum.Name = "txtMaxNum";
            this.txtMaxNum.ReadOnly = true;
            this.txtMaxNum.Size = new System.Drawing.Size(100, 22);
            this.txtMaxNum.TabIndex = 8;
            // 
            // txtMinNum
            // 
            this.txtMinNum.Location = new System.Drawing.Point(620, 143);
            this.txtMinNum.Name = "txtMinNum";
            this.txtMinNum.ReadOnly = true;
            this.txtMinNum.Size = new System.Drawing.Size(100, 22);
            this.txtMinNum.TabIndex = 9;
            // 
            // lbMaxNum
            // 
            this.lbMaxNum.AutoSize = true;
            this.lbMaxNum.Location = new System.Drawing.Point(313, 149);
            this.lbMaxNum.Name = "lbMaxNum";
            this.lbMaxNum.Size = new System.Drawing.Size(80, 16);
            this.lbMaxNum.TabIndex = 10;
            this.lbMaxNum.Text = "Số Lớn Nhất";
            // 
            // lbMinNum
            // 
            this.lbMinNum.AutoSize = true;
            this.lbMinNum.Location = new System.Drawing.Point(531, 149);
            this.lbMinNum.Name = "lbMinNum";
            this.lbMinNum.Size = new System.Drawing.Size(83, 16);
            this.lbMinNum.TabIndex = 11;
            this.lbMinNum.Text = "Số Nhỏ Nhất";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(346, 198);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 12;
            this.btnExec.Text = "Tìm";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(611, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(477, 198);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lbBai02
            // 
            this.lbBai02.AutoSize = true;
            this.lbBai02.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBai02.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbBai02.Location = new System.Drawing.Point(140, 40);
            this.lbBai02.Name = "lbBai02";
            this.lbBai02.Size = new System.Drawing.Size(480, 37);
            this.lbBai02.TabIndex = 15;
            this.lbBai02.Text = "TÌM SỐ LỚN NHẤT, BÉ NHẤT";
            // 
            // Lab02_Bai02
            // 
            this.AcceptButton = this.btnExec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(783, 340);
            this.Controls.Add(this.lbBai02);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.lbMinNum);
            this.Controls.Add(this.lbMaxNum);
            this.Controls.Add(this.txtMinNum);
            this.Controls.Add(this.txtMaxNum);
            this.Controls.Add(this.txtSoThu3);
            this.Controls.Add(this.txtSoThu2);
            this.Controls.Add(this.lbSoThu3);
            this.Controls.Add(this.lbSoThu2);
            this.Controls.Add(this.lbSoThu1);
            this.Controls.Add(this.txtSoThu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab02_Bai02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab02_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoThu1;
        private System.Windows.Forms.Label lbSoThu1;
        private System.Windows.Forms.Label lbSoThu2;
        private System.Windows.Forms.Label lbSoThu3;
        private System.Windows.Forms.TextBox txtSoThu2;
        private System.Windows.Forms.TextBox txtSoThu3;
        private System.Windows.Forms.TextBox txtMaxNum;
        private System.Windows.Forms.TextBox txtMinNum;
        private System.Windows.Forms.Label lbMaxNum;
        private System.Windows.Forms.Label lbMinNum;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lbBai02;
    }
}