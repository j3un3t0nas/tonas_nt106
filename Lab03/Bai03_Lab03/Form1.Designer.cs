﻿namespace Bai03_Lab03
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTCPServer = new System.Windows.Forms.Button();
            this.btnTCPClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTCPServer
            // 
            this.btnTCPServer.Location = new System.Drawing.Point(78, 207);
            this.btnTCPServer.Name = "btnTCPServer";
            this.btnTCPServer.Size = new System.Drawing.Size(131, 48);
            this.btnTCPServer.TabIndex = 0;
            this.btnTCPServer.Text = "Mở TCP Server";
            this.btnTCPServer.UseVisualStyleBackColor = true;
            this.btnTCPServer.Click += new System.EventHandler(this.btnTCPServer_Click);
            // 
            // btnTCPClient
            // 
            this.btnTCPClient.Location = new System.Drawing.Point(308, 207);
            this.btnTCPClient.Name = "btnTCPClient";
            this.btnTCPClient.Size = new System.Drawing.Size(131, 48);
            this.btnTCPClient.TabIndex = 1;
            this.btnTCPClient.Text = "Mở TCP Client";
            this.btnTCPClient.UseVisualStyleBackColor = true;
            this.btnTCPClient.Click += new System.EventHandler(this.btnTCPClient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(155, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "MSSV : 22521311";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(180, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "LAB03 : Bài 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 345);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTCPClient);
            this.Controls.Add(this.btnTCPServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai03_Lab03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTCPServer;
        private System.Windows.Forms.Button btnTCPClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

