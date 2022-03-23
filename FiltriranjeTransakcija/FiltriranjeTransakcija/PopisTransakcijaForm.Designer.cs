namespace FiltriranjeTransakcija
{
    partial class PopisTransakcijaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.racunComboBox = new System.Windows.Forms.ComboBox();
            this.uplateRadioButton = new System.Windows.Forms.RadioButton();
            this.isplateRadioButton = new System.Windows.Forms.RadioButton();
            this.sveRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filtrirajButton = new System.Windows.Forms.Button();
            this.ocistiButton = new System.Windows.Forms.Button();
            this.racunDataGridView = new System.Windows.Forms.DataGridView();
            this.detaljiRacunaButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racunDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.racunComboBox);
            this.groupBox1.Controls.Add(this.uplateRadioButton);
            this.groupBox1.Controls.Add(this.isplateRadioButton);
            this.groupBox1.Controls.Add(this.sveRadioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter:";
            // 
            // racunComboBox
            // 
            this.racunComboBox.FormattingEnabled = true;
            this.racunComboBox.Location = new System.Drawing.Point(89, 20);
            this.racunComboBox.Name = "racunComboBox";
            this.racunComboBox.Size = new System.Drawing.Size(171, 21);
            this.racunComboBox.TabIndex = 5;
            this.racunComboBox.SelectedValueChanged += new System.EventHandler(this.racunComboBox_SelectedValueChanged);
            // 
            // uplateRadioButton
            // 
            this.uplateRadioButton.AutoSize = true;
            this.uplateRadioButton.Location = new System.Drawing.Point(229, 50);
            this.uplateRadioButton.Name = "uplateRadioButton";
            this.uplateRadioButton.Size = new System.Drawing.Size(56, 17);
            this.uplateRadioButton.TabIndex = 4;
            this.uplateRadioButton.TabStop = true;
            this.uplateRadioButton.Text = "Uplate";
            this.uplateRadioButton.UseVisualStyleBackColor = true;
            // 
            // isplateRadioButton
            // 
            this.isplateRadioButton.AutoSize = true;
            this.isplateRadioButton.Location = new System.Drawing.Point(167, 50);
            this.isplateRadioButton.Name = "isplateRadioButton";
            this.isplateRadioButton.Size = new System.Drawing.Size(56, 17);
            this.isplateRadioButton.TabIndex = 3;
            this.isplateRadioButton.TabStop = true;
            this.isplateRadioButton.Text = "Isplate";
            this.isplateRadioButton.UseVisualStyleBackColor = true;
            // 
            // sveRadioButton
            // 
            this.sveRadioButton.AutoSize = true;
            this.sveRadioButton.Location = new System.Drawing.Point(117, 50);
            this.sveRadioButton.Name = "sveRadioButton";
            this.sveRadioButton.Size = new System.Drawing.Size(44, 17);
            this.sveRadioButton.TabIndex = 2;
            this.sveRadioButton.TabStop = true;
            this.sveRadioButton.Text = "Sve";
            this.sveRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip transakcije:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Racun";
            // 
            // filtrirajButton
            // 
            this.filtrirajButton.Location = new System.Drawing.Point(381, 52);
            this.filtrirajButton.Name = "filtrirajButton";
            this.filtrirajButton.Size = new System.Drawing.Size(105, 47);
            this.filtrirajButton.TabIndex = 1;
            this.filtrirajButton.Text = "Filtriraj";
            this.filtrirajButton.UseVisualStyleBackColor = true;
            this.filtrirajButton.Click += new System.EventHandler(this.filtrirajButton_Click);
            // 
            // ocistiButton
            // 
            this.ocistiButton.Location = new System.Drawing.Point(493, 52);
            this.ocistiButton.Name = "ocistiButton";
            this.ocistiButton.Size = new System.Drawing.Size(100, 47);
            this.ocistiButton.TabIndex = 2;
            this.ocistiButton.Text = "Ocisti";
            this.ocistiButton.UseVisualStyleBackColor = true;
            this.ocistiButton.Click += new System.EventHandler(this.ocistiButton_Click);
            // 
            // racunDataGridView
            // 
            this.racunDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racunDataGridView.Location = new System.Drawing.Point(25, 124);
            this.racunDataGridView.Name = "racunDataGridView";
            this.racunDataGridView.Size = new System.Drawing.Size(568, 227);
            this.racunDataGridView.TabIndex = 3;
            // 
            // detaljiRacunaButton
            // 
            this.detaljiRacunaButton.Location = new System.Drawing.Point(479, 357);
            this.detaljiRacunaButton.Name = "detaljiRacunaButton";
            this.detaljiRacunaButton.Size = new System.Drawing.Size(89, 49);
            this.detaljiRacunaButton.TabIndex = 4;
            this.detaljiRacunaButton.Text = "Detalji racuna";
            this.detaljiRacunaButton.UseVisualStyleBackColor = true;
            this.detaljiRacunaButton.Click += new System.EventHandler(this.detaljiRacunaButton_Click);
            // 
            // PopisTransakcijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 425);
            this.Controls.Add(this.detaljiRacunaButton);
            this.Controls.Add(this.racunDataGridView);
            this.Controls.Add(this.ocistiButton);
            this.Controls.Add(this.filtrirajButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "PopisTransakcijaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PopisTransakcijaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racunDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton uplateRadioButton;
        private System.Windows.Forms.RadioButton isplateRadioButton;
        private System.Windows.Forms.RadioButton sveRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filtrirajButton;
        private System.Windows.Forms.Button ocistiButton;
        private System.Windows.Forms.DataGridView racunDataGridView;
        private System.Windows.Forms.ComboBox racunComboBox;
        private System.Windows.Forms.Button detaljiRacunaButton;
    }
}

