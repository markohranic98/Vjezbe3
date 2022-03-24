namespace StudentiITimovi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jmbagText = new System.Windows.Forms.TextBox();
            this.imeText = new System.Windows.Forms.TextBox();
            this.prezimeText = new System.Windows.Forms.TextBox();
            this.ureduButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "JMBAG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime:";
            // 
            // jmbagText
            // 
            this.jmbagText.Location = new System.Drawing.Point(66, 29);
            this.jmbagText.Name = "jmbagText";
            this.jmbagText.Size = new System.Drawing.Size(100, 20);
            this.jmbagText.TabIndex = 3;
            // 
            // imeText
            // 
            this.imeText.Location = new System.Drawing.Point(66, 65);
            this.imeText.Name = "imeText";
            this.imeText.Size = new System.Drawing.Size(100, 20);
            this.imeText.TabIndex = 4;
            // 
            // prezimeText
            // 
            this.prezimeText.Location = new System.Drawing.Point(66, 96);
            this.prezimeText.Name = "prezimeText";
            this.prezimeText.Size = new System.Drawing.Size(100, 20);
            this.prezimeText.TabIndex = 5;
            // 
            // ureduButton
            // 
            this.ureduButton.Location = new System.Drawing.Point(29, 123);
            this.ureduButton.Name = "ureduButton";
            this.ureduButton.Size = new System.Drawing.Size(75, 23);
            this.ureduButton.TabIndex = 6;
            this.ureduButton.Text = "Okej";
            this.ureduButton.UseVisualStyleBackColor = true;
            this.ureduButton.Click += new System.EventHandler(this.ureduButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(110, 123);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 7;
            this.odustaniButton.Text = "Cancer";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 158);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.ureduButton);
            this.Controls.Add(this.prezimeText);
            this.Controls.Add(this.imeText);
            this.Controls.Add(this.jmbagText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jmbagText;
        private System.Windows.Forms.TextBox imeText;
        private System.Windows.Forms.TextBox prezimeText;
        private System.Windows.Forms.Button ureduButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}