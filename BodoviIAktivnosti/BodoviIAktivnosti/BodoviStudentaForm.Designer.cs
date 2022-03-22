namespace BodoviIAktivnosti
{
    partial class BodoviStudenta
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
            this.studentiDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.popisProvjeraComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imePrezimeStudentaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dodajStudentaButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bodoviTextBox = new System.Windows.Forms.TextBox();
            this.nazivProvjereTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodajProvjeruButton = new System.Windows.Forms.Button();
            this.ocjeniStudentaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentiDataGridView
            // 
            this.studentiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentiDataGridView.Location = new System.Drawing.Point(23, 44);
            this.studentiDataGridView.Name = "studentiDataGridView";
            this.studentiDataGridView.Size = new System.Drawing.Size(404, 217);
            this.studentiDataGridView.TabIndex = 0;
            this.studentiDataGridView.SelectionChanged += new System.EventHandler(this.studentiDataGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bodovi studenta";
            // 
            // popisProvjeraComboBox
            // 
            this.popisProvjeraComboBox.FormattingEnabled = true;
            this.popisProvjeraComboBox.Location = new System.Drawing.Point(487, 44);
            this.popisProvjeraComboBox.Name = "popisProvjeraComboBox";
            this.popisProvjeraComboBox.Size = new System.Drawing.Size(225, 21);
            this.popisProvjeraComboBox.TabIndex = 2;
            this.popisProvjeraComboBox.SelectedValueChanged += new System.EventHandler(this.popisProvjeraComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Popis provjera";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imePrezimeStudentaTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dodajStudentaButton);
            this.groupBox1.Location = new System.Drawing.Point(36, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje novog studenta";
            // 
            // imePrezimeStudentaTextBox
            // 
            this.imePrezimeStudentaTextBox.Location = new System.Drawing.Point(110, 23);
            this.imePrezimeStudentaTextBox.Name = "imePrezimeStudentaTextBox";
            this.imePrezimeStudentaTextBox.Size = new System.Drawing.Size(143, 20);
            this.imePrezimeStudentaTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ime i prezime";
            // 
            // dodajStudentaButton
            // 
            this.dodajStudentaButton.Location = new System.Drawing.Point(283, 21);
            this.dodajStudentaButton.Name = "dodajStudentaButton";
            this.dodajStudentaButton.Size = new System.Drawing.Size(75, 23);
            this.dodajStudentaButton.TabIndex = 0;
            this.dodajStudentaButton.Text = "Dodaj";
            this.dodajStudentaButton.UseVisualStyleBackColor = true;
            this.dodajStudentaButton.Click += new System.EventHandler(this.dodajStudentaButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bodoviTextBox);
            this.groupBox2.Controls.Add(this.nazivProvjereTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dodajProvjeruButton);
            this.groupBox2.Location = new System.Drawing.Point(490, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 215);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodavanje nove provjere";
            // 
            // bodoviTextBox
            // 
            this.bodoviTextBox.Location = new System.Drawing.Point(37, 141);
            this.bodoviTextBox.Name = "bodoviTextBox";
            this.bodoviTextBox.Size = new System.Drawing.Size(133, 20);
            this.bodoviTextBox.TabIndex = 4;
            // 
            // nazivProvjereTextBox
            // 
            this.nazivProvjereTextBox.Location = new System.Drawing.Point(37, 68);
            this.nazivProvjereTextBox.Name = "nazivProvjereTextBox";
            this.nazivProvjereTextBox.Size = new System.Drawing.Size(133, 20);
            this.nazivProvjereTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mogući bodovi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Naziv provjere";
            // 
            // dodajProvjeruButton
            // 
            this.dodajProvjeruButton.Location = new System.Drawing.Point(97, 181);
            this.dodajProvjeruButton.Name = "dodajProvjeruButton";
            this.dodajProvjeruButton.Size = new System.Drawing.Size(119, 23);
            this.dodajProvjeruButton.TabIndex = 0;
            this.dodajProvjeruButton.Text = "Dodaj provjeru";
            this.dodajProvjeruButton.UseVisualStyleBackColor = true;
            this.dodajProvjeruButton.Click += new System.EventHandler(this.dodajProvjeruButton_Click);
            // 
            // ocjeniStudentaButton
            // 
            this.ocjeniStudentaButton.Location = new System.Drawing.Point(636, 387);
            this.ocjeniStudentaButton.Name = "ocjeniStudentaButton";
            this.ocjeniStudentaButton.Size = new System.Drawing.Size(126, 51);
            this.ocjeniStudentaButton.TabIndex = 6;
            this.ocjeniStudentaButton.Text = "Ocjeni studenta";
            this.ocjeniStudentaButton.UseVisualStyleBackColor = true;
            this.ocjeniStudentaButton.Click += new System.EventHandler(this.ocjeniStudentaButton_Click);
            // 
            // BodoviStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ocjeniStudentaButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.popisProvjeraComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentiDataGridView);
            this.Name = "BodoviStudenta";
            this.Text = "Bodovi studenta";
            this.Load += new System.EventHandler(this.BodoviStudenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentiDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox popisProvjeraComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dodajStudentaButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dodajProvjeruButton;
        private System.Windows.Forms.Button ocjeniStudentaButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imePrezimeStudentaTextBox;
        private System.Windows.Forms.TextBox bodoviTextBox;
        private System.Windows.Forms.TextBox nazivProvjereTextBox;
    }
}

