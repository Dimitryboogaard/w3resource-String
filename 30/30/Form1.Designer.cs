namespace _30
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
            this.lblCompareOrdinal = new System.Windows.Forms.Label();
            this.lblCompare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(15, 12);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 0;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblCompareOrdinal
            // 
            this.lblCompareOrdinal.AutoSize = true;
            this.lblCompareOrdinal.Location = new System.Drawing.Point(12, 38);
            this.lblCompareOrdinal.Name = "lblCompareOrdinal";
            this.lblCompareOrdinal.Size = new System.Drawing.Size(83, 13);
            this.lblCompareOrdinal.TabIndex = 1;
            this.lblCompareOrdinal.Text = "Compare ordinal";
            // 
            // lblCompare
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Location = new System.Drawing.Point(12, 51);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(49, 13);
            this.lblCompare.TabIndex = 2;
            this.lblCompare.Text = "Compare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 81);
            this.Controls.Add(this.lblCompare);
            this.Controls.Add(this.lblCompareOrdinal);
            this.Controls.Add(this.btnAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblCompareOrdinal;
        private System.Windows.Forms.Label lblCompare;
    }
}

