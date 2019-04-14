namespace _20
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
            this.tbSub = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(55, 12);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(278, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // tbSub
            // 
            this.tbSub.Location = new System.Drawing.Point(55, 38);
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(100, 20);
            this.tbSub.TabIndex = 1;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(55, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 2;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
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
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(23, 41);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(26, 13);
            this.lblSub.TabIndex = 4;
            this.lblSub.Text = "Sub";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(52, 116);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(0, 13);
            this.lblAntwoord.TabIndex = 5;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(55, 64);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(100, 20);
            this.tbText.TabIndex = 6;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(21, 67);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 7;
            this.lblText.Text = "Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 139);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.tbInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.TextBox tbSub;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lblText;
    }
}

