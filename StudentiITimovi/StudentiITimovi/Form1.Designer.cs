namespace StudentiITimovi
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
            this.nedodjeljenistudentiListBox = new System.Windows.Forms.ListBox();
            this.timoviListBox = new System.Windows.Forms.ListBox();
            this.clanoviTimaListBox = new System.Windows.Forms.ListBox();
            this.noviStudentButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.ukloniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nedodjeljenistudentiListBox
            // 
            this.nedodjeljenistudentiListBox.FormattingEnabled = true;
            this.nedodjeljenistudentiListBox.Location = new System.Drawing.Point(13, 13);
            this.nedodjeljenistudentiListBox.Name = "nedodjeljenistudentiListBox";
            this.nedodjeljenistudentiListBox.Size = new System.Drawing.Size(158, 303);
            this.nedodjeljenistudentiListBox.TabIndex = 0;
            // 
            // timoviListBox
            // 
            this.timoviListBox.FormattingEnabled = true;
            this.timoviListBox.Location = new System.Drawing.Point(177, 12);
            this.timoviListBox.Name = "timoviListBox";
            this.timoviListBox.Size = new System.Drawing.Size(158, 303);
            this.timoviListBox.TabIndex = 1;
            // 
            // clanoviTimaListBox
            // 
            this.clanoviTimaListBox.FormattingEnabled = true;
            this.clanoviTimaListBox.Location = new System.Drawing.Point(341, 12);
            this.clanoviTimaListBox.Name = "clanoviTimaListBox";
            this.clanoviTimaListBox.Size = new System.Drawing.Size(158, 303);
            this.clanoviTimaListBox.TabIndex = 2;
            // 
            // noviStudentButton
            // 
            this.noviStudentButton.Location = new System.Drawing.Point(29, 340);
            this.noviStudentButton.Name = "noviStudentButton";
            this.noviStudentButton.Size = new System.Drawing.Size(100, 23);
            this.noviStudentButton.TabIndex = 3;
            this.noviStudentButton.Text = "Novi studenti";
            this.noviStudentButton.UseVisualStyleBackColor = true;
            this.noviStudentButton.Click += new System.EventHandler(this.noviStudentButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(135, 340);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(98, 23);
            this.dodajButton.TabIndex = 4;
            this.dodajButton.Text = "Dodaj u tim";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // ukloniButton
            // 
            this.ukloniButton.Location = new System.Drawing.Point(341, 340);
            this.ukloniButton.Name = "ukloniButton";
            this.ukloniButton.Size = new System.Drawing.Size(114, 23);
            this.ukloniButton.TabIndex = 5;
            this.ukloniButton.Text = "Ukloni";
            this.ukloniButton.UseVisualStyleBackColor = true;
            this.ukloniButton.Click += new System.EventHandler(this.ukloniButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 392);
            this.Controls.Add(this.ukloniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.noviStudentButton);
            this.Controls.Add(this.clanoviTimaListBox);
            this.Controls.Add(this.timoviListBox);
            this.Controls.Add(this.nedodjeljenistudentiListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox nedodjeljenistudentiListBox;
        private System.Windows.Forms.ListBox timoviListBox;
        private System.Windows.Forms.ListBox clanoviTimaListBox;
        private System.Windows.Forms.Button noviStudentButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button ukloniButton;
    }
}

