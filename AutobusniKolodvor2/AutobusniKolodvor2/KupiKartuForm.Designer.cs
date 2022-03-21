namespace AutobusniKolodvor2
{
    partial class KupiKartuForm
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
            this.opcijeKarteGroupBox = new System.Windows.Forms.GroupBox();
            this.ispisKarteGroupBox = new System.Windows.Forms.GroupBox();
            this.ispisiKartuButton = new System.Windows.Forms.Button();
            this.povratnaCheckBox = new System.Windows.Forms.CheckBox();
            this.prtljagaCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vrstaKarteComboBox = new System.Windows.Forms.ComboBox();
            this.ispisTextBox = new System.Windows.Forms.TextBox();
            this.opcijeKarteGroupBox.SuspendLayout();
            this.ispisKarteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // opcijeKarteGroupBox
            // 
            this.opcijeKarteGroupBox.Controls.Add(this.vrstaKarteComboBox);
            this.opcijeKarteGroupBox.Controls.Add(this.label2);
            this.opcijeKarteGroupBox.Controls.Add(this.label1);
            this.opcijeKarteGroupBox.Controls.Add(this.prtljagaCheckBox);
            this.opcijeKarteGroupBox.Controls.Add(this.povratnaCheckBox);
            this.opcijeKarteGroupBox.Location = new System.Drawing.Point(13, 13);
            this.opcijeKarteGroupBox.Name = "opcijeKarteGroupBox";
            this.opcijeKarteGroupBox.Size = new System.Drawing.Size(235, 137);
            this.opcijeKarteGroupBox.TabIndex = 0;
            this.opcijeKarteGroupBox.TabStop = false;
            this.opcijeKarteGroupBox.Text = "Opcije karte:";
            // 
            // ispisKarteGroupBox
            // 
            this.ispisKarteGroupBox.Controls.Add(this.ispisTextBox);
            this.ispisKarteGroupBox.Location = new System.Drawing.Point(13, 184);
            this.ispisKarteGroupBox.Name = "ispisKarteGroupBox";
            this.ispisKarteGroupBox.Size = new System.Drawing.Size(235, 166);
            this.ispisKarteGroupBox.TabIndex = 1;
            this.ispisKarteGroupBox.TabStop = false;
            this.ispisKarteGroupBox.Text = "Ispis karte:";
            // 
            // ispisiKartuButton
            // 
            this.ispisiKartuButton.Location = new System.Drawing.Point(173, 156);
            this.ispisiKartuButton.Name = "ispisiKartuButton";
            this.ispisiKartuButton.Size = new System.Drawing.Size(75, 23);
            this.ispisiKartuButton.TabIndex = 2;
            this.ispisiKartuButton.Text = "Ispiši kartu";
            this.ispisiKartuButton.UseVisualStyleBackColor = true;
            this.ispisiKartuButton.Click += new System.EventHandler(this.ispisiKartuButton_Click);
            // 
            // povratnaCheckBox
            // 
            this.povratnaCheckBox.AutoSize = true;
            this.povratnaCheckBox.Location = new System.Drawing.Point(109, 73);
            this.povratnaCheckBox.Name = "povratnaCheckBox";
            this.povratnaCheckBox.Size = new System.Drawing.Size(102, 17);
            this.povratnaCheckBox.TabIndex = 0;
            this.povratnaCheckBox.Text = "Povratna karta?";
            this.povratnaCheckBox.UseVisualStyleBackColor = true;
            // 
            // prtljagaCheckBox
            // 
            this.prtljagaCheckBox.AutoSize = true;
            this.prtljagaCheckBox.Location = new System.Drawing.Point(109, 96);
            this.prtljagaCheckBox.Name = "prtljagaCheckBox";
            this.prtljagaCheckBox.Size = new System.Drawing.Size(67, 17);
            this.prtljagaCheckBox.TabIndex = 1;
            this.prtljagaCheckBox.Text = "Prtljaga?";
            this.prtljagaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vrsta karte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dodatno:";
            // 
            // vrstaKarteComboBox
            // 
            this.vrstaKarteComboBox.FormattingEnabled = true;
            this.vrstaKarteComboBox.Location = new System.Drawing.Point(108, 36);
            this.vrstaKarteComboBox.Name = "vrstaKarteComboBox";
            this.vrstaKarteComboBox.Size = new System.Drawing.Size(121, 21);
            this.vrstaKarteComboBox.TabIndex = 4;
            // 
            // ispisTextBox
            // 
            this.ispisTextBox.Location = new System.Drawing.Point(7, 19);
            this.ispisTextBox.Multiline = true;
            this.ispisTextBox.Name = "ispisTextBox";
            this.ispisTextBox.ReadOnly = true;
            this.ispisTextBox.Size = new System.Drawing.Size(222, 141);
            this.ispisTextBox.TabIndex = 0;
            // 
            // KupiKartuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 362);
            this.Controls.Add(this.ispisiKartuButton);
            this.Controls.Add(this.ispisKarteGroupBox);
            this.Controls.Add(this.opcijeKarteGroupBox);
            this.Name = "KupiKartuForm";
            this.Text = "Kupi kartu";
            this.opcijeKarteGroupBox.ResumeLayout(false);
            this.opcijeKarteGroupBox.PerformLayout();
            this.ispisKarteGroupBox.ResumeLayout(false);
            this.ispisKarteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox opcijeKarteGroupBox;
        private System.Windows.Forms.GroupBox ispisKarteGroupBox;
        private System.Windows.Forms.Button ispisiKartuButton;
        private System.Windows.Forms.CheckBox prtljagaCheckBox;
        private System.Windows.Forms.CheckBox povratnaCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vrstaKarteComboBox;
        public System.Windows.Forms.TextBox ispisTextBox;
    }
}