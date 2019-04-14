namespace _27
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
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblEnUs = new System.Windows.Forms.Label();
            this.lblcsCZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(12, 12);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 0;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblEnUs
            // 
            this.lblEnUs.AutoSize = true;
            this.lblEnUs.Location = new System.Drawing.Point(9, 38);
            this.lblEnUs.Name = "lblEnUs";
            this.lblEnUs.Size = new System.Drawing.Size(37, 13);
            this.lblEnUs.TabIndex = 1;
            this.lblEnUs.Text = "en-US";
            // 
            // lblcsCZ
            // 
            this.lblcsCZ.AutoSize = true;
            this.lblcsCZ.Location = new System.Drawing.Point(9, 51);
            this.lblcsCZ.Name = "lblcsCZ";
            this.lblcsCZ.Size = new System.Drawing.Size(35, 13);
            this.lblcsCZ.TabIndex = 2;
            this.lblcsCZ.Text = "cs-CZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 84);
            this.Controls.Add(this.lblcsCZ);
            this.Controls.Add(this.lblEnUs);
            this.Controls.Add(this.btnAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblEnUs;
        private System.Windows.Forms.Label lblcsCZ;
    }
}

