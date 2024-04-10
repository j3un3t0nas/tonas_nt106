namespace Lab01
{
    partial class Lab01_Bai06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai06));
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.labelBai6 = new System.Windows.Forms.Label();
            this.gbKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(59, 246);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(106, 16);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Nhập ngày sinh :";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(292, 246);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(112, 16);
            this.lbMonth.TabIndex = 1;
            this.lbMonth.Text = "Nhập tháng sinh : ";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(525, 246);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(105, 16);
            this.lbYear.TabIndex = 2;
            this.lbYear.Text = "Nhập năm sinh : ";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(171, 243);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 3;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(410, 243);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 22);
            this.txtMonth.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(636, 243);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 5;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(130, 309);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(101, 39);
            this.btnExec.TabIndex = 6;
            this.btnExec.Text = "Kiểm tra";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(342, 309);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(101, 39);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(557, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbKetQua
            // 
            this.gbKetQua.Controls.Add(this.txtKetQua);
            this.gbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKetQua.Location = new System.Drawing.Point(62, 154);
            this.gbKetQua.Name = "gbKetQua";
            this.gbKetQua.Size = new System.Drawing.Size(674, 73);
            this.gbKetQua.TabIndex = 9;
            this.gbKetQua.TabStop = false;
            this.gbKetQua.Text = "KẾT QUẢ";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(6, 21);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(662, 46);
            this.txtKetQua.TabIndex = 0;
            // 
            // labelBai6
            // 
            this.labelBai6.AutoSize = true;
            this.labelBai6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBai6.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelBai6.Location = new System.Drawing.Point(186, 53);
            this.labelBai6.Name = "labelBai6";
            this.labelBai6.Size = new System.Drawing.Size(524, 37);
            this.labelBai6.TabIndex = 10;
            this.labelBai6.Text = "THÔNG TIN CUNG HOÀNG ĐẠO";
            // 
            // Lab01_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBai6);
            this.Controls.Add(this.gbKetQua);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.lbDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab01_Bai06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab01_Bai06";
            this.gbKetQua.ResumeLayout(false);
            this.gbKetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label labelBai6;
    }
}