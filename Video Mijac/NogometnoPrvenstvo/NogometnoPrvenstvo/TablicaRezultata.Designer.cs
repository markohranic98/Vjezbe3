namespace NogometnoPrvenstvo
{
    partial class TablicaRezultata
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
            this.utakmiceDataGridView = new System.Windows.Forms.DataGridView();
            this.dodajButton = new System.Windows.Forms.Button();
            this.izmijeniButton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.utakmiceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis utakmica";
            // 
            // utakmiceDataGridView
            // 
            this.utakmiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utakmiceDataGridView.Location = new System.Drawing.Point(32, 43);
            this.utakmiceDataGridView.Name = "utakmiceDataGridView";
            this.utakmiceDataGridView.Size = new System.Drawing.Size(956, 402);
            this.utakmiceDataGridView.TabIndex = 1;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(664, 466);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(114, 23);
            this.dodajButton.TabIndex = 2;
            this.dodajButton.Text = "Dodaj utakmicu";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // izmijeniButton
            // 
            this.izmijeniButton.Location = new System.Drawing.Point(784, 466);
            this.izmijeniButton.Name = "izmijeniButton";
            this.izmijeniButton.Size = new System.Drawing.Size(107, 23);
            this.izmijeniButton.TabIndex = 3;
            this.izmijeniButton.Text = "Izmijeni utakmicu";
            this.izmijeniButton.UseVisualStyleBackColor = true;
            this.izmijeniButton.Click += new System.EventHandler(this.izmijeniButton_Click);
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(897, 466);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(91, 23);
            this.obrisiButton.TabIndex = 4;
            this.obrisiButton.Text = "Obrisi utakmicu";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // TablicaRezultata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 505);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.izmijeniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.utakmiceDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "TablicaRezultata";
            this.Text = "Tablica rezultata";
            this.Load += new System.EventHandler(this.TablicaRezultata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utakmiceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView utakmiceDataGridView;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button izmijeniButton;
        private System.Windows.Forms.Button obrisiButton;
    }
}

