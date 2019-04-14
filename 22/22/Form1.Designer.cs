namespace _22
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
            this.btnOngevoelig = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.btnGevoelig = new System.Windows.Forms.Button();
            this.lblAntwoord2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOngevoelig
            // 
            this.btnOngevoelig.Location = new System.Drawing.Point(12, 12);
            this.btnOngevoelig.Name = "btnOngevoelig";
            this.btnOngevoelig.Size = new System.Drawing.Size(75, 23);
            this.btnOngevoelig.TabIndex = 0;
            this.btnOngevoelig.Text = "Ongevoelig";
            this.btnOngevoelig.UseVisualStyleBackColor = true;
            this.btnOngevoelig.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(12, 38);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 1;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // btnGevoelig
            // 
            this.btnGevoelig.Location = new System.Drawing.Point(12, 54);
            this.btnGevoelig.Name = "btnGevoelig";
            this.btnGevoelig.Size = new System.Drawing.Size(75, 23);
            this.btnGevoelig.TabIndex = 2;
            this.btnGevoelig.Text = "Gevoelig";
            this.btnGevoelig.UseVisualStyleBackColor = true;
            this.btnGevoelig.Click += new System.EventHandler(this.btnGevoelig_Click);
            // 
            // lblAntwoord2
            // 
            this.lblAntwoord2.AutoSize = true;
            this.lblAntwoord2.Location = new System.Drawing.Point(12, 80);
            this.lblAntwoord2.Name = "lblAntwoord2";
            this.lblAntwoord2.Size = new System.Drawing.Size(61, 13);
            this.lblAntwoord2.TabIndex = 3;
            this.lblAntwoord2.Text = "Antwoord 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(126, 117);
            this.Controls.Add(this.lblAntwoord2);
            this.Controls.Add(this.btnGevoelig);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnOngevoelig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOngevoelig;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.Button btnGevoelig;
        private System.Windows.Forms.Label lblAntwoord2;
    }
}

