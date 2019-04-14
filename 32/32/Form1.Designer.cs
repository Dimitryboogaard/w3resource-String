namespace _32
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
            this.lblSomeText123 = new System.Windows.Forms.Label();
            this.lblSomeTextSomeText = new System.Windows.Forms.Label();
            this.lblSomeTextSomeText2 = new System.Windows.Forms.Label();
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
            // lblSomeText123
            // 
            this.lblSomeText123.AutoSize = true;
            this.lblSomeText123.Location = new System.Drawing.Point(12, 38);
            this.lblSomeText123.Name = "lblSomeText123";
            this.lblSomeText123.Size = new System.Drawing.Size(73, 13);
            this.lblSomeText123.TabIndex = 1;
            this.lblSomeText123.Text = "some text 123";
            // 
            // lblSomeTextSomeText
            // 
            this.lblSomeTextSomeText.AutoSize = true;
            this.lblSomeTextSomeText.Location = new System.Drawing.Point(12, 51);
            this.lblSomeTextSomeText.Name = "lblSomeTextSomeText";
            this.lblSomeTextSomeText.Size = new System.Drawing.Size(100, 13);
            this.lblSomeTextSomeText.TabIndex = 2;
            this.lblSomeTextSomeText.Text = "some text some text";
            // 
            // lblSomeTextSomeText2
            // 
            this.lblSomeTextSomeText2.AutoSize = true;
            this.lblSomeTextSomeText2.Location = new System.Drawing.Point(12, 64);
            this.lblSomeTextSomeText2.Name = "lblSomeTextSomeText2";
            this.lblSomeTextSomeText2.Size = new System.Drawing.Size(106, 13);
            this.lblSomeTextSomeText2.TabIndex = 3;
            this.lblSomeTextSomeText2.Text = "some text Some Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 96);
            this.Controls.Add(this.lblSomeTextSomeText2);
            this.Controls.Add(this.lblSomeTextSomeText);
            this.Controls.Add(this.lblSomeText123);
            this.Controls.Add(this.btnAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblSomeText123;
        private System.Windows.Forms.Label lblSomeTextSomeText;
        private System.Windows.Forms.Label lblSomeTextSomeText2;
    }
}

