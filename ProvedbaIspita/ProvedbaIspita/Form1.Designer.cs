namespace ProvedbaIspita
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pitanjeTextBox = new System.Windows.Forms.TextBox();
            this.odgovoriListBox = new System.Windows.Forms.ListBox();
            this.potvrdiOdgovorButton = new System.Windows.Forms.Button();
            this.sljedecePitanjeButton = new System.Windows.Forms.Button();
            this.potvrdenOdgovorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pitanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odgovori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Potvrden odgovor";
            // 
            // pitanjeTextBox
            // 
            this.pitanjeTextBox.Location = new System.Drawing.Point(143, 34);
            this.pitanjeTextBox.Name = "pitanjeTextBox";
            this.pitanjeTextBox.ReadOnly = true;
            this.pitanjeTextBox.Size = new System.Drawing.Size(172, 20);
            this.pitanjeTextBox.TabIndex = 3;
            // 
            // odgovoriListBox
            // 
            this.odgovoriListBox.FormattingEnabled = true;
            this.odgovoriListBox.Location = new System.Drawing.Point(143, 89);
            this.odgovoriListBox.Name = "odgovoriListBox";
            this.odgovoriListBox.Size = new System.Drawing.Size(172, 95);
            this.odgovoriListBox.TabIndex = 4;
            // 
            // potvrdiOdgovorButton
            // 
            this.potvrdiOdgovorButton.Location = new System.Drawing.Point(143, 199);
            this.potvrdiOdgovorButton.Name = "potvrdiOdgovorButton";
            this.potvrdiOdgovorButton.Size = new System.Drawing.Size(118, 32);
            this.potvrdiOdgovorButton.TabIndex = 5;
            this.potvrdiOdgovorButton.Text = "Potvrdi odgovor";
            this.potvrdiOdgovorButton.UseVisualStyleBackColor = true;
            this.potvrdiOdgovorButton.Click += new System.EventHandler(this.potvrdiOdgovorButton_Click);
            // 
            // sljedecePitanjeButton
            // 
            this.sljedecePitanjeButton.Location = new System.Drawing.Point(333, 89);
            this.sljedecePitanjeButton.Name = "sljedecePitanjeButton";
            this.sljedecePitanjeButton.Size = new System.Drawing.Size(141, 95);
            this.sljedecePitanjeButton.TabIndex = 6;
            this.sljedecePitanjeButton.Text = "Sljedece pitanje";
            this.sljedecePitanjeButton.UseVisualStyleBackColor = true;
            this.sljedecePitanjeButton.Click += new System.EventHandler(this.sljedecePitanjeButton_Click);
            // 
            // potvrdenOdgovorTextBox
            // 
            this.potvrdenOdgovorTextBox.Location = new System.Drawing.Point(143, 274);
            this.potvrdenOdgovorTextBox.Name = "potvrdenOdgovorTextBox";
            this.potvrdenOdgovorTextBox.ReadOnly = true;
            this.potvrdenOdgovorTextBox.Size = new System.Drawing.Size(172, 20);
            this.potvrdenOdgovorTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 315);
            this.Controls.Add(this.potvrdenOdgovorTextBox);
            this.Controls.Add(this.sljedecePitanjeButton);
            this.Controls.Add(this.potvrdiOdgovorButton);
            this.Controls.Add(this.odgovoriListBox);
            this.Controls.Add(this.pitanjeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pitanjeTextBox;
        private System.Windows.Forms.ListBox odgovoriListBox;
        private System.Windows.Forms.Button potvrdiOdgovorButton;
        private System.Windows.Forms.Button sljedecePitanjeButton;
        private System.Windows.Forms.TextBox potvrdenOdgovorTextBox;
    }
}

