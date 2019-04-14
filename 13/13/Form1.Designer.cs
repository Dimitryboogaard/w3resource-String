namespace _13
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
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbLengte = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblLengte = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbUitvoer = new System.Windows.Forms.TextBox();
            this.lblUitvoer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(59, 12);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(220, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(59, 38);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(100, 20);
            this.tbStart.TabIndex = 1;
            // 
            // tbLengte
            // 
            this.tbLengte.Location = new System.Drawing.Point(59, 64);
            this.tbLengte.Name = "tbLengte";
            this.tbLengte.Size = new System.Drawing.Size(100, 20);
            this.tbLengte.TabIndex = 2;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(16, 12);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 3;
            this.lblInvoer.Text = "Invoer";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(24, 41);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start";
            // 
            // lblLengte
            // 
            this.lblLengte.AutoSize = true;
            this.lblLengte.Location = new System.Drawing.Point(13, 67);
            this.lblLengte.Name = "lblLengte";
            this.lblLengte.Size = new System.Drawing.Size(40, 13);
            this.lblLengte.TabIndex = 5;
            this.lblLengte.Text = "Lengte";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(59, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 6;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbUitvoer
            // 
            this.tbUitvoer.Location = new System.Drawing.Point(59, 119);
            this.tbUitvoer.Name = "tbUitvoer";
            this.tbUitvoer.Size = new System.Drawing.Size(220, 20);
            this.tbUitvoer.TabIndex = 7;
            // 
            // lblUitvoer
            // 
            this.lblUitvoer.AutoSize = true;
            this.lblUitvoer.Location = new System.Drawing.Point(12, 122);
            this.lblUitvoer.Name = "lblUitvoer";
            this.lblUitvoer.Size = new System.Drawing.Size(41, 13);
            this.lblUitvoer.TabIndex = 8;
            this.lblUitvoer.Text = "Uitvoer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 159);
            this.Controls.Add(this.lblUitvoer);
            this.Controls.Add(this.tbUitvoer);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblLengte);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbLengte);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.tbInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbLengte;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblLengte;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbUitvoer;
        private System.Windows.Forms.Label lblUitvoer;
    }
}

