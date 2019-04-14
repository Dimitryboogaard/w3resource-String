namespace _24
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
            this.btnSorteren = new System.Windows.Forms.Button();
            this.rtUitvoer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSorteren
            // 
            this.btnSorteren.Location = new System.Drawing.Point(12, 12);
            this.btnSorteren.Name = "btnSorteren";
            this.btnSorteren.Size = new System.Drawing.Size(75, 23);
            this.btnSorteren.TabIndex = 0;
            this.btnSorteren.Text = "Sorteren";
            this.btnSorteren.UseVisualStyleBackColor = true;
            this.btnSorteren.Click += new System.EventHandler(this.btnSorteren_Click);
            // 
            // rtUitvoer
            // 
            this.rtUitvoer.Location = new System.Drawing.Point(12, 41);
            this.rtUitvoer.Name = "rtUitvoer";
            this.rtUitvoer.Size = new System.Drawing.Size(217, 177);
            this.rtUitvoer.TabIndex = 1;
            this.rtUitvoer.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 232);
            this.Controls.Add(this.rtUitvoer);
            this.Controls.Add(this.btnSorteren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSorteren;
        private System.Windows.Forms.RichTextBox rtUitvoer;
    }
}

