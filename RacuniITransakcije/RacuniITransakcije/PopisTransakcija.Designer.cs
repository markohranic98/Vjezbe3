namespace RacuniITransakcije
{
    partial class PopisTransakcija
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
            this.ibanTextBox = new System.Windows.Forms.TextBox();
            this.stanjeTextBox = new System.Windows.Forms.TextBox();
            this.VlasnikTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sveButton = new System.Windows.Forms.RadioButton();
            this.uplateButton = new System.Windows.Forms.RadioButton();
            this.isplateButton = new System.Windows.Forms.RadioButton();
            this.primijeniButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VlasnikTextBox);
            this.groupBox1.Controls.Add(this.stanjeTextBox);
            this.groupBox1.Controls.Add(this.ibanTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o racunu";
            // 
            // ibanTextBox
            // 
            this.ibanTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ibanTextBox.Location = new System.Drawing.Point(19, 29);
            this.ibanTextBox.Name = "ibanTextBox";
            this.ibanTextBox.Size = new System.Drawing.Size(142, 20);
            this.ibanTextBox.TabIndex = 0;
            // 
            // stanjeTextBox
            // 
            this.stanjeTextBox.Location = new System.Drawing.Point(19, 56);
            this.stanjeTextBox.Name = "stanjeTextBox";
            this.stanjeTextBox.Size = new System.Drawing.Size(142, 20);
            this.stanjeTextBox.TabIndex = 1;
            // 
            // VlasnikTextBox
            // 
            this.VlasnikTextBox.Location = new System.Drawing.Point(19, 83);
            this.VlasnikTextBox.Name = "VlasnikTextBox";
            this.VlasnikTextBox.Size = new System.Drawing.Size(142, 20);
            this.VlasnikTextBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // sveButton
            // 
            this.sveButton.AutoSize = true;
            this.sveButton.Location = new System.Drawing.Point(48, 344);
            this.sveButton.Name = "sveButton";
            this.sveButton.Size = new System.Drawing.Size(42, 17);
            this.sveButton.TabIndex = 2;
            this.sveButton.TabStop = true;
            this.sveButton.Text = "sve";
            this.sveButton.UseVisualStyleBackColor = true;
            // 
            // uplateButton
            // 
            this.uplateButton.AutoSize = true;
            this.uplateButton.Location = new System.Drawing.Point(127, 344);
            this.uplateButton.Name = "uplateButton";
            this.uplateButton.Size = new System.Drawing.Size(54, 17);
            this.uplateButton.TabIndex = 3;
            this.uplateButton.TabStop = true;
            this.uplateButton.Text = "uplate";
            this.uplateButton.UseVisualStyleBackColor = true;
            // 
            // isplateButton
            // 
            this.isplateButton.AutoSize = true;
            this.isplateButton.Location = new System.Drawing.Point(219, 344);
            this.isplateButton.Name = "isplateButton";
            this.isplateButton.Size = new System.Drawing.Size(55, 17);
            this.isplateButton.TabIndex = 4;
            this.isplateButton.TabStop = true;
            this.isplateButton.Text = "isplate";
            this.isplateButton.UseVisualStyleBackColor = true;
            // 
            // primijeniButton
            // 
            this.primijeniButton.Location = new System.Drawing.Point(357, 341);
            this.primijeniButton.Name = "primijeniButton";
            this.primijeniButton.Size = new System.Drawing.Size(75, 23);
            this.primijeniButton.TabIndex = 5;
            this.primijeniButton.Text = "Primijeni";
            this.primijeniButton.UseVisualStyleBackColor = true;
            this.primijeniButton.Click += new System.EventHandler(this.primijeniButton_Click);
            // 
            // PopisTransakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 392);
            this.Controls.Add(this.primijeniButton);
            this.Controls.Add(this.isplateButton);
            this.Controls.Add(this.uplateButton);
            this.Controls.Add(this.sveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PopisTransakcija";
            this.Text = "PopisTransakcija";
            this.Load += new System.EventHandler(this.PopisTransakcija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox VlasnikTextBox;
        private System.Windows.Forms.TextBox stanjeTextBox;
        private System.Windows.Forms.TextBox ibanTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton sveButton;
        private System.Windows.Forms.RadioButton uplateButton;
        private System.Windows.Forms.RadioButton isplateButton;
        private System.Windows.Forms.Button primijeniButton;
    }
}