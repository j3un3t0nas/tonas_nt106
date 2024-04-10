namespace Lab01
{
    partial class Lab01_Bai01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai01));
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtbKQ = new System.Windows.Forms.TextBox();
            this.lbBai01 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(282, 119);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(211, 22);
            this.txtb1.TabIndex = 0;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(282, 171);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(211, 22);
            this.txtb2.TabIndex = 1;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(150, 125);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(54, 16);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Số thứ 1";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(150, 177);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(54, 16);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Số thứ 2";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(150, 225);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(52, 16);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "Kết quả";
            // 
            // txtbKQ
            // 
            this.txtbKQ.Location = new System.Drawing.Point(282, 219);
            this.txtbKQ.Name = "txtbKQ";
            this.txtbKQ.ReadOnly = true;
            this.txtbKQ.Size = new System.Drawing.Size(211, 22);
            this.txtbKQ.TabIndex = 5;
            // 
            // lbBai01
            // 
            this.lbBai01.AutoSize = true;
            this.lbBai01.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBai01.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbBai01.Location = new System.Drawing.Point(107, 40);
            this.lbBai01.Name = "lbBai01";
            this.lbBai01.Size = new System.Drawing.Size(434, 37);
            this.lbBai01.TabIndex = 6;
            this.lbBai01.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(282, 286);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Lab01_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 405);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lbBai01);
            this.Controls.Add(this.txtbKQ);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab01_Bai01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab01_Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txtbKQ;
        private System.Windows.Forms.Label lbBai01;
        private System.Windows.Forms.Button btnTinh;
    }
}