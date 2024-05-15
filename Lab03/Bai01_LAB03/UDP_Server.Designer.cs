namespace Bai01_LAB03
{
    partial class UDP_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDP_Server));
            this.btnListen = new System.Windows.Forms.Button();
            this.lstReiMessages = new System.Windows.Forms.ListView();
            this.lbReiMessages = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(457, 27);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(123, 47);
            this.btnListen.TabIndex = 9;
            this.btnListen.Text = "Nghe";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // lstReiMessages
            // 
            this.lstReiMessages.HideSelection = false;
            this.lstReiMessages.Location = new System.Drawing.Point(35, 83);
            this.lstReiMessages.Name = "lstReiMessages";
            this.lstReiMessages.Size = new System.Drawing.Size(545, 206);
            this.lstReiMessages.TabIndex = 8;
            this.lstReiMessages.UseCompatibleStateImageBehavior = false;
            this.lstReiMessages.View = System.Windows.Forms.View.List;
            // 
            // lbReiMessages
            // 
            this.lbReiMessages.AutoSize = true;
            this.lbReiMessages.Location = new System.Drawing.Point(32, 64);
            this.lbReiMessages.Name = "lbReiMessages";
            this.lbReiMessages.Size = new System.Drawing.Size(141, 16);
            this.lbReiMessages.TabIndex = 7;
            this.lbReiMessages.Text = "Thông điệp nhận được";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(75, 27);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(145, 22);
            this.txtPort.TabIndex = 6;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(32, 30);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(37, 16);
            this.lbPort.TabIndex = 5;
            this.lbPort.Text = "Port :";
            // 
            // UDP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 317);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.lstReiMessages);
            this.Controls.Add(this.lbReiMessages);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UDP_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ListView lstReiMessages;
        private System.Windows.Forms.Label lbReiMessages;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbPort;
    }
}