namespace Lab01
{
    partial class Lab01_Bai08
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai08));
            this.lstbFoods = new System.Windows.Forms.ListBox();
            this.gbFoods = new System.Windows.Forms.GroupBox();
            this.gbFeatures = new System.Windows.Forms.GroupBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lbBai08 = new System.Windows.Forms.Label();
            this.gbFoods.SuspendLayout();
            this.gbFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbFoods
            // 
            this.lstbFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbFoods.FormattingEnabled = true;
            this.lstbFoods.ItemHeight = 16;
            this.lstbFoods.Items.AddRange(new object[] {
            "Bánh mì ốp la",
            "Cơm sườn bì chả",
            "Cơm gà nướng"});
            this.lstbFoods.Location = new System.Drawing.Point(3, 20);
            this.lstbFoods.Name = "lstbFoods";
            this.lstbFoods.Size = new System.Drawing.Size(193, 204);
            this.lstbFoods.TabIndex = 0;
            // 
            // gbFoods
            // 
            this.gbFoods.Controls.Add(this.lstbFoods);
            this.gbFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFoods.Location = new System.Drawing.Point(90, 151);
            this.gbFoods.Name = "gbFoods";
            this.gbFoods.Size = new System.Drawing.Size(199, 227);
            this.gbFoods.TabIndex = 1;
            this.gbFoods.TabStop = false;
            this.gbFoods.Text = "Các món ăn";
            // 
            // gbFeatures
            // 
            this.gbFeatures.Controls.Add(this.btnExit);
            this.gbFeatures.Controls.Add(this.btnDel);
            this.gbFeatures.Controls.Add(this.btnExec);
            this.gbFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFeatures.Location = new System.Drawing.Point(364, 229);
            this.gbFeatures.Name = "gbFeatures";
            this.gbFeatures.Size = new System.Drawing.Size(138, 149);
            this.gbFeatures.TabIndex = 2;
            this.gbFeatures.TabStop = false;
            this.gbFeatures.Text = "Các thao tác";
            // 
            // btnExec
            // 
            this.btnExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec.Location = new System.Drawing.Point(6, 21);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(129, 36);
            this.btnExec.TabIndex = 0;
            this.btnExec.Text = "Tìm món ăn";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(6, 63);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(129, 37);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(6, 106);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(90, 118);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(120, 16);
            this.lbInput.TabIndex = 3;
            this.lbInput.Text = "Thêm món ăn mới :";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(224, 115);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(275, 22);
            this.txtInput.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(370, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm món ăn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(90, 409);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(114, 16);
            this.lbOutput.TabIndex = 6;
            this.lbOutput.Text = "Món ăn hôm nay : ";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(224, 403);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(278, 22);
            this.txtOutput.TabIndex = 7;
            // 
            // lbBai08
            // 
            this.lbBai08.AutoSize = true;
            this.lbBai08.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBai08.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbBai08.Location = new System.Drawing.Point(148, 46);
            this.lbBai08.Name = "lbBai08";
            this.lbBai08.Size = new System.Drawing.Size(277, 37);
            this.lbBai08.TabIndex = 12;
            this.lbBai08.Text = "HÔM NAY ĂN GÌ";
            // 
            // Lab01_Bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 497);
            this.Controls.Add(this.lbBai08);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.gbFeatures);
            this.Controls.Add(this.gbFoods);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab01_Bai08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab01_Bai08";
            this.gbFoods.ResumeLayout(false);
            this.gbFeatures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbFoods;
        private System.Windows.Forms.GroupBox gbFoods;
        private System.Windows.Forms.GroupBox gbFeatures;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lbBai08;
    }
}