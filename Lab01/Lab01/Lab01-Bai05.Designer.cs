namespace Lab01
{
    partial class Lab01_Bai05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai05));
            this.txtNumA = new System.Windows.Forms.TextBox();
            this.txtNumB = new System.Windows.Forms.TextBox();
            this.lbNumA = new System.Windows.Forms.Label();
            this.lbNumB = new System.Windows.Forms.Label();
            this.cboChucNang = new System.Windows.Forms.ComboBox();
            this.lbChucNang = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.lbBai05 = new System.Windows.Forms.Label();
            this.gbKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumA
            // 
            this.txtNumA.Location = new System.Drawing.Point(155, 159);
            this.txtNumA.Name = "txtNumA";
            this.txtNumA.Size = new System.Drawing.Size(100, 22);
            this.txtNumA.TabIndex = 0;
            // 
            // txtNumB
            // 
            this.txtNumB.Location = new System.Drawing.Point(385, 159);
            this.txtNumB.Name = "txtNumB";
            this.txtNumB.Size = new System.Drawing.Size(100, 22);
            this.txtNumB.TabIndex = 1;
            // 
            // lbNumA
            // 
            this.lbNumA.AutoSize = true;
            this.lbNumA.Location = new System.Drawing.Point(80, 162);
            this.lbNumA.Name = "lbNumA";
            this.lbNumA.Size = new System.Drawing.Size(61, 16);
            this.lbNumA.TabIndex = 2;
            this.lbNumA.Text = "Nhập A : ";
            // 
            // lbNumB
            // 
            this.lbNumB.AutoSize = true;
            this.lbNumB.Location = new System.Drawing.Point(306, 162);
            this.lbNumB.Name = "lbNumB";
            this.lbNumB.Size = new System.Drawing.Size(61, 16);
            this.lbNumB.TabIndex = 3;
            this.lbNumB.Text = "Nhập B : ";
            // 
            // cboChucNang
            // 
            this.cboChucNang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboChucNang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboChucNang.FormattingEnabled = true;
            this.cboChucNang.Items.AddRange(new object[] {
            "Bảng cửu chương B - A",
            "Tính toán các giá trị"});
            this.cboChucNang.Location = new System.Drawing.Point(263, 211);
            this.cboChucNang.Name = "cboChucNang";
            this.cboChucNang.Size = new System.Drawing.Size(222, 24);
            this.cboChucNang.TabIndex = 4;
            // 
            // lbChucNang
            // 
            this.lbChucNang.AutoSize = true;
            this.lbChucNang.Location = new System.Drawing.Point(80, 214);
            this.lbChucNang.Name = "lbChucNang";
            this.lbChucNang.Size = new System.Drawing.Size(163, 16);
            this.lbChucNang.TabIndex = 5;
            this.lbChucNang.Text = "Chọn chức năng thực hiện :";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(83, 304);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(114, 37);
            this.btnExec.TabIndex = 6;
            this.btnExec.Text = "Tính giá trị";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(226, 304);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(114, 37);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(372, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbKetQua
            // 
            this.gbKetQua.Controls.Add(this.txtKetQua);
            this.gbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKetQua.Location = new System.Drawing.Point(512, 115);
            this.gbKetQua.Name = "gbKetQua";
            this.gbKetQua.Size = new System.Drawing.Size(226, 238);
            this.gbKetQua.TabIndex = 9;
            this.gbKetQua.TabStop = false;
            this.gbKetQua.Text = "KẾT QUẢ";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(6, 23);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(214, 209);
            this.txtKetQua.TabIndex = 0;
            // 
            // lbBai05
            // 
            this.lbBai05.AutoSize = true;
            this.lbBai05.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBai05.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbBai05.Location = new System.Drawing.Point(148, 44);
            this.lbBai05.Name = "lbBai05";
            this.lbBai05.Size = new System.Drawing.Size(462, 37);
            this.lbBai05.TabIndex = 12;
            this.lbBai05.Text = "TÍNH TOÁN THEO YÊU CẦU";
            // 
            // Lab01_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBai05);
            this.Controls.Add(this.gbKetQua);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.lbChucNang);
            this.Controls.Add(this.cboChucNang);
            this.Controls.Add(this.lbNumB);
            this.Controls.Add(this.lbNumA);
            this.Controls.Add(this.txtNumB);
            this.Controls.Add(this.txtNumA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab01_Bai05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab01_Bai05";
            this.gbKetQua.ResumeLayout(false);
            this.gbKetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumA;
        private System.Windows.Forms.TextBox txtNumB;
        private System.Windows.Forms.Label lbNumA;
        private System.Windows.Forms.Label lbNumB;
        private System.Windows.Forms.ComboBox cboChucNang;
        private System.Windows.Forms.Label lbChucNang;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label lbBai05;
    }
}