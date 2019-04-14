namespace _10
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
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.tbTeken = new System.Windows.Forms.TextBox();
            this.lblTeken = new System.Windows.Forms.Label();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(56, 12);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(280, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(13, 15);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 1;
            this.lblInvoer.Text = "Invoer";
            // 
            // tbTeken
            // 
            this.tbTeken.Location = new System.Drawing.Point(56, 38);
            this.tbTeken.Name = "tbTeken";
            this.tbTeken.Size = new System.Drawing.Size(52, 20);
            this.tbTeken.TabIndex = 2;
            // 
            // lblTeken
            // 
            this.lblTeken.AutoSize = true;
            this.lblTeken.Location = new System.Drawing.Point(12, 41);
            this.lblTeken.Name = "lblTeken";
            this.lblTeken.Size = new System.Drawing.Size(38, 13);
            this.lblTeken.TabIndex = 3;
            this.lblTeken.Text = "Teken";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(56, 90);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 4;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(56, 64);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 5;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 116);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.lblTeken);
            this.Controls.Add(this.tbTeken);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.TextBox tbTeken;
        private System.Windows.Forms.Label lblTeken;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

