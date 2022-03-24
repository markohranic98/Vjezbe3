namespace RacuniITransakcije
{
    partial class BankaForm
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
            this.racuniDataGridView = new System.Windows.Forms.DataGridView();
            this.prikaziButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // racuniDataGridView
            // 
            this.racuniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racuniDataGridView.Location = new System.Drawing.Point(13, 13);
            this.racuniDataGridView.Name = "racuniDataGridView";
            this.racuniDataGridView.Size = new System.Drawing.Size(593, 286);
            this.racuniDataGridView.TabIndex = 0;
            // 
            // prikaziButton
            // 
            this.prikaziButton.Location = new System.Drawing.Point(474, 322);
            this.prikaziButton.Name = "prikaziButton";
            this.prikaziButton.Size = new System.Drawing.Size(122, 23);
            this.prikaziButton.TabIndex = 1;
            this.prikaziButton.Text = "Prikazi transakcije";
            this.prikaziButton.UseVisualStyleBackColor = true;
            this.prikaziButton.Click += new System.EventHandler(this.prikaziButton_Click);
            // 
            // BankaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 362);
            this.Controls.Add(this.prikaziButton);
            this.Controls.Add(this.racuniDataGridView);
            this.Name = "BankaForm";
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.BankaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView racuniDataGridView;
        private System.Windows.Forms.Button prikaziButton;
    }
}

