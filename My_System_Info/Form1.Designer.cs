﻿namespace My_System_Info
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
            this.SerialNumber = new System.Windows.Forms.Label();
            this.HDDSize = new System.Windows.Forms.Label();
            this.freeSpace = new System.Windows.Forms.Label();
            this.hostName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSize = true;
            this.SerialNumber.Location = new System.Drawing.Point(12, 45);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(43, 13);
            this.SerialNumber.TabIndex = 0;
            this.SerialNumber.Text = "Serial #";
            // 
            // HDDSize
            // 
            this.HDDSize.AutoSize = true;
            this.HDDSize.Location = new System.Drawing.Point(15, 76);
            this.HDDSize.Name = "HDDSize";
            this.HDDSize.Size = new System.Drawing.Size(51, 13);
            this.HDDSize.TabIndex = 1;
            this.HDDSize.Text = "HDDSize";
            // 
            // freeSpace
            // 
            this.freeSpace.AutoSize = true;
            this.freeSpace.Location = new System.Drawing.Point(18, 109);
            this.freeSpace.Name = "freeSpace";
            this.freeSpace.Size = new System.Drawing.Size(56, 13);
            this.freeSpace.TabIndex = 2;
            this.freeSpace.Text = "freeSpace";
            // 
            // hostName
            // 
            this.hostName.AutoSize = true;
            this.hostName.Location = new System.Drawing.Point(18, 138);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(60, 13);
            this.hostName.TabIndex = 3;
            this.hostName.Text = "Host Name";
            this.hostName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.hostName);
            this.Controls.Add(this.freeSpace);
            this.Controls.Add(this.HDDSize);
            this.Controls.Add(this.SerialNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SerialNumber;
        private System.Windows.Forms.Label HDDSize;
        private System.Windows.Forms.Label freeSpace;
        private System.Windows.Forms.Label hostName;
    }
}

