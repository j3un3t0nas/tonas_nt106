namespace LAB05
{
    partial class Bai01_Lab05
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
            this.txtFormAdd = new System.Windows.Forms.TextBox();
            this.txtToAdd = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFormAdd
            // 
            this.txtFormAdd.Location = new System.Drawing.Point(282, 81);
            this.txtFormAdd.Name = "txtFormAdd";
            this.txtFormAdd.Size = new System.Drawing.Size(100, 22);
            this.txtFormAdd.TabIndex = 0;
            // 
            // txtToAdd
            // 
            this.txtToAdd.Location = new System.Drawing.Point(350, 214);
            this.txtToAdd.Name = "txtToAdd";
            this.txtToAdd.Size = new System.Drawing.Size(100, 22);
            this.txtToAdd.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(501, 99);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 22);
            this.txtSubject.TabIndex = 2;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(380, 264);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(100, 22);
            this.txtBody.TabIndex = 3;
            // 
            // Bai01_Lab05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtToAdd);
            this.Controls.Add(this.txtFormAdd);
            this.Name = "Bai01_Lab05";
            this.Text = "Bai01_Lab05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormAdd;
        private System.Windows.Forms.TextBox txtToAdd;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
    }
}