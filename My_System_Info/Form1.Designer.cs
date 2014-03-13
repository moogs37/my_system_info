namespace My_System_Info
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}

