namespace BodoviIAktivnosti
{
    partial class NoviBodoviForm
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
            this.imePrezimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vjezbaLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mabPointsLabel = new System.Windows.Forms.Label();
            this.bodoviTextBox = new System.Windows.Forms.TextBox();
            this.prihvatiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // imePrezimeLabel
            // 
            this.imePrezimeLabel.AutoSize = true;
            this.imePrezimeLabel.Location = new System.Drawing.Point(111, 45);
            this.imePrezimeLabel.Name = "imePrezimeLabel";
            this.imePrezimeLabel.Size = new System.Drawing.Size(35, 13);
            this.imePrezimeLabel.TabIndex = 1;
            this.imePrezimeLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provjera:";
            // 
            // vjezbaLabel
            // 
            this.vjezbaLabel.AutoSize = true;
            this.vjezbaLabel.Location = new System.Drawing.Point(111, 80);
            this.vjezbaLabel.Name = "vjezbaLabel";
            this.vjezbaLabel.Size = new System.Drawing.Size(35, 13);
            this.vjezbaLabel.TabIndex = 3;
            this.vjezbaLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bodovi:";
            // 
            // mabPointsLabel
            // 
            this.mabPointsLabel.AutoSize = true;
            this.mabPointsLabel.Location = new System.Drawing.Point(152, 119);
            this.mabPointsLabel.Name = "mabPointsLabel";
            this.mabPointsLabel.Size = new System.Drawing.Size(35, 13);
            this.mabPointsLabel.TabIndex = 5;
            this.mabPointsLabel.Text = "label6";
            // 
            // bodoviTextBox
            // 
            this.bodoviTextBox.Location = new System.Drawing.Point(91, 116);
            this.bodoviTextBox.Name = "bodoviTextBox";
            this.bodoviTextBox.Size = new System.Drawing.Size(55, 20);
            this.bodoviTextBox.TabIndex = 6;
            // 
            // prihvatiButton
            // 
            this.prihvatiButton.Location = new System.Drawing.Point(28, 147);
            this.prihvatiButton.Name = "prihvatiButton";
            this.prihvatiButton.Size = new System.Drawing.Size(75, 23);
            this.prihvatiButton.TabIndex = 7;
            this.prihvatiButton.Text = "Pohrani";
            this.prihvatiButton.UseVisualStyleBackColor = true;
            this.prihvatiButton.Click += new System.EventHandler(this.prihvatiButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(134, 147);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 8;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // NoviBodoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 182);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.prihvatiButton);
            this.Controls.Add(this.bodoviTextBox);
            this.Controls.Add(this.mabPointsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vjezbaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imePrezimeLabel);
            this.Controls.Add(this.label1);
            this.Name = "NoviBodoviForm";
            this.Text = "Unesi bodove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label imePrezimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vjezbaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mabPointsLabel;
        private System.Windows.Forms.TextBox bodoviTextBox;
        private System.Windows.Forms.Button prihvatiButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}