namespace _6
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
            this.tbString1 = new System.Windows.Forms.TextBox();
            this.tbString2 = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbString1
            // 
            this.tbString1.Location = new System.Drawing.Point(61, 12);
            this.tbString1.Name = "tbString1";
            this.tbString1.Size = new System.Drawing.Size(163, 20);
            this.tbString1.TabIndex = 0;
            // 
            // tbString2
            // 
            this.tbString2.Location = new System.Drawing.Point(61, 38);
            this.tbString2.Name = "tbString2";
            this.tbString2.Size = new System.Drawing.Size(163, 20);
            this.tbString2.TabIndex = 1;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(61, 64);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 2;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Location = new System.Drawing.Point(12, 15);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(43, 13);
            this.lblString1.TabIndex = 3;
            this.lblString1.Text = "String 1";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Location = new System.Drawing.Point(12, 41);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(43, 13);
            this.lblString2.TabIndex = 4;
            this.lblString2.Text = "String 2";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(58, 90);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 5;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 109);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbString2);
            this.Controls.Add(this.tbString1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbString1;
        private System.Windows.Forms.TextBox tbString2;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

