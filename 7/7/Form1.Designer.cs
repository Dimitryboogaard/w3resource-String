namespace _7
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
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.lblLeesTekens = new System.Windows.Forms.Label();
            this.lblCijfers = new System.Windows.Forms.Label();
            this.lblLetters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(55, 38);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 1;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(55, 12);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(221, 20);
            this.tbInvoer.TabIndex = 2;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(12, 15);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 3;
            this.lblInvoer.Text = "Invoer";
            // 
            // lblLeesTekens
            // 
            this.lblLeesTekens.AutoSize = true;
            this.lblLeesTekens.Location = new System.Drawing.Point(52, 64);
            this.lblLeesTekens.Name = "lblLeesTekens";
            this.lblLeesTekens.Size = new System.Drawing.Size(62, 13);
            this.lblLeesTekens.TabIndex = 4;
            this.lblLeesTekens.Text = "Leestekens";
            // 
            // lblCijfers
            // 
            this.lblCijfers.AutoSize = true;
            this.lblCijfers.Location = new System.Drawing.Point(52, 77);
            this.lblCijfers.Name = "lblCijfers";
            this.lblCijfers.Size = new System.Drawing.Size(35, 13);
            this.lblCijfers.TabIndex = 5;
            this.lblCijfers.Text = "Cijfers";
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Location = new System.Drawing.Point(52, 90);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(39, 13);
            this.lblLetters.TabIndex = 6;
            this.lblLetters.Text = "Letters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 109);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.lblCijfers);
            this.Controls.Add(this.lblLeesTekens);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbInvoer);
            this.Controls.Add(this.btnAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Label lblLeesTekens;
        private System.Windows.Forms.Label lblCijfers;
        private System.Windows.Forms.Label lblLetters;
    }
}

