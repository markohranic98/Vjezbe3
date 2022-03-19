namespace NogometnoPrvenstvo
{
    partial class DodajUtakmicuForm
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
            this.domacinComboBox = new System.Windows.Forms.ComboBox();
            this.brojZgoditakaDomacinaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zgodiciGostTextBox = new System.Windows.Forms.TextBox();
            this.gostComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datumTextBox = new System.Windows.Forms.TextBox();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.zakazanoRadioButton = new System.Windows.Forms.RadioButton();
            this.odigranaRadioButton = new System.Windows.Forms.RadioButton();
            this.spremibutton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domaćin";
            // 
            // domacinComboBox
            // 
            this.domacinComboBox.FormattingEnabled = true;
            this.domacinComboBox.Location = new System.Drawing.Point(13, 30);
            this.domacinComboBox.Name = "domacinComboBox";
            this.domacinComboBox.Size = new System.Drawing.Size(121, 21);
            this.domacinComboBox.TabIndex = 1;
            // 
            // brojZgoditakaDomacinaTextBox
            // 
            this.brojZgoditakaDomacinaTextBox.Location = new System.Drawing.Point(141, 30);
            this.brojZgoditakaDomacinaTextBox.Name = "brojZgoditakaDomacinaTextBox";
            this.brojZgoditakaDomacinaTextBox.Size = new System.Drawing.Size(100, 20);
            this.brojZgoditakaDomacinaTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj zgoditaka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj zgoditaka:";
            // 
            // zgodiciGostTextBox
            // 
            this.zgodiciGostTextBox.Location = new System.Drawing.Point(141, 92);
            this.zgodiciGostTextBox.Name = "zgodiciGostTextBox";
            this.zgodiciGostTextBox.Size = new System.Drawing.Size(100, 20);
            this.zgodiciGostTextBox.TabIndex = 6;
            // 
            // gostComboBox
            // 
            this.gostComboBox.FormattingEnabled = true;
            this.gostComboBox.Location = new System.Drawing.Point(13, 92);
            this.gostComboBox.Name = "gostComboBox";
            this.gostComboBox.Size = new System.Drawing.Size(121, 21);
            this.gostComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum";
            // 
            // datumTextBox
            // 
            this.datumTextBox.Location = new System.Drawing.Point(13, 151);
            this.datumTextBox.Name = "datumTextBox";
            this.datumTextBox.Size = new System.Drawing.Size(100, 20);
            this.datumTextBox.TabIndex = 9;
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.odigranaRadioButton);
            this.statusGroupBox.Controls.Add(this.zakazanoRadioButton);
            this.statusGroupBox.Location = new System.Drawing.Point(13, 178);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(214, 63);
            this.statusGroupBox.TabIndex = 10;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Status utakmice:";
            // 
            // zakazanoRadioButton
            // 
            this.zakazanoRadioButton.AutoSize = true;
            this.zakazanoRadioButton.Location = new System.Drawing.Point(15, 29);
            this.zakazanoRadioButton.Name = "zakazanoRadioButton";
            this.zakazanoRadioButton.Size = new System.Drawing.Size(73, 17);
            this.zakazanoRadioButton.TabIndex = 0;
            this.zakazanoRadioButton.TabStop = true;
            this.zakazanoRadioButton.Text = "Zakazana";
            this.zakazanoRadioButton.UseVisualStyleBackColor = true;
            // 
            // odigranaRadioButton
            // 
            this.odigranaRadioButton.AutoSize = true;
            this.odigranaRadioButton.Location = new System.Drawing.Point(95, 29);
            this.odigranaRadioButton.Name = "odigranaRadioButton";
            this.odigranaRadioButton.Size = new System.Drawing.Size(114, 17);
            this.odigranaRadioButton.TabIndex = 1;
            this.odigranaRadioButton.TabStop = true;
            this.odigranaRadioButton.Text = "Odigrana utakmica";
            this.odigranaRadioButton.UseVisualStyleBackColor = true;
            // 
            // spremibutton
            // 
            this.spremibutton.Location = new System.Drawing.Point(59, 270);
            this.spremibutton.Name = "spremibutton";
            this.spremibutton.Size = new System.Drawing.Size(75, 23);
            this.spremibutton.TabIndex = 11;
            this.spremibutton.Text = "Spremi";
            this.spremibutton.UseVisualStyleBackColor = true;
            this.spremibutton.Click += new System.EventHandler(this.spremibutton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(151, 270);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 12;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // DodajUtakmicuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 316);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.spremibutton);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.datumTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zgodiciGostTextBox);
            this.Controls.Add(this.gostComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brojZgoditakaDomacinaTextBox);
            this.Controls.Add(this.domacinComboBox);
            this.Controls.Add(this.label1);
            this.Name = "DodajUtakmicuForm";
            this.Text = "Dodaj utakmicu";
            this.Load += new System.EventHandler(this.DodajUtakmicuForm_Load);
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox domacinComboBox;
        private System.Windows.Forms.TextBox brojZgoditakaDomacinaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zgodiciGostTextBox;
        private System.Windows.Forms.ComboBox gostComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox datumTextBox;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.RadioButton zakazanoRadioButton;
        private System.Windows.Forms.RadioButton odigranaRadioButton;
        private System.Windows.Forms.Button spremibutton;
        private System.Windows.Forms.Button odustaniButton;
    }
}